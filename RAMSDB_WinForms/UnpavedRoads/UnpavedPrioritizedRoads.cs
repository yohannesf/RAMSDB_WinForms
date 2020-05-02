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
using RAMSDB.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using RAMSDBModel;

namespace RAMSDB_WinForms
{
    public partial class UnpavedPrioritizedRoads : DevExpress.XtraEditors.XtraUserControl
    {
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();
        List<int> tentativeRoadIDs = new List<int>();
        RAMSDBEntities _context = new RAMSDBEntities();

        List<RAMSDBModel.PrioritizedRoads> tentativePrioritizedRoads = new List<RAMSDBModel.PrioritizedRoads>();

        public UnpavedPrioritizedRoads()
        {
            InitializeComponent();

           // RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();


            tentativeRoadIDs = _context.PrioritizedRoads.Select(t => t.RoadID).ToList();

           

            tentativePrioritizedRoads = _context.PrioritizedRoads.ToList();

         

            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization();
        
            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization().ToList().Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void GridView_UnboundColumns(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
           

           
            GridView view = sender as GridView;
           
            if (view == null) return;


            int rowIndex = e.ListSourceRowIndex;



            if (e.Column.FieldName != "PTentative") return;

            if (e.IsSetData && e.Value != null)
            {
               if ((bool)e.Value)
                {
                    RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();

                    roadsSelected.AdminID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colAdminID);
                    roadsSelected.Year = Convert.ToInt16((int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear));
                    roadsSelected.RoadID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
                    roadsSelected.PTentative = Convert.ToBoolean(e.Value);// (bool)view.GetRowCellValue(rowIndex, colPTentative);



                    _context.PrioritizedRoads.Add(roadsSelected);

                    _context.SaveChanges();
                }
                else
                {
                    int rID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
                    RAMSDBModel.PrioritizedRoads roadsSelected = (from q in _context.PrioritizedRoads where 
                                                                  q.RoadID == rID select q).FirstOrDefault();
                        
                        
                    _context.PrioritizedRoads.Remove(roadsSelected);
                    _context.SaveChanges();
                   
                }

            }


            if (e.IsGetData)
            {
                tentativeRoadIDs = _context.PrioritizedRoads.Select(t => t.RoadID).ToList();
                e.Value = tentativeRoadIDs.Contains((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
            }


            
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization();

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization().ToList().Count;

            gridView1.RefreshData();
        }
    }
}
