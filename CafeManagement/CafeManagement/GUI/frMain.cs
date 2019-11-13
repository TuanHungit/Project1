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
using DevExpress.UserSkins;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
using CafeManagement.Data;
using CafeManagement.LinQ;
using System.Windows;

namespace CafeManagement.GUI
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        public frMain()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Load_UI();
        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }

        private void btnShowForm_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
          
            Form frm = this.CheckFormExist(typeof(frManage));
            if (frm != null)
            {
             
                frm.Activate();
            }
            else
            {
                
                frManage f = new frManage();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form frm = this.CheckFormExist(typeof(frBan));
            if (frm != null)
            {
              
                frm.Activate();
            }
            else
            {
           
                frBan f = new frBan();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewCategoryFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form form = this.CheckFormExist(typeof(frDanhMuc));
            if (form != null)
            {
               
                form.Activate();
            }
            else
            {
               
                frDanhMuc fr = new frDanhMuc();
                fr.MdiParent = this;
                fr.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form form = this.CheckFormExist(typeof(frMenu));
            if (form != null)
            {
               
                form.Activate();
            }
            else
            {
              
                frMenu fr = new frMenu();
                fr.MdiParent = this;
                fr.Show();
            }
            SplashScreenManager.CloseForm();
        }
        DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        private void Load_UI()
        {
            BonusSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            defaultLookAndFeel.LookAndFeel.SetSkinStyle("Glass Oceans");
        }

        private void btnViewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form form = this.CheckFormExist(typeof(frNhanvien));
            if (form != null)
            {
              
                form.Activate();
            }
            else
            {
               
                frNhanvien fr = new frNhanvien();
                fr.MdiParent = this;
                fr.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnViewBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form form = this.CheckFormExist(typeof(frDanhThu));
            if (form != null)
            {
             
                form.Activate();
            }
            else
            {
              
                frDanhThu fr = new frDanhThu();
                fr.MdiParent = this;
                fr.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void frMain_Load(object sender, EventArgs e)
        {


            if (Global.LoaiTaiKhoan == "NhanVien")
            {

                ribbonPageManager.Visible = false;
            }
            if (Global.LoaiTaiKhoan == "Quản lý")
            {
                ribbonPageManager.Visible = true;
            }
        }

        private void btnAccountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frThongTinTaiKhoan frThongTinTaiKhoan = new frThongTinTaiKhoan();
            frThongTinTaiKhoan.ShowDialog();
        }
    }
}