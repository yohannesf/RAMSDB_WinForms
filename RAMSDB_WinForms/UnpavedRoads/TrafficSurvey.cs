using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using RAMSDBModel;
using RAMSDB.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace RAMSDB_WinForms.UnpavedRoads
{

    public partial class TrafficSurveyForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        RAMSDBEntities _context = new RAMSDBEntities();

        public int _roadID;
        public int _year = 2020;
        public int _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<TrafficSurvey> trafficSurveys = new List<TrafficSurvey>();

        List<RoadsPerUser> rpu = new List<RoadsPerUser>();


        public TrafficSurveyForm()
        {
            InitializeComponent();
        }

        public TrafficSurveyForm( int roadID)
        {
            InitializeComponent();

            _roadID = roadID;

            vehicleTypeBindingSource.DataSource = _context.VehicleType.ToList();
            trafficCountHourBindingSource.DataSource = _context.TrafficCountHour.ToList();

            trafficSurveys = dataLoader.trafficSurveysDL.Where(c => c.RoadID == roadID).ToList();

            trafficSurveyBindingSource.DataSource = trafficSurveys.ToList();


            rpu = dataLoader.roadsPerUserDL.ToList();



            lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.ZoneName).FirstOrDefault();// multiCriteriaData.Select(c => c.ro.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            lblWoreda.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            lblRoadOriginDestination.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            lblLength.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblRoadClassification.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            lblRoadDensity.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();


            bsiRecordsCount.Caption = "RECORDS : " + _context.TrafficSurvey.ToList().Count;

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            


            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["VehicleTypeID"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Vehicle Type is Required";
            }

            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["TCHourID"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Survey Hour is Required";
            }

            if ((decimal)view.GetRowCellValue(e.RowHandle, view.Columns["TrafficCount"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Traffic Count cannot be Zero";
            }


            //VehicleTypeID
            //TCHourID

            //TrafficCount

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.TrafficSurvey dw = (RAMSDBModel.TrafficSurvey)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "TrafficSurvey");

                    //_context.MultiCriteriaAnalysisData.Add(dw);

                    //_context.SaveChanges();
                }
                else
                {
                    dataLoader.SaveData();
                }
            }
        }

        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dataLoader.SaveData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {



                GridView view = gridView as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RAMSDBModel.TrafficSurvey dw = (RAMSDBModel.TrafficSurvey)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "TrafficSurvey");
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

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            dataLoader.SaveData();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            trafficSurveyBindingSource.DataSource = dataLoader.trafficSurveysDL.Where(c => c.RoadID == _roadID).ToList(); 
            gridControl.RefreshDataSource();
        }

        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["TrafficSurveyYear"], Convert.ToInt16(_year));

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}