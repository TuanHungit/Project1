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
    public partial class frKho : DevExpress.XtraEditors.XtraForm
    {
        public frKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }

      
        private void frKho_Load(object sender, EventArgs e)
        {
            txtTenSanPham.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtNCC.Enabled = false;
            txtDonGia.Enabled = false;
            txtDonViTinh.Enabled = false;
            //load_btn();
        }
        private void load_btn()
        {
            btnThoat.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}