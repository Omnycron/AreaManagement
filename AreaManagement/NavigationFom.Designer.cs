using System.Windows.Forms;

namespace AreaManagement
{
    partial class NavigationForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tenantDataGridView = new System.Windows.Forms.DataGridView();
            this.createTenant = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.roomsAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.createRoom = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.createInventoryItemType = new System.Windows.Forms.Button();
            this.inventoryItemTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsAdminDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 7);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 417);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.roomsDataGridView);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(765, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mieter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Location = new System.Drawing.Point(3, 27);
            this.roomsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.RowHeadersVisible = false;
            this.roomsDataGridView.RowTemplate.Height = 33;
            this.roomsDataGridView.Size = new System.Drawing.Size(762, 363);
            this.roomsDataGridView.TabIndex = 0;
            this.roomsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGridView_CellContentClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 21);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(765, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(759, 386);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tenantDataGridView);
            this.tabPage3.Controls.Add(this.createTenant);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(751, 360);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Mieter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tenantDataGridView
            // 
            this.tenantDataGridView.AllowUserToAddRows = false;
            this.tenantDataGridView.AllowUserToDeleteRows = false;
            this.tenantDataGridView.AllowUserToResizeColumns = false;
            this.tenantDataGridView.AllowUserToResizeRows = false;
            this.tenantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tenantDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tenantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tenantDataGridView.Location = new System.Drawing.Point(2, 29);
            this.tenantDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tenantDataGridView.Name = "tenantDataGridView";
            this.tenantDataGridView.ReadOnly = true;
            this.tenantDataGridView.RowHeadersVisible = false;
            this.tenantDataGridView.RowTemplate.Height = 33;
            this.tenantDataGridView.Size = new System.Drawing.Size(746, 332);
            this.tenantDataGridView.TabIndex = 6;
            this.tenantDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tenantDataGridView_CellClick);
            // 
            // createTenant
            // 
            this.createTenant.Location = new System.Drawing.Point(4, 4);
            this.createTenant.Margin = new System.Windows.Forms.Padding(2);
            this.createTenant.Name = "createTenant";
            this.createTenant.Size = new System.Drawing.Size(92, 21);
            this.createTenant.TabIndex = 5;
            this.createTenant.Text = "Mieter anlegen";
            this.createTenant.UseVisualStyleBackColor = true;
            this.createTenant.Click += new System.EventHandler(this.CreateTenant_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.roomsAdminDataGridView);
            this.tabPage4.Controls.Add(this.createRoom);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(751, 360);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Räume";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // roomsAdminDataGridView
            // 
            this.roomsAdminDataGridView.AllowUserToAddRows = false;
            this.roomsAdminDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomsAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsAdminDataGridView.Location = new System.Drawing.Point(6, 31);
            this.roomsAdminDataGridView.Name = "roomsAdminDataGridView";
            this.roomsAdminDataGridView.RowHeadersVisible = false;
            this.roomsAdminDataGridView.Size = new System.Drawing.Size(740, 326);
            this.roomsAdminDataGridView.TabIndex = 5;
            this.roomsAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsAdminDataGridView_CellClick);
            // 
            // createRoom
            // 
            this.createRoom.Location = new System.Drawing.Point(4, 4);
            this.createRoom.Margin = new System.Windows.Forms.Padding(2);
            this.createRoom.Name = "createRoom";
            this.createRoom.Size = new System.Drawing.Size(96, 21);
            this.createRoom.TabIndex = 4;
            this.createRoom.Text = "Raum anlegen";
            this.createRoom.UseVisualStyleBackColor = true;
            this.createRoom.Click += new System.EventHandler(this.CreateRoom_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.createInventoryItemType);
            this.tabPage5.Controls.Add(this.inventoryItemTypeDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(751, 360);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Einrichtung";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // createInventoryItemType
            // 
            this.createInventoryItemType.Location = new System.Drawing.Point(4, 4);
            this.createInventoryItemType.Margin = new System.Windows.Forms.Padding(2);
            this.createInventoryItemType.Name = "createInventoryItemType";
            this.createInventoryItemType.Size = new System.Drawing.Size(145, 23);
            this.createInventoryItemType.TabIndex = 1;
            this.createInventoryItemType.Text = "Einrichtungsstück anlegen";
            this.createInventoryItemType.UseVisualStyleBackColor = true;
            this.createInventoryItemType.Click += new System.EventHandler(this.createInventoryItemType_Click);
            // 
            // inventoryItemTypeDataGridView
            // 
            this.inventoryItemTypeDataGridView.AllowUserToAddRows = false;
            this.inventoryItemTypeDataGridView.AllowUserToDeleteRows = false;
            this.inventoryItemTypeDataGridView.AllowUserToResizeColumns = false;
            this.inventoryItemTypeDataGridView.AllowUserToResizeRows = false;
            this.inventoryItemTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryItemTypeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventoryItemTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryItemTypeDataGridView.Location = new System.Drawing.Point(4, 30);
            this.inventoryItemTypeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryItemTypeDataGridView.Name = "inventoryItemTypeDataGridView";
            this.inventoryItemTypeDataGridView.ReadOnly = true;
            this.inventoryItemTypeDataGridView.RowHeadersVisible = false;
            this.inventoryItemTypeDataGridView.RowTemplate.Height = 33;
            this.inventoryItemTypeDataGridView.Size = new System.Drawing.Size(744, 331);
            this.inventoryItemTypeDataGridView.TabIndex = 0;
            this.inventoryItemTypeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryItemTypeDataGridView_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 4);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 431);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NavigationForm";
            this.Text = "Flächenverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tenantDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsAdminDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemTypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button createTenant;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button createRoom;
        private TabPage tabPage5;
        private DataGridView tenantDataGridView;
        private Button createInventoryItemType;
        private DataGridView inventoryItemTypeDataGridView;
        private DataGridView roomsAdminDataGridView;
    }
}

