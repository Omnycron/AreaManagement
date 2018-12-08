using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaManagement
{
    public partial class CreateInventoryItem : Form
    {
        private Room room;
        public CreateInventoryItem(Room room)
        {
            this.room = room;
            InitializeComponent();
            FillComboBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InventoryItem inventoryItem = new InventoryItem(inventoryItemName.Text, Convert.ToInt32(inventoryItemType.ValueMember), "intakt");
            for(int i = 0; i<Program.building.GetRooms().Count; i++)
            {
                if (Program.building.GetRooms()[i].GetId() == room.GetId())
                {
                    Program.building.GetRooms()[i] = room;
                }
            }
            this.Close();
            return;
        }

        private void FillComboBox()
        {
            this.inventoryItemType.DataSource = Program.dataManagement.GetInventoryItemTypesDataTable().DefaultView;
            this.inventoryItemType.ValueMember = "Id";
            this.inventoryItemType.DisplayMember = "Name";
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
