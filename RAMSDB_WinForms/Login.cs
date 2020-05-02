using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RAMSDB_WinForms.ViewModels.LoginViewModel;

namespace RAMSDB_WinForms
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        LoginViewModel vm = new LoginViewModel();

        public Login()
        {
            InitializeComponent();
          
            loginViewModelBindingSource.DataSource = vm;





            //--------------UNCOMMENT THE BELOW LINE FOR LOGIN
            vm.HasLoggedIn += Vm_HasLoggedIn;

        }

        private void Vm_HasLoggedIn(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       

        private void Login_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //this.Close();

            //if (tUserNameTextEdit == null || PasswordTextEdit == null) return;
            ////{
            ////    MessageBox.Show("Please enter user name and password");
            ////    return;
            ////}


            //REAL CODE IS HERE --- FOR TESTING, USE THE ABOVE CODE
            var loginStatus = vm.Login();


            if (!loginStatus)
            {


                tUserNameTextEdit.EditValue = "";
                PasswordTextEdit.EditValue = "";
            }
        }
    }
}