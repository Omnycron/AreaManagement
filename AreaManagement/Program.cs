using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaManagement
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        public static DataManagement dataManagement;
        public static Building building;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Test();
            InitializeAreaManagement();

            Application.Run(new NavigationForm());

            
        }

        //trys to load data from the fixed path (see class DataManagement). 
        //If no existing data is found a new building to store data is created
        static void InitializeAreaManagement()
        {
            Program.dataManagement = new DataManagement();

            try
            {
                building = dataManagement.LoadBuilding();
            }
            catch {
                Program.building = new Building();
            }

        }
    }
}
