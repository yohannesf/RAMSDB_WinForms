﻿using System;
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
using System.Data.Entity;
using DevExpress.XtraCharts;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucSurfaceType : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucSurfaceType()
        {
            InitializeComponent();

           // var x = dataLoader.roadsPerUserDL;

            var roadsBySurfaceType = from c in dataLoader.roadsPerUserDL
                    group c by c.RoadsGISData.RoadSurfaceType.SurfaceTypeName into grp
                    select new { SurfaceType = grp.Key, NumberofRoads = grp.Count() };


          //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Surface Type", ViewType.Pie);

            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "SurfaceType";
            series1.ValueDataMembers.AddRange(new string[] { "NumberofRoads" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);

            // Format the the series labels. 
            //   series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels.  
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.Inside;

            //foreach(var g in t)
            //{
            //    var c = g.Key;
            //    var dh = g.cnt;
            //}



            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

          //  roadsPerUserBindingSource.DataSource = t;// dataLoader.roadsPerUserDL;// dbContext.RoadsPerUser.Local.ToBindingList();
          
        }
    }
}