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

namespace CafeManagement.GUI
{
    public partial class frMain : DevExpress.XtraEditors.XtraForm
    {
        public frMain()
        {
            InitializeComponent();
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
    }
}