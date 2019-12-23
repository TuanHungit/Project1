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
using CafeManagement.LinQ;
using DevExpress.XtraSplashScreen;

namespace CafeManagement.GUI
{
    public partial class frLogin : DevExpress.XtraEditors.XtraForm
    {
        public frLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        Query_Login login = new Query_Login();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

           
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
               
                XtraMessageBox.Show("Vui lòng nhập Tài Khoản và Mật Khẩu!");
                SplashScreenManager.CloseForm();
                return;
            }
            string Username = txtUserName.Text;
            string Password = txtPassword.Text;
            if (login.DanhNhap(Username, Password))
            {
                frMain fr = new frMain();
                SplashScreenManager.CloseForm();
                fr.ShowDialog();
            
            }
            else {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Tài khoản hay Mật khẩu không tồn tại!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}