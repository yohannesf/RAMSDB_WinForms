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
using DevExpress.XtraCharts;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucRoadLength : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucRoadLength()
        {
            InitializeComponent();

            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                    
                                     select new { RoadName = roads.RoadsGISData.RoadOriginDestination, RoadLength = roads.RoadsGISData.RoadLengthInKm.GetValueOrDefault() };

           
           

            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Length", ViewType.Bar);

           
            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadName";
            series1.ValueDataMembers.AddRange(new string[] { "RoadLength" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);
           // ((XYDiagram)chartControl1.Diagram).Rotated = true;

        }
    }
}
