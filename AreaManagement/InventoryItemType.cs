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

        public InventoryItemType(string itemName, int itemId, double itemRent)
        {
            name = itemName;
            id = itemId;
            rent = itemRent;
        }

        public double GetRent()
        {
            return rent;
        }
    }
}
