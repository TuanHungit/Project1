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
using System.Data.Linq;
using DevExpress.SpreadsheetSource.Implementation;
using CafeManagement.LinQ;
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace CafeManagement.GUI
{
    public partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        public frManage()
        {
            InitializeComponent();
        }
        CaPheContext caPheContext = new CaPheContext();
        int BanID = 0;
        private void frManage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_Table();
            Load_cbDanhMuc();
          
        }
        Ban ban = new Ban();
        Query_DanhMuc danhMuc = new Query_DanhMuc();
        private SimpleButton currentClickButton = new SimpleButton();
        Query_HoaDon hoaDon = new Query_HoaDon();
        private void Load_Table() 
        {
            panelListTable.Controls.Clear();
            List<Ban> danhsachban = ban.GetAllTable();
            foreach (Ban item in danhsachban)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.BanId.ToString() + " "+item.TinhTrang.ToString();
                button.ImageOptions.Image = System.Drawing.Bitmap.FromFile(@"D:\GitHub\Project1\CafeManagement\CafeManagement\Resources\Household-Table-icon.png");
                button.ImageOptions.Location = ImageLocation.TopCenter;
                button.Tag = item;

                button.Click += button_Click;

                switch (item.TinhTrang.ToString())
                {
                    case "Có người":

                        break;
                    default:
                        break;
                }
                panelListTable.Controls.Add(button);
            }
        }
        private void Load_cbDanhMuc()
        {
           cbDanhMuc.Properties.DataSource = (from item in caPheContext.LoaiSanPhams
                                                select new { item.TenLoaiSanPham, item.LoaiSanPhamId }).ToList();
           cbDanhMuc.Properties.DisplayMember = "TenLoaiSanPham";
           cbDanhMuc.Properties.ValueMember = "LoaiSanPhamId";
        }
        private void Load_cbSanPham(int DanhmucID)
        {

            if (cbDanhMuc.Text != "-- Chọn danh mục --")
            {
                cbSanPham.Properties.DataSource = (from item in caPheContext.SanPhams
                                                   where item.LoaiSanPhamId.Equals(DanhmucID)
                                                   select new { item.SanPhamId, item.TenSanPham, item.DonGia }).ToList();
                cbSanPham.Properties.DisplayMember = "TenSanPham";
                cbSanPham.Properties.ValueMember = "SanPhamId";
            }
        }

        private void cbDanhMuc_EditValueChanged_1(object sender, EventArgs e)
        {
            int DanhMucID = int.Parse(cbDanhMuc.EditValue.ToString());
            Load_cbSanPham(DanhMucID);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var ban = new Query_Ban();
            var context = new CaPheContext();
            if (cbSanPham.EditValue == null|| cbDanhMuc.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn món");
                return;
            }
            if (BanID == 0)
            {
                XtraMessageBox.Show("Hãy chọn bàn");
                return;
            }
            int BillID = hoaDon.LayHoaDonChuaThanhToan(BanID);
                int SanphamID = int.Parse(cbSanPham.EditValue.ToString());
                int SoLuong = int.Parse(spSoLuong.Value.ToString());
            if (BillID == 0)
            {
                
                    hoaDon.AddHoaDon(BanID);
                    hoaDon.AddChiTietHoaDon(hoaDon.GetMaxBill(), SanphamID, SoLuong);
                
            }
            else
            {
                hoaDon.AddChiTietHoaDon(BillID, SanphamID, SoLuong);
            }
            ban.Update_Ban(context, BanID);
            ShowBill(BanID);
            Load_Table();
        }
        void button_Click(object sender, EventArgs e)
        {
            BanID = ((sender as SimpleButton).Tag as Ban).BanId;
            ShowBill(BanID);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        { 
            var context = new CaPheContext();
            var hoadon1 = new Query_HoaDon();
            var sp = new Query_SanPham();
            var ban = new Query_Ban();
            if (BanID == 0)
            {
                XtraMessageBox.Show("Xin hãy chọn bàn để thanh toán!");
                return;
            }
            int HoaDonID = hoaDon.LayHoaDonChuaThanhToan(BanID);

            var quer = (from chitiethoadon in context.ChiTietHoaDons
                        join sanpham in context.SanPhams on chitiethoadon.SanPhamID equals sanpham.SanPhamId
                        where chitiethoadon.HoaDonID == HoaDonID
                        select new {TenMon= sanpham.TenSanPham, chitiethoadon.SoLuong, sanpham.DonGia, ThanhTien = chitiethoadon.SoLuong * sanpham.DonGia }).ToList();
           // double totalPrice = hoadon.TinhTien(context, HoaD onID);
            int discount = (int)spDiscount.Value;
           double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]) * 1000;
            double finalPrice = totalPrice - (totalPrice / 100) * discount;
            if (HoaDonID != 0)
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0} chứ?", BanID),
                        "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    XtraReport report = new XtraReport();
                    report.DataSource = quer;
                    report.Parameters["TableName"].Value = BanID;
                    report.Parameters["Discount"].Value = discount;
                    report.Parameters["CreateDate"].Value = DateTime.Now;
                    report.Parameters["TotalPrice"].Value = finalPrice;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                    hoadon1.CapNhatTrangThaiHoaDon(HoaDonID, context,finalPrice );
                    ban.Update_Ban1(context, BanID);
                }
            }
            Load_Table();
        }
        void ShowBill(int BanID)
        {
            gcBill.DataSource = null;
            double ThanhTien = 0;
            int HoaDonID = hoaDon.LayHoaDonChuaThanhToan(BanID);
            var quer = (from sanpham in caPheContext.SanPhams
                        join chitiethoadon in caPheContext.ChiTietHoaDons on sanpham.SanPhamId equals chitiethoadon.SanPhamID
                        join hoadon in caPheContext.HoaDons on chitiethoadon.HoaDonID equals hoadon.HoaDonId
                        orderby hoadon.HoaDonId
                        where hoadon.TinhTrang.Equals(0) && hoadon.HoaDonId.Equals(HoaDonID)
                        select new { sanpham.TenSanPham, chitiethoadon.SoLuong, sanpham.DonGia, TongGia = chitiethoadon.SoLuong * sanpham.DonGia }
                        ).ToList();
            gcBill.DataSource = quer;
            gvBill.Columns[0].Caption = "Tên món";
            gvBill.Columns[1].Caption = "Số lượng";
            gvBill.Columns[2].Caption = "Đơn giá";
            gvBill.Columns[3].Caption = "Tổng giá";
            foreach (var item in quer)
            {
                ThanhTien += item.TongGia;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = ThanhTien.ToString("c", culture);
        }
    }
}