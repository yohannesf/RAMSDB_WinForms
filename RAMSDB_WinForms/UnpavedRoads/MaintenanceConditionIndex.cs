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

namespace RAMSDB_WinForms.UnpavedRoads
{
    public partial class MaintenanceConditionIndex : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public MaintenanceConditionIndex()
        {
            InitializeComponent();

            InitBindings();
           // var urc = dbContext.UnpavedRoadConditionSurvey.ToList();

            
        }

        public void InitBindings()
        {
            var urc = dataLoader.unpavedRoadConditionSurveysDL.ToList();

            var firstPhase = from u in urc
                             select new
                             {
                                 u.RCSID,
                                 u.RCSYear,
                                 u.RoadID,
                                 u.RoadsPerUser.AdminBoundary.ZoneName,
                                 u.RoadsPerUser.AdminBoundary.WoredaName,
                                 u.RoadsGISData.RoadOriginDestination,
                                 u.SectionLengthKM,
                                 SurfaceConditionFactor = u.SurfaceCondition,


                                 ShoulderConditionFactor = (u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

                                                         (double)((u.ShoulderConditionRight.GetValueOrDefault() + u.ShoulderConditionLeft.GetValueOrDefault()) /
                                                             (
                                                               (double)((u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0))
                                                             )),



                                 DrainageConditionFactor = (u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

                                                                   (double)((u.DrainageConditionRight.GetValueOrDefault() + u.DrainageConditionLeft.GetValueOrDefault()) /
                                                                       (
                                                                         (double)((u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0))
                                                                       ))


                             }
                    ;


            var secondPhase = (from u in firstPhase
                               select new
                               {
                                   u.RCSID,
                                   u.RCSYear,
                                   u.RoadID,
                                   u.ZoneName,
                                   u.WoredaName,
                                   u.RoadOriginDestination,
                                   u.SectionLengthKM,
                                   u.SurfaceConditionFactor,
                                   u.ShoulderConditionFactor,
                                   u.DrainageConditionFactor,
                                   MaintenanceConditionIndex = u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4,

                                   RoutineMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false,
                                   PeriodicMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) > 1.5 ?
                                                         (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false : false,
                                   Rehabilitation = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) >= 2.5 ? true : false
                               });



            var trafficCountScore = dbContext.Database.ExecuteSqlCommand("Delete from TentativeRoadMaintenancePlan");// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();





            List<RAMSDBModel.TentativeRoadMaintenancePlan> tplan = dbContext.TentativeRoadMaintenancePlan.ToList();



            foreach (var roadSegment in secondPhase)
            {




                if (roadSegment.Rehabilitation)
                {
                    RAMSDBModel.TentativeRoadMaintenancePlan tp = new RAMSDBModel.TentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.RCSYear;
                    tp.CatWorkID = 5;
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();


                    tplan.Add(tp);





                }

                if (roadSegment.RoutineMaintenance)
                {
                    RAMSDBModel.TentativeRoadMaintenancePlan tp = new RAMSDBModel.TentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;
                    tp.Year = roadSegment.RCSYear;
                    tp.CatWorkID = 1;
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

                    tplan.Add(tp);





                }

                if (roadSegment.PeriodicMaintenance)
                {
                    RAMSDBModel.TentativeRoadMaintenancePlan tp = new RAMSDBModel.TentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;
                    tp.Year = roadSegment.RCSYear;
                    tp.CatWorkID = 2;
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

                    tplan.Add(tp);




                }
            }



            dbContext.TentativeRoadMaintenancePlan.AddRange(tplan);
            dbContext.SaveChanges();


            gridControl.DataSource = secondPhase.ToList(); ;
            bsiRecordsCount.Caption = "RECORDS : " + secondPhase.ToList().Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
             gridControl.ShowRibbonPrintPreview();

           
        }

        private void bbiViewCost_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {



                GridView view = gridView as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["RCSYear"]));
                    int roadIDColumn = (int)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                //    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn);
                    ribbonForm.ShowDialog();

                   


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitBindings();
        }
    }
}
