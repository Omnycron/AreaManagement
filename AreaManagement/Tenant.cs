using System;
using System.Collections.Generic;

namespace AreaManagement
{
    [Serializable]
    class Tenant
    {
        private string name;
        private int id;
        private List<Room> rooms;

        public Tenant(string tName)
        {
            name = tName;
            rooms = new List<Room>();
        }

        public double CalculateTotalRent()
        {
            double totalRent = 0;
            foreach (Room room in rooms)
            {
                totalRent += room.CalculateTotalRent();
            }
            return totalRent;
        }

        public void RentRoom(Room room)
        {
            rooms.Add(room);
        }
    }
}