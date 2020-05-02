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
    public partial class ucClassification : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucClassification()
        {
            InitializeComponent();

            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                     group roads by roads.RoadsGISData.RoadClassification.RoadClassificationDescription into grp
                                     select new { RoadClassification = grp.Key, NumberofRoads = grp.Count() };


            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Classification", ViewType.Pie);

            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadClassification";
            series1.ValueDataMembers.AddRange(new string[] { "NumberofRoads" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);

            // Format the the series labels. 
            //   series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels.  
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.Inside;
        }
    }
}
