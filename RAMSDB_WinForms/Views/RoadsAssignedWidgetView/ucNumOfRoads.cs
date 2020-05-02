using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RAMSDBModel;
using RAMSDB.Data;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucNumOfRoads : DevExpress.XtraEditors.XtraUserControl
    {

        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucNumOfRoads()
        {
            InitializeComponent();

            lblNumOfRoads.Text = dataLoader.roadsPerUserDL.Count.ToString();
        }
    }
}
