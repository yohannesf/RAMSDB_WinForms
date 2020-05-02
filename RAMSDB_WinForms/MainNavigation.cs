using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using RAMSDB.Data;
using static RAMSDB.Data.RAMSDBDataLoader;
using DevExpress.XtraSplashScreen;

namespace RAMSDB_WinForms
{
    public partial class MainNavigation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        XtraUserControl rsAssigned = new XtraUserControl();
      
        public MainNavigation()
        {

            

          // MessageBox.Show(LoginInfo.GetLoggedInUser.FullName + "\n" + LoginInfo.GetLoggedInUser.RoadsPerUsers.Count.ToString() + "\n");

            //MessageBox.Show(LoggedInUser.roleName + "\n" + LoggedInUser.userRegion);


            InitializeComponent();
            barUserFullName.Caption = LoginInfo.GetLoggedInUser.FullName.ToString();
            barUserName.Caption = LoginInfo.GetLoggedInUser.UserName.ToString();
            barRole.Caption = LoggedInUser.roleName; 
            barLocation.Caption = LoggedInUser.userRegion;


            //   rsAssigned = new RAMSDB_WinForms.RoadsAssigned();

            //customersUserControl = CreateUserControl("Customers");
            // accordionControl.SelectedElement = .SelectedElement = employeesAccordionControlElement;
            // Handling the QueryControl event that will populate all automatically generated Documents
            //   this.tabbedView.QueryControl += tabbedView_QueryControl;

            
                
            
        }
       
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {


           
              
           
            if (e.Element == null) return;


             SplashScreenManager.ShowForm(typeof(WaitForm1));
                        try
                        {
            XtraUserControl userControl = new XtraUserControl();
            

            string elementName = e.Element.Name;

           
           
               
            

            switch (elementName)
            {


                //case "accItemRoadsAssigned":
                //    userControl = new RAMSDB_WinForms.RoadsAssigned();
                //    userControl.Text = "Roads Assigned";
                //    break;

                case "accItemRoadsAssigned":
                    userControl = new RAMSDB_WinForms.RoadsAssignedWidget();
                   
                    userControl.Text = "Roads Assigned";
                    break;


                case "accItemConditionSurveyFilter":
                    userControl = new UnpavedRoadConditionSurveyFilters();// UnpavedSurveyView;
                    userControl.Text = "Unpaved Roads Condition Survey Data";
                    break;


                case "accItemMaintenanceConditionIndex":
                    userControl = new RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                    userControl.Text = "Maintenance Condition Index";
                    break;

               
                case "accItemMCAnalysis":
                    userControl = new UnpavedRoadsMultiCriteriaAnalysis();
                    userControl.Text = "Unpaved Roads Multicriteria Analysis";
                    break;

                case "accItemMaintenanceCost":
                    userControl = new UnpavedRoadsMaintenanceCostPlan();
                    userControl.Text = "Maintenance Cost per Road";
                    break;

                case "accItemPopServed":
                    userControl = new PopServed();
                    userControl.Text = "Population Served Per Road";
                    break;

                case "accItemPrioritizedRoads":
                    userControl = new UnpavedPrioritizedRoads();
                    userControl.Text = "Unpaved Prioritized Roads";
                    break;



            }
            
            



            //   XtraUserControl userControl = e.Element.Name .Text == "Employees" ? employeesUserControl : customersUserControl;
            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //try
            //{
            //    tabbedView.AddDocument(userControl);
            //    tabbedView.ActivateDocument(userControl);
            //}
            //finally
            //{
            //    //Close Wait Form
            //    SplashScreenManager.CloseForm(false);
            //}


            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
            }
            finally
            {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }

        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {

            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = accordionGroupRoadConditionSurvey.Elements[barItemIndex];//  mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
               // if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
              //  else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            //if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            //else customersUserControl = CreateUserControl("Customers");
        }

        // Assigning a required content for each auto generated Document
        void tabbedView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

         

            //if (e.Document == unpavedRoadConditionSurveyFiltersDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadConditionSurveyFilters();
           
            //if (e.Document == popServedDocument)
            //    e.Control = new RAMSDB_WinForms.PopServed();

            //if (e.Document == unpavedRoadsMaintenanceCostPlanDocument) 
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadsMaintenanceCostPlan();
            
            //if (e.Document == unpavedRoadsMultiCriteriaAnalysisDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadsMultiCriteriaAnalysis();

          
       //     if (e.Document == roadsAssignedDocument)
        //        e.Control = new RAMSDB_WinForms.RoadsAssigned();

            //if (e.Document == MaintenanceConditionIndexDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();


            //if (e.Document == unpavedPrioritizedRoadsDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedPrioritizedRoads();

           

            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void accItemunpavedResults_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }

        private void accItemPopServed_Click(object sender, EventArgs e)
        {

        }

        private void roadsAssigned_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainNavigation_Load(object sender, EventArgs e)
        {
            accordionControl.SelectedElement = accItemRoadsAssigned;
        }

        private void bbiLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();
            
                
           // Login fLogin = new Login();

           // this.Close();

           // Application.Run();
           


           // if (tabbedView.Documents.Count == 0) return;
            
            
           // int c = tabbedView.Documents.Count;

           // for (int i=c-1; i>=0; i--)
           // {
           //     tabbedView.RemoveDocument(tabbedView.Documents[i].Control);
           // }


           // //    foreach (var x in tabbedView.Documents.)
           // //{
           // //    tabbedView.Documents.Remove(x);
           // //}

           ////tabbedView.Documents[]
          //  fLogin.Show();
           

        }

        private void MainNavigation_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void MainNavigation_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}