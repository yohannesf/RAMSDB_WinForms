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
using RAMSDB.Data;
using RAMSDBModel;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars.Ribbon;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ListofRoadsAssigned : DevExpress.XtraEditors.XtraUserControl
    {

        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();


        public ListofRoadsAssigned()
        {
            InitializeComponent();

            //bsiRecordsCount.Caption = "RECORDS : " + dataLoader.roadsPerUserDL.Count;

           roadsPerUserBindingSource.DataSource = dataLoader.roadsPerUserDL;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {


                    int roadIDColumn = (int)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);

                    RibbonForm form = new UnpavedConditionSurveyView(roadIDColumn);
                    // XtraUserControl form = new UnpavedConditionSurveyView(roadIDColumn);
                    form.ShowDialog();

                   // XtraDialog.Show(form);

                    //   Form form = new TestForm();
                    //     form.ShowDialog();

                }
            }
        }
    }
}
