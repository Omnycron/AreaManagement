using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaManagement
{
    [Serializable]
    public class Room
    {
        private int id;
        private string name;
        private double area;
        private string typeOfUse;
        private string type;
        private int numberWorkingPlaces;
        private int numberSeatingPositions;
        private double rent;
        private List<InventoryItem> inventory;

        public Room(string rName, double rArea, double rRent)
        {
            id = NextId();
            name = rName;
            area = rArea;
            rent = rRent;
            inventory = new List<InventoryItem>();
        }

        public double GetArea()
        {
            return area;
        }

        public void SetNumberWorkingPlaces(int numberWorkingPlaces)
        {
            this.numberWorkingPlaces = numberWorkingPlaces;
        }

        public int GetNumberWorkingPlaces()
        {
            return this.numberWorkingPlaces;
        }

        public void SetNumberSeatingPositions(int numberSeatingPositions)
        {
            this.numberSeatingPositions = numberSeatingPositions;
        }

        public int GetNumberSeatingPositions()
        {
            return this.numberSeatingPositions;
        }

        public void SetTypeOfUse(string typeOfUse)
        {
            this.typeOfUse = typeOfUse;
        }

        public string GetTypeOfUse()
        {
            return this.typeOfUse;
        }

        public void SetRoomType(string type)
        {
            this.type = type;
        }

        public string GetRoomType()
        {
            return this.type;
        }

        public double CalculateTotalRent()
        {
            double totalRent = rent;
            foreach(InventoryItem item in inventory)
            {
                totalRent += item.GetRent();
            }
            return totalRent;
        }

        public void AddInventoryItem(string name, int type)
        {
            InventoryItem newItem = new InventoryItem(name, type, "intakt");//TODO: Ids vortlaufend vergeben
            inventory.Add(newItem);
        }

        public string GetName()
        {
            return name;
        }

        public double GetRent()
        {
            return rent;
        }

        public int GetInventoryItemCount()
        {
            return inventory.Count();
            
        }

        public int GetId()
        {
            return id;
        }

        private int NextId()
        {
            int maxId = -1;
            foreach(Room room in Program.building.GetRooms())
            {
                if (room.id > maxId)
                {
                    maxId = room.id;
                }
            }
            return maxId + 1;
        }

        public List<InventoryItem> GetInventory()
        {
            return this.inventory;
        }
    }
}
