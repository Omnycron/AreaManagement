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
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string tempArea = areaTextBox.Text;
            string tempRent = rentTextBox.Text;

            if(name == null || tempArea == null || tempRent == null)
            {
                //TODO: Meldung
                return;
            }

            double area = 0;
            double rent = 0;
            try
            {
                area = Convert.ToDouble(tempArea);
                rent = Convert.ToDouble(tempRent);
            } catch
            {
                //TODO: Meldung bitte korrekte Werte für area und rent eingeben
                return;
            }

            Program.building.AddRoom(name, area, rent);
            NavigationForm nf = (NavigationForm)Application.OpenForms["NavigationForm"];
            nf.ReloadAllTables();
            this.Close();
        }
    }
}
