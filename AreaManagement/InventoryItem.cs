using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaManagement
{
    [Serializable]
    public class InventoryItem
    {
        private string name;
        private int inventoryItemTypeId;
        private string status;//defekt, beschädigt, intakt

        public InventoryItem(string itemName, int itemType, string itemStatus)
        {
            name = itemName;
            inventoryItemTypeId = itemType;
            status = itemStatus;
        }

        public double GetRent()
        {
            return Program.dataManagement.GetIventoryItemTypeById(this.inventoryItemTypeId).GetRent();
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetInventoryItemType()
        {
            return this.inventoryItemTypeId;
        }

        public string GetStatus()
        {
            return this.status;
        }
    }
}
