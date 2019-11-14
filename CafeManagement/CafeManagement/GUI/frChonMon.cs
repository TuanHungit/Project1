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
using CafeManagement.Data;
using CafeManagement.LinQ;

namespace CafeManagement.GUI
{
    public partial class frChonMon : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler Button_Clicked;
       

        public frChonMon()
        {
            InitializeComponent();
        }
        Query_HoaDon hoaDon = new Query_HoaDon();
        Query_SanPham sanPham = new Query_SanPham();
        CaPheContext context = new CaPheContext();
        
        Query_Ban ban = new Query_Ban();

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int BillID = hoaDon.LayHoaDonChuaThanhToan(Global.BanID);
            string TenSanPham = lbTenSenPham.Text;
            int SanPhamID = sanPham.LayIdSanPham(TenSanPham, context);
            int SoLuong = int.Parse(cbSoLuong.Text);
            hoaDon.AddChiTietHoaDon(BillID, SanPhamID, SoLuong);
            Close();
          
        }

        private void frChonMon_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            LoadInfor();
           
         }
        private void LoadInfor()
        {
            lbTenSenPham.Text = Global.TenSanPham;
            lbGia.Text = Global.Gia + " VND";
            int SoLuong = int.Parse(cbSoLuong.Text);
            lbThanhTien.Text = ((int.Parse(Global.Gia)) * SoLuong).ToString() + " VND";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int BillID = hoaDon.LayHoaDonChuaThanhToan(Global.BanID);
            string TenSanPham = lbTenSenPham.Text;
            int SanPhamID = sanPham.LayIdSanPham(TenSanPham, context);
          
            hoaDon.AddChiTietHoaDon(BillID, SanPhamID, -100);
            if (!ban.KiemTraBanConMonKhong(Global.BanID,context))
            {
                hoaDon.XoaHoaDon(BillID);
                ban.Update_Ban1(context, Global.BanID);
            }
            Close();
        }

        private void frChonMon_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}