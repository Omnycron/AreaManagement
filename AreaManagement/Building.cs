using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement
{
    /// <summary>
    /// this class stores all data used in the application.
    /// It is serializable in order to save the data to a file and reload them on program start
    /// </summary>
    [Serializable]
    class Building
    {
        private List<Room> rooms;
        private List<Tenant> tenants;
        private List<InventoryItemType> inventoryItemTypes;

        public Building()
        {
            rooms = new List<Room>();
            tenants = new List<Tenant>();
            inventoryItemTypes = new List<InventoryItemType>();
        }

        public List<Room> GetRooms() => rooms;

        public List<Tenant> GetTenants() => tenants;

        public List<InventoryItemType> GetInventoryItemTypes()
        {
            return inventoryItemTypes;
        }

        public void AddRoom(string name, double area, double rent)
        {
            Room newRoom = new Room(name, area, rent);
            rooms.Add(newRoom);
        }

        public void AddTenant(string name)
        {
            Tenant newTenant = new Tenant(name);
            tenants.Add(newTenant);
        }

        public void AddInventoryItemType(string name, double rent)
        {
            InventoryItemType newItt = new InventoryItemType(name, rent);
            inventoryItemTypes.Add(newItt);
        }

        public void SetRooms(List<Room> rooms)
        {
            this.rooms = rooms;
            return;
        }

        public void SetTenants(List<Tenant> tenants)
        {
            this.tenants = tenants;
        }

        public void SetInventoryItemTypes(List<InventoryItemType> inventoryItemTypes)
        {
            this.inventoryItemTypes = inventoryItemTypes;
        }
    }
}
