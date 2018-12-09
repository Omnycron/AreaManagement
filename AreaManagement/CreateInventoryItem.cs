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
            string name = inventoryItemName.Text;
            int type = Convert.ToInt32(inventoryItemType.SelectedValue);
            room.AddInventoryItem(name, type);
            List<Room> tempRooms = Program.building.GetRooms();
            for (int i = 0; i<tempRooms.Count; i++)
            {
                if (tempRooms[i].GetId() == room.GetId())
                {
                    tempRooms[i] = room;
                    Program.building.SetRooms(tempRooms);
                }
            }
            EditRoom er = (EditRoom)Application.OpenForms["EditRoom"];
            er.ReloadInventoryTable();
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
