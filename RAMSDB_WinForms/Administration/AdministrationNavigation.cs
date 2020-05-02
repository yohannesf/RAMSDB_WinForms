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

namespace RAMSDB_WinForms.Administration
{
    public partial class AdministrationNavigation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        public AdministrationNavigation()
        {
            InitializeComponent();
           
            this.tabbedView.QueryControl += tabbedView_QueryControl;
        }
       
       
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            //if (e.Element == null) return;
            //XtraUserControl userControl = e.Element.Text == "Employees" ? employeesUserControl : customersUserControl;
            //tabbedView.AddDocument(userControl);
            //tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
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
                if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
                else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
           
        }

        // Assigning a required content for each auto generated Document
        void tabbedView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            
            if (e.Document == assignRoadsToUsersDocument)
                e.Control = new RAMSDB_WinForms.Administration.AssignRoadsToUsers();
           
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}