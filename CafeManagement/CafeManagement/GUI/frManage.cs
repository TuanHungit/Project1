﻿using System;
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
using DevExpress.LookAndFeel;

namespace CafeManagement.GUI
{
    public  partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        int BanID = 0;
        int SanphamID = 0;
        double totalPrice;
        double finalPrice;
        Query_Ban ban = new Query_Ban();
        Query_SanPham sanPham = new Query_SanPham();
        CaPheContext context = new CaPheContext();
        Query_HoaDon hoaDon = new Query_HoaDon();
        CultureInfo culture = new CultureInfo("vi-VN");
        
        public frManage()
        {
            InitializeComponent();
        }
        private void frManage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_Table();
            Load_cbDanhMuc();
       
        }
       
        private void Load_Table() 
        {
           panelBan.Controls.Clear();          
            List<Ban> danhsachban = new List<Ban>(); 
            danhsachban=ban.GetAllTable(context);         
            foreach (Ban item in danhsachban)
            {
                SimpleButton button = new SimpleButton() { Width = 85, Height = 85 };
                button.Text = item.BanId.ToString() + " "+item.TinhTrang.ToString();
              button.ImageOptions.Image = System.Drawing.Bitmap.FromFile(@"C:\Users\hung1\OneDrive\Máy tính\CafeManagement\CafeManagement\Resources\Household-Table-icon.png");
                button.ImageOptions.Location = ImageLocation.TopCenter;
                button.Tag = item;             
                button.Click += button_Click;               
                switch (item.TinhTrang.ToString())
                {
                    case "Có người":
          //              button.ImageOptions.Image = System.Drawing.Bitmap.FromFile(@"C:\Users\hung1\OneDrive\Documents\GitHub\CafeManagement\CafeManagement\Resources\user.png");
                        button.ImageOptions.Location = ImageLocation.TopCenter;
                        button.LookAndFeel.UseDefaultLookAndFeel = false;
                        button.Appearance.BackColor = Color.Aqua;
                        button.Appearance.Options.UseBackColor = true;
                        break;
                    default:
                     
                        break;
                }
                panelBan.Controls.Add(button);
            }
        }
        private void Load_cbDanhMuc()
        {
           cbDanhMuc.Properties.DataSource = (from item in context.LoaiSanPhams
                                                select new { item.TenLoaiSanPham, item.LoaiSanPhamId }).ToList();
           cbDanhMuc.Properties.DisplayMember = "TenLoaiSanPham";
           cbDanhMuc.Properties.ValueMember = "LoaiSanPhamId";
        }
        private void Load_listviewMenu(int DanhmucID)
        {
            listviewMenu.Items.Clear();
            var Menu = (from item in context.SanPhams
                                                   where item.LoaiSanPhamId.Equals(DanhmucID)
                                                   select new { item.SanPhamId, item.TenSanPham, item.DonGia }).ToList();
            foreach (var item in Menu)
            {
                ListViewItem listViewItem = new ListViewItem(item.TenSanPham.ToString());
                listViewItem.SubItems.Add(item.DonGia.ToString()+ " VND");
                listviewMenu.Items.Add(listViewItem);
            }                
        }
        private void cbDanhMuc_EditValueChanged_1(object sender, EventArgs e)
        {
            int DanhMucID = int.Parse(cbDanhMuc.EditValue.ToString());   
            Load_listviewMenu(DanhMucID);
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (SanphamID == 0||cbDanhMuc.EditValue==null)
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

            if (BillID == 0)
            {
                hoaDon.AddHoaDon(BanID);
                hoaDon.AddChiTietHoaDon(hoaDon.GetMaxBill(), SanphamID, 1);
            }
            else
            {
                hoaDon.AddChiTietHoaDon(BillID, SanphamID, 1);
            }
            ban.Update_Ban(context, BanID);
            ShowBill(BanID);
            Load_Table();
        }
        void button_Click(object sender, EventArgs e)
        { 
            BanID = ((sender as SimpleButton).Tag as Ban).BanId;       
            labelBan.Text ="Bàn " +BanID.ToString();
            panelCheckBan.BackgroundImage = Properties.Resources.check_1_icon;
            ShowBill(BanID);            
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {                             
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
           double totalPrice = Convert.ToDouble(txtThanhTien.Text.Split(',')[0]) * 1000;
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
                    hoaDon.CapNhatTrangThaiHoaDon(HoaDonID, context,finalPrice );
                    ban.Update_Ban1(context, BanID);
                    Load_Table();
                }
            }
            ShowBill(BanID);
           
        }
        void ShowBill(int BanID)
        {
            gcBill.DataSource = null;
            double ThanhTien = 0;
            int HoaDonID = hoaDon.LayHoaDonChuaThanhToan(BanID);
            var quer = (from sanpham in context.SanPhams
                        join chitiethoadon in context.ChiTietHoaDons on sanpham.SanPhamId equals chitiethoadon.SanPhamID
                        join hoadon in context.HoaDons on chitiethoadon.HoaDonID equals hoadon.HoaDonId
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
          
            txtThanhTien.Text = ThanhTien.ToString("c", culture);
            totalPrice = Convert.ToDouble(txtThanhTien.Text.Split(',')[0]) * 1000;
            finalPrice = totalPrice - (totalPrice / 100) * ((int)spDiscount.Value);
            txtTongCong.Text = finalPrice.ToString("c", culture);
        }    
        private void spDiscount_EditValueChanged(object sender, EventArgs e)
        {
            finalPrice = totalPrice - (totalPrice / 100) * ((int)spDiscount.Value);
            txtTongCong.Text = finalPrice.ToString("c", culture);
        }

        private void listviewMenu_Click(object sender, EventArgs e)
        {
            listviewMenu.FullRowSelect = true;
            SanphamID = sanPham.LayIdSanPham(listviewMenu.SelectedItems[0].ToString(), context);
            foreach (ListViewItem items in listviewMenu.SelectedItems)
            {
                SanphamID = sanPham.LayIdSanPham(items.SubItems[0].Text, context);
            }
        }
      
 
     
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listviewMenu.Items.Clear();

            string TenSanPham = (string)txtTenSanPham.EditValue;
            List<SanPham> sanPhams = sanPham.TimSanPham(TenSanPham,context);
            if (txtTenSanPham.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sản phẩm!");
                return;
            }
            foreach (var item in sanPhams)
            {
                ListViewItem listViewItem = new ListViewItem(item.TenSanPham.ToString());
                listViewItem.SubItems.Add(item.DonGia.ToString() + " VND");
                listviewMenu.Items.Add(listViewItem);
            }
        }

        private void txtTenSanPham_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = null;
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            frChuyenBan frChuyenBan = new frChuyenBan();
            frChuyenBan.ShowDialog();
        }

        private void gcBill_Click(object sender, EventArgs e)
        {
            if (gvBill.RowCount > 0)
            {
                Global.TenSanPham = gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[0]).ToString();
                Global.Gia =double.Parse(gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[2]).ToString());
                Global.BanID = BanID;
                frChonMon fr = new frChonMon();
                fr.ShowDialog();
            }
        }

       
    }
}