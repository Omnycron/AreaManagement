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
        }

        private void CreateInventoryItemButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
