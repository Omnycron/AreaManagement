using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement
{
    [Serializable]
    public class InventoryItemType
    {
        private string name;
        private int id;
        private double rent;

        public InventoryItemType(string itemName, double itemRent)
        {
            name = itemName;
            id = GetNextId();
            rent = itemRent;
        }

        public double GetRent()
        {
            return rent;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetId() => id;

        private int GetNextId()
        {
            int maxId = -1;
            if(Program.building.GetInventoryItemTypes() == null)
            {
                return 0;
            }
            foreach (InventoryItemType itt in Program.building.GetInventoryItemTypes())
            {
                if (itt.GetId() > maxId)
                {
                    maxId = itt.id;
                }
            }
            return maxId + 1;
        }
    }
}
