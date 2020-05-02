using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using RAMSDBModel;
using System.Data.Entity;

using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using RAMSDB.Data;
using DevExpress.XtraSplashScreen;

namespace RAMSDB_WinForms
{
    public partial class UnpavedRoadConditionSurveyFilters : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        RAMSDBModel.RAMSDBEntities dbContext2 = new RAMSDBModel.RAMSDBEntities();
        List<int> tentative = new List<int>();
        List<UnpavedRoadConditionSurvey> uRCS = new List<UnpavedRoadConditionSurvey>();


        public UnpavedRoadConditionSurveyFilters()
        {
            InitializeComponent();

           
                InitBindings();
           

           
        }

        private void InitBindings()
        {

            IQueryable<RoadsPerUser> roadsPerUsers = dbContext.RoadsPerUser.AsQueryable();



            tentative = dataLoader.tentativeRoadMaintenancePlanDL.Select(r => r.RoadID).ToList();
            unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.ToList(); // dbContext.UnpavedRoadConditionSurvey.Local.ToBindingList();




            bsiRecordsCount.Caption = "RECORDS : " + dataLoader.unpavedRoadConditionSurveysDL.ToList().ToString();
        }



        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();// gridControl.ShowRibbonPrintPreview();
        }

        private void GridView_RowDoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {


                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(info.RowHandle, view.Columns["RCSYear"]));
                    int roadIDColumn = (int)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(info.RowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    gridView1.RefreshData();

                    //  unpavedRoadConditionSurveyBindingSource.DataSource

                    // unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.ToList()


                }

            }
        }


        private void GridView_UnboundColumns(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;


            int rowIndex = e.ListSourceRowIndex;



            if (e.Column.FieldName != "colPlanSet") return;
            if (e.IsGetData)
            {
                tentative = dataLoader.tentativeRoadMaintenancePlanDL.Select(r => r.RoadID).ToList();
                e.Value = tentative.Contains((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            //   gridView1.RefreshData();
            InitBindings();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["RCSYear"]));
                    int roadIDColumn = (int)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    InitBindings();


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["RCSYear"]));
                    int roadIDColumn = (int)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    InitBindings();


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }
            }
        }
    }
}
