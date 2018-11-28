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

        //static void Test()
        //{
        //InventoryItemType itt = new InventoryItemType("a", 1, 50);
        //InventoryItem it = new InventoryItem("asf", itt, 1, "ok");
        //Program.building = new Building();
        //Program.building.AddRoom("room 1", 50, 500);
        //    building.AddTenant("tenant1");
        //    foreach(Room room in building.GetRooms())
        //    {
        //        room.AddInventoryItem("inventoryItem", itt);
        //    }
        //    foreach (Tenant tenant in building.GetTenants())
        //    {
        //        tenant.RentRoom(building.GetRooms()[0]);
        //    }
        //    dataManagement.SaveBuilding();
        //    Building loadedIT = dataManagement.LoadBuilding();
        //    loadedIT.ToString();

        //}
    }
}
