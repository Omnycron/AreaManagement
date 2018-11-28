using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement
{
    [Serializable]
    class InventoryItem
    {
        private string name;
        private InventoryItemType type;
        private int id;
        private string status;//defekt, beschädigt, intakt

        public InventoryItem(string itemName, InventoryItemType itemType, int itemId, string itemStatus)
        {
            name = itemName;
            type = itemType;
            id = itemId;
            status = itemStatus;
        }

        public double GetRent()
        {
            return type.GetRent();
        }

    }
}
