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
            FillComboBox();
        }

        private void PresetFields()
        {
            this.roomName.Text = room.GetName();
            this.roomTenant.SelectedValue = room.GetTenantId();
            this.roomSize.Text = room.GetArea().ToString();
            this.roomNumberSeatingPositions.Text = room.GetNumberSeatingPositions().ToString();
            this.roomNumberWorkingPlaces.Text = room.GetNumberWorkingPlaces().ToString();
            this.roomType.Text = room.GetRoomType();
            this.roomTypeOfUse.Text = room.GetTypeOfUse();

            ReloadInventoryTable();
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
            this.room.SetTenant(Convert.ToInt32(roomTenant.SelectedValue));

            UpdateIventoryItems();

            Program.dataManagement.SaveRoom(this.room);
            NavigationForm nf = (NavigationForm)Application.OpenForms["NavigationForm"];
            nf.ReloadAllTables();
            this.Close();
        }

        private void UpdateIventoryItems()
        {
            List<InventoryItem> inventoryItems = new List<InventoryItem>();
            foreach(DataGridViewRow row in this.inventoryItemsDataGridView.Rows)
            {
                string name = row.Cells["Name"].Value.ToString();
                int inventoryItemType = Convert.ToInt32(row.Cells["TypId"].Value);
                string status = row.Cells["Status"].Value.ToString();
                InventoryItem inventoryItem = new InventoryItem(name, inventoryItemType, status);
                inventoryItems.Add(inventoryItem);
            }
            room.SetInventory(inventoryItems);
        }

        private void FillComboBox()
        {
            this.roomTenant.DataSource = Program.dataManagement.GetTenantDataTable().DefaultView;
            this.roomTenant.ValueMember = "Id";
            this.roomTenant.DisplayMember = "Name";

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            PresetFields();
        }

        public void ReloadInventoryTable()
        {
            this.inventoryItemsDataGridView.DataSource = Program.dataManagement.GetInventoryItemsDataTable(this.room);
            this.inventoryItemsDataGridView.Columns["TypId"].Visible = false;
        }
    }
}
