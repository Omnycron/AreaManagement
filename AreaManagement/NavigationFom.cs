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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadRooms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateRoom f2 = new CreateRoom();
            f2.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e) => Program.dataManagement.SaveBuilding();

        private void ReloadRooms()
        {
            this.roomsDataGridView.DataSource = Program.dataManagement.GetRooms();
            //this.roomsDataGridView.AutoResizeColumns(); //funktioniert nicht mit AutoResizeMode.Fill
        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoom createRoomForm = new CreateRoom();
            createRoomForm.ShowDialog();
            this.roomsDataGridView.DataSource = Program.dataManagement.GetRooms();
        }

        private void CreateTenant_Click(object sender, EventArgs e)
        {
            CreateTenant createTenantForm = new CreateTenant();
            createTenantForm.ShowDialog();

        }

        private void roomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
