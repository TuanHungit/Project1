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
    public partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        public frManage()
        {
            InitializeComponent();
        }

        private void frManage_Load(object sender, EventArgs e)
        {
       
    
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}