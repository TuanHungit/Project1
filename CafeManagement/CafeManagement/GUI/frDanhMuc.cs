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
    public partial class frDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public frDanhMuc()
        {
            InitializeComponent();
        }

        private void frDanhMuc_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}