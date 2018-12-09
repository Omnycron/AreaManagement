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
            ReloadAllTables();
        }

        public void ReloadAllTables()
        {
            ReloadRooms();
            ReloadInventoryItemTypes();
            ReloadTenants();
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
            this.roomsDataGridView.DataSource = Program.dataManagement.GetRoomsDataTable();
            this.roomsAdminDataGridView.DataSource = Program.dataManagement.GetRoomsDataTable();
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "deleteButton_column";
            deleteButtonColumn.Text = "Löschen";
            deleteButtonColumn.HeaderText = "Löschen";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 100;
            int columnIndex = 7;
            if (tenantDataGridView.Columns["deleteButton_column"] == null)
            {
                roomsAdminDataGridView.Columns.Insert(columnIndex, deleteButtonColumn);
            }
        }

        private void ReloadInventoryItemTypes()
        {
            this.inventoryItemTypeDataGridView.DataSource = Program.dataManagement.GetInventoryItemTypesDataTable();
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "deleteButton_column";
            deleteButtonColumn.Text = "Löschen";
            deleteButtonColumn.HeaderText = "Löschen";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 100;
            int columnIndex = 3;
            if (tenantDataGridView.Columns["deleteButton_column"] == null)
            {
                inventoryItemTypeDataGridView.Columns.Insert(columnIndex, deleteButtonColumn);
            }
        }

        private void ReloadTenants()
        {
            this.tenantDataGridView.DataSource = Program.dataManagement.GetTenantDataTable();
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "deleteButton_column";
            deleteButtonColumn.Text = "Löschen";
            deleteButtonColumn.HeaderText = "Löschen";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 100;
            int columnIndex = 2;
            if (tenantDataGridView.Columns["deleteButton_column"] == null)
            {
                tenantDataGridView.Columns.Insert(columnIndex, deleteButtonColumn);
            }
        }

        private void CreateRoom_Click(object sender, EventArgs e)
        {
            CreateRoom createRoomForm = new CreateRoom();
            createRoomForm.ShowDialog();
            this.roomsDataGridView.DataSource = Program.dataManagement.GetRoomsDataTable();
        }

        private void CreateTenant_Click(object sender, EventArgs e)
        {
            CreateTenant createTenantForm = new CreateTenant();
            createTenantForm.ShowDialog();

        }

        private void RoomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                {
                    return;
                }

                int roomId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
                Room room = Program.dataManagement.GetRoom(roomId);
                if (room!=null)
                {
                    EditRoom er = new EditRoom(room);
                    er.ShowDialog();
                }
                
            }
            catch (Exception exc)
            {

            }
        }

        private void createInventoryItemType_Click(object sender, EventArgs e)
        {
            CreateInventoryItemType citt = new CreateInventoryItemType();
            citt.ShowDialog();
        }

        private void tenantDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == tenantDataGridView.Columns["deleteButton_column"].Index)
                {
                    if (tenantDataGridView.Rows[e.RowIndex].Cells["Id"].Value != null)
                    {
                        int id = Convert.ToInt32(tenantDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                        List <Tenant> tmp = Program.building.GetTenants();
                        foreach (Tenant tenant in tmp)
                        {
                            if(tenant.GetId() == id)
                            {
                                tmp.Remove(tenant);
                                break;
                            }
                        }
                        Program.building.SetTenants(tmp);
                    }
                }
            } catch
            {

            } finally
            {
                ReloadAllTables();
            }
        }

        private void roomsAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == roomsAdminDataGridView.Columns["deleteButton_column"].Index)
                {
                    if (roomsAdminDataGridView.Rows[e.RowIndex].Cells["Id"].Value != null)
                    {
                        int id = Convert.ToInt32(roomsAdminDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                        List<Room> tmp = Program.building.GetRooms();
                        foreach (Room room in tmp)
                        {
                            if (room.GetId() == id)
                            {
                                tmp.Remove(room);
                                break;
                            }
                        }
                        Program.building.SetRooms(tmp);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                ReloadAllTables();
            }
        }

        private void inventoryItemTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == inventoryItemTypeDataGridView.Columns["deleteButton_column"].Index)
                {
                    if (inventoryItemTypeDataGridView.Rows[e.RowIndex].Cells["Id"].Value != null)
                    {
                        int id = Convert.ToInt32(inventoryItemTypeDataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                        List<InventoryItemType> tmp = Program.building.GetInventoryItemTypes();
                        foreach (InventoryItemType room in tmp)
                        {
                            if (room.GetId() == id)
                            {
                                tmp.Remove(room);
                                break;
                            }
                        }
                        Program.building.SetInventoryItemTypes(tmp);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                ReloadAllTables();
            }
        }
    }
}
