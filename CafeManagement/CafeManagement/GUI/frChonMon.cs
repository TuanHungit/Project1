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
        public LoadBill loadBill;
        public LoadTable loadTable;
        public frChonMon()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public frChonMon(LoadBill loadBill,LoadTable loadTable)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.loadBill = loadBill;
            this.loadTable = loadTable;
        }
        Query_HoaDon hoaDon = new Query_HoaDon();
        Query_SanPham sanPham = new Query_SanPham();
       
        
        Query_Ban ban = new Query_Ban();

     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int BillID = hoaDon.LayHoaDonChuaThanhToan(Global.BanID);
            string TenSanPham = lbTenSenPham.Text;
            int SanPhamID = sanPham.LayIdSanPham(TenSanPham);
            int SoLuong = int.Parse(cbSoLuong.Text);
            hoaDon.AddChiTietHoaDon(BillID, SanPhamID, SoLuong);
            this.loadBill(Global.BanID);
            Close();
          
        }

        private void frChonMon_Load(object sender, EventArgs e)
        {
           
            LoadInfor();
           
         }
        private void LoadInfor()
        {
            lbTenSenPham.Text = Global.TenSanPham;
            lbGia.Text = Global.Gia + " VND";
            int SoLuong = int.Parse(cbSoLuong.Text);
            lbThanhTien.Text = (Global.Gia * SoLuong).ToString() + " VND";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int BillID = hoaDon.LayHoaDonChuaThanhToan(Global.BanID);
            string TenSanPham = lbTenSenPham.Text;
            int SanPhamID = sanPham.LayIdSanPham(TenSanPham);
          
            hoaDon.AddChiTietHoaDon(BillID, SanPhamID, -100);
            if (!ban.KiemTraBanConMonKhong(Global.BanID))
            {
                ban.Update_Ban1(Global.BanID);
                hoaDon.XoaHoaDon(BillID);
            }
            this.loadBill(Global.BanID);
            this.loadTable();
            Close();
        }  
        private void cbSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            int SoLuong = int.Parse(cbSoLuong.Text);
            lbThanhTien.Text = (Global.Gia * SoLuong).ToString() + " VND";
        }
    }
}