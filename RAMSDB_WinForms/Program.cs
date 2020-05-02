using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAMSDB_WinForms.Administration;
using DevExpress.XtraBars.Ribbon;

namespace RAMSDB_WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login fLogin = new Login();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                // RibbonForm form = new RibbonForm();

                //  RibbonForm form = new RAMSDB_WinForms.RoadsAssignedWidget() as RibbonForm;
                // Application.Run(new WoredaDataPerson());
                //  Application.Run(new FormForTesting());
                 Application.Run(new MainNavigation());
               // Application.Run(new MapTest());
                //  Application.Run(new RAMSDB_WinForms.UnpavedRoads.TrafficSurveyForm());
                //  Application.Run(new UserAdmin());
                // Application.Run(new UnpavedFilters());
                //  Application.Run(new AdministrationNavigation()); 
                //   Application.Run(new MapViewer());
              //  Application.Run(new RAMSDB_WinForms.RoadsAssignedWidget());
            }
            else
            {
                Application.Exit();
            }
        }

        //Application.Run(new Login())
        //    Application.Run(new WoredaDataPerson());
        }
    }


