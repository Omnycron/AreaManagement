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

        public Building()
        {
            rooms = new List<Room>();
            tenants = new List<Tenant>();
        }

        public List<Room> GetRooms() => rooms;

        public List<Tenant> GetTenants() => tenants;

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

    }
}
