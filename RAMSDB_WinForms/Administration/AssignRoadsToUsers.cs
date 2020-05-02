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
using System.ComponentModel.DataAnnotations;
using RAMSDB_WinForms.ViewModel.AssignRoadsToUsersVM;
using RAMSDBModel;
using RAMSDB.Data;

namespace RAMSDB_WinForms.Administration
{
    public partial class AssignRoadsToUsers : DevExpress.XtraEditors.XtraUserControl
    {
        AssignRoadsToUsersVM vm = new AssignRoadsToUsersVM();
        RAMSDBEntities _context = new RAMSDBEntities();

        public AssignRoadsToUsers()
        {
            InitializeComponent();

          gridControl.DataSource = vm.GetRoadsInWoredasWithInfo().ToList();
            userBindingSource.DataSource = _context.User.ToList();
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
        }

        private void windowsUIButtonPanel_Click(object sender, EventArgs e)
        {
            User selecteduser = new User();
            if (gridLookupUserAssign.Text == null) { MessageBox.Show("Please Select a User First"); return; }

            if (gridLookupUserAssign.Text !=null)

            {
                selecteduser = (User)gridLookupUserAssign.GetSelectedDataRow();
             //   int userID = selecteduser.UserID;

                var gridSelectedTuples = GetSelectedValues2(gridView, "RoadID", "AdminID").ToList();



                RoadsPerUserRepository roadPerUserRepo = new RoadsPerUserRepository(_context);



                List<RAMSDBModel.RoadsPerUser> roadPerUserGridSelected = new List<RAMSDBModel.RoadsPerUser>();

                // UsersRepository tc = new UsersRepository(_context);
                // List<Users> u = new List<Users>();
                int t = 0;

                for (int i = 0; i < gridSelectedTuples.Count; i++)
                {
                    RAMSDBModel.RoadsPerUser rpu = new RAMSDBModel.RoadsPerUser();
                    rpu.RoadID = gridSelectedTuples[i].Item1;
                    rpu.AdminID = gridSelectedTuples[i].Item2;
                    rpu.UserID = selecteduser.UserID;



                    //  _context.RoadsPerUsers.Add(rpu);
                    roadPerUserGridSelected.Add(rpu);


                }

                var a = 1;

                _context.RoadsPerUser.AddRange(roadPerUserGridSelected);

                // roadPerUserRepo.AddRange(roadPerUserGridSelected);
                // _context.RoadsPerUsers.AddRange(tg);

                var numRecordsAdded = roadPerUserRepo.Context.SaveChanges();
                // var x = _context.SaveChanges();

                MessageBox.Show(numRecordsAdded.ToString());


            }
        }

        private List<Tuple<int, int>> GetSelectedValues2(DevExpress.XtraGrid.Views.Grid.GridView view, string roadID, string adminID)


        {

            int[] selectedRows = gridView.GetSelectedRows();//.GetSelectedRowHandles();//.SelectedItems.Count;
            List<Tuple<int, int>> x = new List<Tuple<int, int>>();

            // int[] selectedRows = view.GetSelectedRows();
            object[,] result = new object[selectedRows.Length, 2];
            for (int i = 0; i < selectedRows.Length; i++)
            {
                int rowHandle = selectedRows[i];
                if (!gridView.IsGroupRow(rowHandle))

                {
                    object troadID = view.GetRowCellValue(rowHandle, roadID);
                    object tadminID = view.GetRowCellValue(rowHandle, adminID);
                    result[i, 0] = view.GetRowCellValue(rowHandle, roadID);
                    result[i, 1] = view.GetRowCellValue(rowHandle, adminID);
                    // x.Append(tuple[troadID,tAdminID]);
                    x.Add(new Tuple<int, int>((int)troadID, (int)tadminID));
                }
                else
                {
                    result[i, 0] = -1;
                    result[i, 1] = -1;

                }//.Skip();//[i] = -1; // default value  
            }

            //foreach(var x in result)
            //{
            //    if (x == null)
            //    {
            //        var t = "Null";
            //    }
            //}

            //result.

            // var list = new List<(object[,],int)>(result);

            //ArrayList a1 =  new ArrayList();
            //a1 = result;


            //a1 = result;







            //lst.RemoveAll(x=>x==-1)
            //   list.RemoveAll(x => x== null);

            //    result = object[](list);

            //list.RemoveAll(list[0] => list[0] == -1);



            // vehicles.RemoveAll(vehicle => vehicle.EnquiryID == 123);

            return x.ToList();
        }
    }
}
