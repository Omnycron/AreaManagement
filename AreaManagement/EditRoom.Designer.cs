namespace AreaManagement
{
    partial class EditRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roomSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roomNumberSeatingPositions = new System.Windows.Forms.TextBox();
            this.roomNumberWorkingPlaces = new System.Windows.Forms.TextBox();
            this.createInventoryItemButton = new System.Windows.Forms.Button();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.roomTypeOfUse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomTenant = new System.Windows.Forms.ComboBox();
            this.inventoryItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemsDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.roomSize, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roomName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomNumberSeatingPositions, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomNumberWorkingPlaces, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.createInventoryItemButton, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.roomType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomTypeOfUse, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.roomTenant, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roomSize
            // 
            this.roomSize.Location = new System.Drawing.Point(445, 3);
            this.roomSize.Name = "roomSize";
            this.roomSize.ReadOnly = true;
            this.roomSize.Size = new System.Drawing.Size(75, 20);
            this.roomSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Größe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mieter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // roomName
            // 
            this.roomName.Location = new System.Drawing.Point(47, 3);
            this.roomName.Name = "roomName";
            this.roomName.ReadOnly = true;
            this.roomName.Size = new System.Drawing.Size(119, 20);
            this.roomName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Typ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nutzungsart:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Anzahl Sitzplätze:";
            // 
            // roomNumberSeatingPositions
            // 
            this.roomNumberSeatingPositions.Location = new System.Drawing.Point(637, 30);
            this.roomNumberSeatingPositions.Name = "roomNumberSeatingPositions";
            this.roomNumberSeatingPositions.Size = new System.Drawing.Size(129, 20);
            this.roomNumberSeatingPositions.TabIndex = 11;
            // 
            // roomNumberWorkingPlaces
            // 
            this.roomNumberWorkingPlaces.Location = new System.Drawing.Point(445, 30);
            this.roomNumberWorkingPlaces.Name = "roomNumberWorkingPlaces";
            this.roomNumberWorkingPlaces.Size = new System.Drawing.Size(75, 20);
            this.roomNumberWorkingPlaces.TabIndex = 12;
            // 
            // createInventoryItemButton
            // 
            this.createInventoryItemButton.Location = new System.Drawing.Point(637, 57);
            this.createInventoryItemButton.Name = "createInventoryItemButton";
            this.createInventoryItemButton.Size = new System.Drawing.Size(129, 23);
            this.createInventoryItemButton.TabIndex = 15;
            this.createInventoryItemButton.Text = "Inventar mieten";
            this.createInventoryItemButton.UseVisualStyleBackColor = true;
            this.createInventoryItemButton.Click += new System.EventHandler(this.CreateInventoryItemButton_Click);
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Items.AddRange(new object[] {
            "Ruhezone",
            "Gemeinschaftsbereich",
            "Arbeitsraum"});
            this.roomType.Location = new System.Drawing.Point(47, 30);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(119, 21);
            this.roomType.TabIndex = 16;
            // 
            // roomTypeOfUse
            // 
            this.roomTypeOfUse.FormattingEnabled = true;
            this.roomTypeOfUse.Items.AddRange(new object[] {
            "Büro",
            "Meetingraum",
            "Flur",
            "Sanitär",
            "Aufenthaltsraum"});
            this.roomTypeOfUse.Location = new System.Drawing.Point(245, 30);
            this.roomTypeOfUse.Name = "roomTypeOfUse";
            this.roomTypeOfUse.Size = new System.Drawing.Size(94, 21);
            this.roomTypeOfUse.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Anzahl Arbeitsplätze:";
            // 
            // roomTenant
            // 
            this.roomTenant.FormattingEnabled = true;
            this.roomTenant.Location = new System.Drawing.Point(245, 3);
            this.roomTenant.Name = "roomTenant";
            this.roomTenant.Size = new System.Drawing.Size(94, 21);
            this.roomTenant.TabIndex = 18;
            // 
            // inventoryItemsDataGridView
            // 
            this.inventoryItemsDataGridView.AllowUserToAddRows = false;
            this.inventoryItemsDataGridView.AllowUserToDeleteRows = false;
            this.inventoryItemsDataGridView.AllowUserToResizeColumns = false;
            this.inventoryItemsDataGridView.AllowUserToResizeRows = false;
            this.inventoryItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryItemsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventoryItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryItemsDataGridView.Location = new System.Drawing.Point(13, 100);
            this.inventoryItemsDataGridView.Name = "inventoryItemsDataGridView";
            this.inventoryItemsDataGridView.RowHeadersVisible = false;
            this.inventoryItemsDataGridView.Size = new System.Drawing.Size(775, 319);
            this.inventoryItemsDataGridView.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 422);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 25);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(697, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(616, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.inventoryItemsDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditRoom";
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemsDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox roomSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomNumberSeatingPositions;
        private System.Windows.Forms.TextBox roomNumberWorkingPlaces;
        private System.Windows.Forms.Button createInventoryItemButton;
        private System.Windows.Forms.DataGridView inventoryItemsDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox roomType;
        private System.Windows.Forms.ComboBox roomTypeOfUse;
        private System.Windows.Forms.ComboBox roomTenant;
    }
}