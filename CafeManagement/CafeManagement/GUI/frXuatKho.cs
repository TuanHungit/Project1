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
    public partial class frXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public frXuatKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }

        private void frXuatKho_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}