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

namespace CafeManagement.GUI
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        public frMain()
        {
            InitializeComponent();
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
        }

        private void btnViewTable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckFormExist(typeof(frBan));
            if (form != null)
            {
                form.Activate();
            }
            else {
                frBan fr = new frBan();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnViewCategoryFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
        }

        private void btnViewFood_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            Form form = this.CheckFormExist(typeof(frNhanVien));
            if (form != null)
            {
                form.Activate();
            }
            else
            {
               frNhanVien fr = new frNhanVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}