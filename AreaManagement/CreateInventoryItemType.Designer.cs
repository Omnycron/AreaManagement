﻿namespace AreaManagement
{
    partial class CreateInventoryItemType
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inventoryItemTypeRent = new System.Windows.Forms.Label();
            this.inventoryItemTypeNameLabel = new System.Windows.Forms.Label();
            this.inventoryItemTypeNameTextbox = new System.Windows.Forms.TextBox();
            this.inventoryItemType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(296, 2);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 22);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Abbrechen";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(222, 2);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 22);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.0027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.99731F));
            this.tableLayoutPanel1.Controls.Add(this.inventoryItemTypeRent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.inventoryItemTypeNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inventoryItemTypeNameTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inventoryItemType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 48);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // inventoryItemTypeRent
            // 
            this.inventoryItemTypeRent.AutoSize = true;
            this.inventoryItemTypeRent.Location = new System.Drawing.Point(2, 24);
            this.inventoryItemTypeRent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryItemTypeRent.Name = "inventoryItemTypeRent";
            this.inventoryItemTypeRent.Size = new System.Drawing.Size(51, 13);
            this.inventoryItemTypeRent.TabIndex = 1;
            this.inventoryItemTypeRent.Text = "Miete (€):";
            // 
            // inventoryItemTypeNameLabel
            // 
            this.inventoryItemTypeNameLabel.AutoSize = true;
            this.inventoryItemTypeNameLabel.Location = new System.Drawing.Point(2, 0);
            this.inventoryItemTypeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inventoryItemTypeNameLabel.Name = "inventoryItemTypeNameLabel";
            this.inventoryItemTypeNameLabel.Size = new System.Drawing.Size(38, 13);
            this.inventoryItemTypeNameLabel.TabIndex = 0;
            this.inventoryItemTypeNameLabel.Text = "Name:";
            // 
            // inventoryItemTypeNameTextbox
            // 
            this.inventoryItemTypeNameTextbox.Location = new System.Drawing.Point(72, 2);
            this.inventoryItemTypeNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryItemTypeNameTextbox.Name = "inventoryItemTypeNameTextbox";
            this.inventoryItemTypeNameTextbox.Size = new System.Drawing.Size(297, 20);
            this.inventoryItemTypeNameTextbox.TabIndex = 2;
            // 
            // inventoryItemType
            // 
            this.inventoryItemType.FormattingEnabled = true;
            this.inventoryItemType.Location = new System.Drawing.Point(73, 27);
            this.inventoryItemType.Name = "inventoryItemType";
            this.inventoryItemType.Size = new System.Drawing.Size(295, 21);
            this.inventoryItemType.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 59);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 23);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // CreateInventoryItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 84);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateInventoryItemType";
            this.Text = "CreateInventoryItemType";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label inventoryItemTypeRent;
        private System.Windows.Forms.Label inventoryItemTypeNameLabel;
        private System.Windows.Forms.TextBox inventoryItemTypeNameTextbox;
        private System.Windows.Forms.ComboBox inventoryItemType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}