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
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;

namespace RAMSDB_WinForms.UnpavedRoads
{
    public partial class UnpavedMultiCriteriaData : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();

        public int _roadID;
        public int _year = 2020;
        public int _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<MultiCriteriaAnalysisData> multiCriteriaData = new List<MultiCriteriaAnalysisData>();

        List<RoadsPerUser> rpu = new List<RoadsPerUser>();


        public UnpavedMultiCriteriaData()
        {
            InitializeComponent();
        }

            public UnpavedMultiCriteriaData(int roadID)
        {
            InitializeComponent();


            _roadID = roadID;


           multiCriteriaData = dataLoader.multiCriteriaDataDL.Where(c => c.RoadID == roadID).ToList();

            rpu = dataLoader.roadsPerUserDL.ToList();

          

            lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.ZoneName).FirstOrDefault();// multiCriteriaData.Select(c => c.ro.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            lblWoreda.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            lblRoadOriginDestination.Text = multiCriteriaData.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            lblLength.Text = multiCriteriaData.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblRoadClassification.Text = multiCriteriaData.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            lblRoadDensity.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = multiCriteriaData.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();

       

         //   multiCriteriaAnalysisDataBindingSource.DataSource = _context.MultiCriteriaAnalysisData.Where(c => c.RoadID == roadID).ToList();

            multiCriteriaAnalysisDataBindingSource.DataSource = multiCriteriaData;

            cooperativeCentersAlongRoadBindingSource.DataSource = _context.CooperativeCentersAlongRoad.ToList();
            tradingCentersAlongRoadBindingSource.DataSource = _context.TradingCentersAlongRoad.ToList();
            kebelesVillagesCommunitiesConnectedBindingSource.DataSource = _context.KebelesVillagesCommunitiesConnected.ToList();
            roadTraversesFarmlandBindingSource.DataSource = _context.RoadTraversesFarmland.ToList();
            marketsConnectByRoadBindingSource.DataSource = _context.MarketsConnectByRoad.ToList();
            healthCentersAlongRoadBindingSource.DataSource = _context.HealthCentersAlongRoad.ToList();
            educationCentersAlongRoadBindingSource.DataSource = _context.EducationCentersAlongRoad.ToList();
            otherProjectsAlongRoadBindingSource.DataSource = _context.OtherProjectsAlongRoad.ToList();

           
            //gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + multiCriteriaData.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.MultiCriteriaAnalysisData dw = (RAMSDBModel.MultiCriteriaAnalysisData)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "MultiCriteriaAnalysisData");

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
          
        //    _context.SaveChanges();
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

                    DialogResult dialogResult =  MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RAMSDBModel.MultiCriteriaAnalysisData dw = (RAMSDBModel.MultiCriteriaAnalysisData)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "MultiCriteriaAnalysisData");
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
         //   GridView view = gridView as GridView;

         //   view.UpdateCurrentRow();

         //   view.ValidateRow +=  gridView_ValidateRow;

         ////   view.SourceView.c

           
               dataLoader.SaveData();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            multiCriteriaAnalysisDataBindingSource.DataSource = dataLoader.multiCriteriaDataDL.Where(c => c.RoadID == _roadID).ToList();// multiCriteriaData;// _context.MultiCriteriaAnalysisData.ToList(); 
            gridControl.RefreshDataSource();
        }

        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["Year"], Convert.ToInt16(_year));
            
        }
    }
}
