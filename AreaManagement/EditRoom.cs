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
    public partial class EditRoom : Form
    {
        private Room room;
        public EditRoom(Room r)
        {
            this.room = r;

            InitializeComponent();
            PresetFields();
        }

        private void PresetFields()
        {
            this.roomName.Text = room.GetName();
            this.roomTenant.Text = "?";
            this.roomSize.Text = room.GetArea().ToString();
            this.roomNumberSeatingPositions.Text = room.GetNumberSeatingPositions().ToString();
            this.roomNumberWorkingPlaces.Text = room.GetNumberWorkingPlaces().ToString();
            this.roomType.Text = room.GetRoomType();
            this.roomTypeOfUse.Text = room.GetTypeOfUse();

            this.inventoryItemsDataGridView.DataSource = Program.dataManagement.GetInventoryItems(this.room);
        }

        private void CreateInventoryItemButton_Click(object sender, EventArgs e)
        {
            CreateInventoryItem cii = new CreateInventoryItem(this.room);
            cii.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.room.SetNumberWorkingPlaces(Convert.ToInt32(roomNumberWorkingPlaces.Text));
            this.room.SetNumberSeatingPositions(Convert.ToInt32(roomNumberSeatingPositions.Text));
            this.room.SetRoomType(roomType.Text);
            this.room.SetTypeOfUse(roomTypeOfUse.Text);

            Program.dataManagement.SaveRoom(this.room);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            PresetFields();
        }
    }
}
