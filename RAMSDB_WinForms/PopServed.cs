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

namespace RAMSDB_WinForms
{
    public partial class PopServed : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();


        public PopServed()
        {
            InitializeComponent();

            gridControl.DataSource = prioritizationClass.PopServed().ToList();// popServed.ToList();
            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.PopServed().ToList().Count;
            // InitBinding();
            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridView.RefreshData();
        }

        //public void InitBinding()
        //{
        //    var populationByWoreda = (from p in _context.AdminBoundary where p.RegionName == "SNNP" select new { _adminID = p.AdminID, _woredaName = p.WoredaName, _population = p.Population }).ToList();

        //    //var totalLengthofRoadsInWoreda =

        //    var totalLengthofRoadsByWoreda = (from road in _context.RoadsPerUser
        //                                      join roadInfo in _context.RoadsGISData on road.RoadID equals roadInfo.RoadID
        //                                      join adminInfo in _context.AdminBoundary on road.AdminID equals adminInfo.AdminID
        //                                      group road by new { adminInfo.AdminID, adminInfo.WoredaName }
        //                                     into result
        //                                      select new
        //                                      {
        //                                          _adminID = result.Key.AdminID,
        //                                          _wordaName = result.Key.WoredaName,
        //                                          _woredaRoadLength = result.Sum(c => c.RoadsGISData.RoadLengthInKm)
        //                                      }).ToList();

        //    var roadsPerUser = _context.RoadsPerUser.Include("RoadsGISData").ToList();


        //    var popServed = from r in roadsPerUser
        //                     join p in populationByWoreda on r.AdminID equals p._adminID
        //                     join t in totalLengthofRoadsByWoreda on r.AdminID equals t._adminID
        //                     orderby r.AdminBoundary.ZoneName, r.AdminBoundary.WoredaName, r.RoadsGISData.RoadOriginDestination
        //                     select new
        //                     {
        //                         r.RoadID,
        //                         Zone = r.AdminBoundary.ZoneName,
        //                         Woreda = r.AdminBoundary.WoredaName,
        //                         OriginDestination = r.RoadsGISData.RoadOriginDestination,
        //                         RoadLength = r.RoadsGISData.RoadLengthInKm.GetValueOrDefault(),


        //                         RoadLengthWoredaTotal = t._woredaRoadLength.GetValueOrDefault(),
        //                         WoredaPopulation = p._population.GetValueOrDefault(),
        //                         PopulationServed = p._population.GetValueOrDefault() * ((r.RoadsGISData.RoadLengthInKm.GetValueOrDefault()) / t._woredaRoadLength.GetValueOrDefault())
        //                     };

        //    //gridControl.DataSource = popServed.ToList();
        //    //bsiRecordsCount.Caption = "RECORDS : " + popServed.ToList().Count;
        //}

    }
}
