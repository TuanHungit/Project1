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
    public partial class frChuyenBan : DevExpress.XtraEditors.XtraForm
    {
        public frChuyenBan()
        {
            InitializeComponent();
        }
        CaPheContext context = new CaPheContext();
        Query_HoaDon query_hoaDon = new Query_HoaDon();
        Query_Ban query_Ban = new Query_Ban();
        Query_SanPham query_SanPham = new Query_SanPham();
        Ban ban = new Ban();
        bool flag = false;
        private void frChuyenBan_Load(object sender, EventArgs e)
        {
            txtHoadon1.Enabled = false;
            txtHoaDon2.Enabled = false;
            Load_cbBan();
        }
        private void Load_cbBan()
        {
            //Bàn 1
            cbBan1.Properties.DataSource = (from item in context.Bans
                                            select new { SốBàn = item.BanId, TìnhTrạng = item.TinhTrang }).ToList();
            cbBan1.Properties.DisplayMember = "SốBàn";
            cbBan1.Properties.ValueMember = "SốBàn";
            //Bàn 2
            cbBan2.Properties.DataSource = (from item in context.Bans
                                            select new { SốBàn = item.BanId, TìnhTrạng = item.TinhTrang }).ToList();
            cbBan2.Properties.DisplayMember = "SốBàn";
            cbBan2.Properties.ValueMember = "SốBàn";


        }
        void ShowBill(int BanID, bool flag)
        {
         
            double ThanhTien = 0;
            int HoaDonID = query_hoaDon.LayHoaDonChuaThanhToan(BanID);
            var quer = (from sanpham in context.SanPhams
                        join chitiethoadon in context.ChiTietHoaDons on sanpham.SanPhamId equals chitiethoadon.SanPhamID
                        join hoadon in context.HoaDons on chitiethoadon.HoaDonID equals hoadon.HoaDonId
                        orderby hoadon.HoaDonId
                        where hoadon.TinhTrang.Equals(0) && hoadon.HoaDonId.Equals(HoaDonID)
                        select new { sanpham.TenSanPham, chitiethoadon.SoLuong, sanpham.DonGia, TongGia = chitiethoadon.SoLuong * sanpham.DonGia }
                        ).ToList();
            if (flag == false)
            {
                gcBill1.DataSource = quer;
                gvBill1.Columns[0].Caption = "Tên món";
                gvBill1.Columns[1].Caption = "Số lượng";
                gvBill1.Columns[2].Caption = "Đơn giá";
                gvBill1.Columns[3].Caption = "Tổng giá";
            }
            else
            {
                gcBill2.DataSource = quer;
                gvBill2.Columns[0].Caption = "Tên món";
                gvBill2.Columns[1].Caption = "Số lượng";
                gvBill2.Columns[2].Caption = "Đơn giá";
                gvBill2.Columns[3].Caption = "Tổng giá";

            }
        }

        private void cbBan1_EditValueChanged(object sender, EventArgs e)
        {
            flag = false;
            int BanID = (int)cbBan1.EditValue;
            txtHoadon1.Text = "#" + query_hoaDon.LayHoaDonIDByBanID(BanID).ToString();
            ShowBill(BanID, flag);
        }

        private void cbBan2_EditValueChanged(object sender, EventArgs e)
        {
            flag = true;
            int BanID = (int)cbBan2.EditValue;
            txtHoaDon2.Text = "#"+query_hoaDon.LayHoaDonIDByBanID(BanID).ToString();
            ShowBill(BanID, flag);
        }

        private void btnChuyenAllMon2_Click(object sender, EventArgs e)
        {
            if (cbBan1.EditValue == null || cbBan2.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn cần gộp hay chuyển!");
                return;
            }
            int BanID1 = (int)cbBan1.EditValue;
            int BanID2 = (int)cbBan2.EditValue;
            if (!query_Ban.KiemTraBanConMonKhong(BanID1, context) && !query_Ban.KiemTraBanConMonKhong(BanID2, context))
            {
                XtraMessageBox.Show("Bàn bạn chọn không có món để chuyển!");
                return;
            }
            if (!query_Ban.KiemTraBanConMonKhong(BanID2, context))
            {
                XtraMessageBox.Show("Bàn bạn chọn không có món để chuyển!");
                return;
            }
          
           
            if (BanID1 == BanID2)
            {
                XtraMessageBox.Show("Bàn bàn chọn đã trùng! Xin chọn bàn khac!");
                return;
            }
            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn gộp {1} sang {0}?",
                BanID1, BanID2), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                query_Ban.GopBan(BanID1,BanID2,context);
         
            }
            ShowBill(BanID1,flag=false);
            ShowBill(BanID2, flag = true);
        }

        private void btnChuyenAllMon1_Click(object sender, EventArgs e)
        {
            if (cbBan1.EditValue == null || cbBan2.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn cần gộp hay chuyển!");
                return;
            }
            int BanID1 = (int)cbBan1.EditValue;
            int BanID2 = (int)cbBan2.EditValue;
     
            if (!query_Ban.KiemTraBanConMonKhong(BanID1, context)&&!query_Ban.KiemTraBanConMonKhong(BanID2,context))
            {
                XtraMessageBox.Show("Bàn bạn chọn không có món để chuyển!");
                return;
            }
            if (!query_Ban.KiemTraBanConMonKhong(BanID1, context))
            {
                XtraMessageBox.Show("Bàn bạn chọn không có món để chuyển!");
                return;
            }
          
         
            if (BanID1 == BanID2)
            {
                XtraMessageBox.Show("Bàn bàn chọn đã trùng! Xin chọn bàn khac!");
                return;
            }
            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn gộp {1} sang {0}?",
                BanID2, BanID1), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                query_Ban.GopBan(BanID2, BanID1,context);
            
            }
            ShowBill(BanID1, flag = false);
            ShowBill(BanID2, flag = true);
        }

      
        int SanPhamID;
        private void gcBill1_Click(object sender, EventArgs e)
        {
            string TenSanPham = gvBill1.GetRowCellValue(gvBill1.FocusedRowHandle, gvBill1.Columns[1]).ToString();
            SanPhamID = query_SanPham.LayIdSanPham(TenSanPham,context);
        }

     
    }
}