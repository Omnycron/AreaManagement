using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement
{
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
    }
}
