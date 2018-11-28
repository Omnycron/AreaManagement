﻿using System;
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
    public partial class CreateTenant : Form
    {
        public CreateTenant()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
         
            if (name == null)
            {
                //TODO: Meldung
                return;
            }

            Program.building.AddTenant(name);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}