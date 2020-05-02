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
using RAMSDB.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;


namespace RAMSDB_WinForms
{
    public partial class UnpavedConditionSurveyView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<UnpavedRoadConditionSurvey> unpavedSurvey = new List<UnpavedRoadConditionSurvey>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public int _roadID;
        public int _year = 2020;
        public int _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public int _SurfaceType;




        public UnpavedConditionSurveyView()
        {
            InitializeComponent();


            unpavedRoadConditionSurveyBindingSource.DataSource = _context.UnpavedRoadConditionSurvey.ToList();



            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + _context.UnpavedRoadConditionSurvey.ToList().Count;
        }

        public UnpavedConditionSurveyView(int roadID)
        {
            InitializeComponent();

           
            

            roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.ToList();

            _roadID = roadID;

            conditionBindingSource.DataSource = _context.Condition.ToList();


            unpavedSurvey = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RoadID == roadID).ToList();

            lblZone.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            lblWoreda.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            lblRoadOriginDestination.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            lblLength.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblRoadClassification.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            lblRoadDensity.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = unpavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();

            _SurfaceType = unpavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeID).FirstOrDefault();

            unpavedRoadConditionSurveyBindingSource.DataSource = unpavedSurvey; //   _context.UnpavedRoadConditionSurvey.ToList();

            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + unpavedSurvey.Count;
           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], Convert.ToInt16(_year));
            view.SetRowCellValue(e.RowHandle, view.Columns["UserID"], _userID);
            view.SetRowCellValue(e.RowHandle, view.Columns["SurfaceType"], _SurfaceType);
        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;



            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["SurfaceType"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Surface Type is Required";
            }

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.UnpavedRoadConditionSurvey dw = (RAMSDBModel.UnpavedRoadConditionSurvey)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "UnpavedRoadConditionSurvey");


                    //_context.UnpavedRoadConditionSurvey.Add(dw);
                    //_context.SaveChanges();
                }
                else
                {
                    dataLoader.SaveData();
                }
            }

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _context.SaveChanges();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // gridView1.RefreshData();

          

            unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RoadID == _roadID).ToList();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //_context.SaveChanges();
            dataLoader.SaveData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RAMSDBModel.UnpavedRoadConditionSurvey dw = (RAMSDBModel.UnpavedRoadConditionSurvey)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "UnpavedRoadConditionSurvey");
                        dataLoader.SaveData();
                        //   _context.MultiCriteriaAnalysisData.Attach(dw);
                        //   _context.MultiCriteriaAnalysisData.Remove(dw);
                        //   _context.SaveChanges();
                        view.DeleteRow(rowHandle);

                    }
                    else
                        return;



                }
                else
                {
                    MessageBox.Show("Please first select a row from the table below.");
                }

            }
        }
    }
}
