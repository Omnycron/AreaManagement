using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AreaManagement
{
    class DataManagement
    {
        static readonly string basicPath = "C:/dev/Gruppe 6/Hausübung 1/AreaManagement";
        static readonly string extension = ".area";
        static readonly string buildingPath = basicPath + "Building" + extension;

        public InventoryItemType GetIventoryItemTypeById(int inventoryItemTypeId)
        {
            InventoryItemType result = null;
            foreach(InventoryItemType iit in Program.building.GetInventoryItemTypes())
            {
                if (iit.GetId() == inventoryItemTypeId)
                {
                    result = iit;
                    break;
                }
            }
            return result;
        }


        private void Save(string filepath, object obj)
        {
            FileStream fs = new FileStream(filepath, FileMode.Create); //Create forces a create -> old file overwritten
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj);
            fs.Close();
        }

        public void SaveBuilding()
        {
            Save(buildingPath, Program.building);
        }


        private Object Load(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object loadedObject = bf.Deserialize(fs);
            fs.Close();
            return loadedObject;
        }

        public Building LoadBuilding()
        {
            return (Building)Load(buildingPath);
        }

        public DataTable GetRoomsDataTable()
        {
            DataTable dtRooms = new DataTable();

            DataColumn cId = new DataColumn("Id")
            {
                ReadOnly = true
            };

            DataColumn cName = new DataColumn("Name")
            {
                ReadOnly = true
            };

            DataColumn cTenant = new DataColumn("Mieter")
            {
                ReadOnly = true
            };

            DataColumn cType = new DataColumn("Typ")
            {
                ReadOnly = true
            };

            DataColumn cTypeOfUse = new DataColumn("Nutzungsart")
            {
                ReadOnly = true
            };

            DataColumn cTotalRent = new DataColumn("Miete (€)")
            {
                ReadOnly = true
            };

            DataColumn cInventoryCount = new DataColumn("gemietete Objekte")
            {
                ReadOnly = true
            };

            dtRooms.Columns.Add(cId);
            dtRooms.Columns.Add(cName);
            dtRooms.Columns.Add(cTenant);
            dtRooms.Columns.Add(cType);
            dtRooms.Columns.Add(cTypeOfUse);
            dtRooms.Columns.Add(cTotalRent);
            dtRooms.Columns.Add(cInventoryCount);          


            double sumRent = 0;
            double sumInventoryItemCount = 0;
            foreach(Room room in Program.building.GetRooms())
            {
                double rent = room.CalculateTotalRent();
                double inventoryItemCount = room.GetInventoryItemCount();
                sumRent += rent;
                sumInventoryItemCount += inventoryItemCount;

                DataRow dr = dtRooms.NewRow();
                dr["Id"] = room.GetId();
                dr["Name"] = room.GetName();
                try
                {
                    dr["Mieter"] = GetTenantById(room.GetTenantId()).GetName();
                } catch
                {

                }
                dr["Miete (€)"] = rent;
                dr["gemietete Objekte"] = inventoryItemCount;
                dr["Nutzungsart"] = room.GetTypeOfUse();
                dr["Typ"] = room.GetRoomType();
                dtRooms.Rows.Add(dr);
            }

            DataRow sumRow = dtRooms.NewRow();
            sumRow["Id"] = null;
            sumRow["Name"] = "Summe";
            sumRow["gemietete Objekte"] = null;
            sumRow["Nutzungsart"] = null;
            sumRow["Miete (€)"] = sumRent;
            sumRow["gemietete Objekte"] = sumInventoryItemCount;
            dtRooms.Rows.Add(sumRow);

            return dtRooms;
        }

        private Tenant GetTenantById(int id)
        {
            Tenant tenant = null;
            foreach (Tenant r in Program.building.GetTenants())
            {
                if (id == r.GetId())
                {
                    tenant = r;
                }
            }
            return tenant;
        }

        public Room GetRoom(int id)
        {
            Room room = null;
            foreach (Room r in Program.building.GetRooms())
            {
                if (id == r.GetId())
                {
                    room = r;
                }
            }
            return room;
        }

        public void SaveRoom(Room r)
        {
            for (int i = 0; i<Program.building.GetRooms().Count; i++)
            {
                if (r.GetId() == Program.building.GetRooms()[i].GetId())
                {
                    Program.building.GetRooms()[i] = r;
                }
            }
            return;
        }

        public DataTable GetInventoryItemsDataTable(Room room)
        {
            DataTable inventoryItems = new DataTable();

            DataColumn cName = new DataColumn("Name");
            DataColumn cTyp = new DataColumn("Typ")
            {
                ReadOnly = true
            };
            DataColumn cTypId = new DataColumn("TypId")
            {
                ReadOnly = true
            };
            DataColumn cTotalRent = new DataColumn("Status");
            DataColumn cInventoryRent = new DataColumn("Miete (€)")
            {
                ReadOnly = true
            };


            inventoryItems.Columns.Add(cName);
            inventoryItems.Columns.Add(cTyp);
            inventoryItems.Columns.Add(cTypId);
            inventoryItems.Columns.Add(cTotalRent);
            inventoryItems.Columns.Add(cInventoryRent);

            foreach (InventoryItem inventoryItem in room.GetInventory())
            {
                DataRow dr = inventoryItems.NewRow();
                dr["Name"] = inventoryItem.GetName();
                dr["Typ"] = GetIventoryItemTypeById(inventoryItem.GetInventoryItemType()).GetName();
                dr["Status"] = inventoryItem.GetStatus();
                dr["Miete (€)"] = inventoryItem.GetRent();
                dr["TypId"] = inventoryItem.GetInventoryItemType();
                inventoryItems.Rows.Add(dr);
            }

            return inventoryItems;
        }

        public DataTable GetInventoryItemTypesDataTable()
        {
            DataTable result = new DataTable();

            DataColumn cName = new DataColumn("Name");
            DataColumn cId = new DataColumn("Id");
            DataColumn cRent = new DataColumn("Miete (€)");
           

            result.Columns.Add(cName);
            result.Columns.Add(cId);
            result.Columns.Add(cRent);
            
            foreach (InventoryItemType itt in Program.building.GetInventoryItemTypes())
            {
                DataRow dr = result.NewRow();
                dr["Name"] = itt.GetName();
                dr["Id"] = itt.GetId();
                dr["Miete (€)"] = itt.GetRent();
                result.Rows.Add(dr);
            }

            return result;
        }

        public DataTable GetTenantDataTable()
        {
            DataTable result = new DataTable();

            DataColumn cId = new DataColumn("Id");
            DataColumn cName = new DataColumn("Name");

            result.Columns.Add(cId);
            result.Columns.Add(cName);            

            foreach (Tenant tenant in Program.building.GetTenants())
            {
                DataRow dr = result.NewRow();
                dr["Name"] = tenant.GetName();
                dr["Id"] = tenant.GetId();
                result.Rows.Add(dr);
            }

            return result;
        }
    }
}