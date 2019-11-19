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
using System.Data.Entity;
using DevExpress.XtraReports.UI;

namespace CafeManagement.GUI
{
    public partial class frNhapKho : DevExpress.XtraEditors.XtraForm
    {
        CaPheContext capheContext = Global.context;
        Query_PhieuNhap phieunhap = new Query_PhieuNhap();
        Query_HangHoa hangHoa = new Query_HangHoa();
        Query_ChiTietPhieuNhap chitietphieunhap = new Query_ChiTietPhieuNhap();
        Query_NhanVien nhanvien = new Query_NhanVien();
        reportPhieuNhap report = new reportPhieuNhap();
        public frNhapKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            int SoLuong = 0;
            if (txtSoLuongNhap.Text != "")
                SoLuong = int.Parse(txtSoLuongNhap.Text);
           
          
            string TenHangHoa = txtTenSanPham.Text;
            string DonViTinh = txtDonViTinh.Text;
            DateTime NgayLap =DateTime.Now;
            if (txtDonGia.Text != "" && TenHangHoa != "" && DonViTinh != "" && cbNCC.EditValue != null)
            {
                float DonGia = float.Parse(txtDonGia.Text);
                int NhacungCapId = int.Parse(cbNCC.EditValue.ToString());
                if (XtraMessageBox.Show("Bạn muốn thêm sản phẩm này vào kho chứ!", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (phieunhap.LayPhieuNhapIdTheoNgayNhap(NgayLap) == 0)
                    {
                        phieunhap.ThemPhieuNhap(NhacungCapId, Global.NhanVienID, NgayLap);
                    }
                    if (!phieunhap.KiemTraHangHoaTheoNgay(hangHoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), NgayLap))
                    {
                        hangHoa.ThemHangHoa(TenHangHoa, DonViTinh, DonGia, 0);
                        chitietphieunhap.ThemChiTietPhieuNhap(phieunhap.LayPhieuNhapIdTheoNgayNhap(NgayLap), hangHoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong);
                    }
                    else chitietphieunhap.CapNhatChiTietPhieuNhap(hangHoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                    hangHoa.CapNhatHangHoa(hangHoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                    Load_gvNhapKho(DateTime.Now);
                }
            }
            else XtraMessageBox.Show("Xin nhập thêm thông tin!","Thông báo");
        }
        private void Load_CbNhaCungCap()
        {
            cbNCC.Properties.DataSource = (from item in capheContext.NhaCungCaps
                                           select new
                                           {
                                               item.NhaCungCapId,
                                               item.TenNhaCungCap
                                           }).ToList();

            cbNCC.Properties.DisplayMember = "TenNhaCungCap";
            cbNCC.Properties.ValueMember = "NhaCungCapId";
        }


        private void frNhapKho_Load(object sender, EventArgs e)
        {
            Load_CbNhaCungCap();
            Load_gvNhapKho(DateTime.Now);
        }
        private void Load_gvNhapKho(DateTime dateTime)
        {
            int totalprice = 0;
                var query = (from hanghoa in capheContext.HangHoas
                                    join chitietPhieuNhap in capheContext.ChiTietPhieuNhaps on hanghoa.HangHoaId equals chitietPhieuNhap.HangHoaID
                                    join phieuNhap in capheContext.PhieuNhaps on chitietPhieuNhap.PhieuNhapId equals phieuNhap.PhieuNhapId
                                    join nhacungcap in capheContext.NhaCungCaps on phieuNhap.NhaCungCapId equals nhacungcap.NhaCungCapId
                                    where DbFunctions.TruncateTime(phieuNhap.NgayDatHang) == dateTime.Date
                                    select new
                                    {
                                        hanghoa.TenHangHoa,
                                        chitietPhieuNhap.SoLuongDat,
                                        hanghoa.DonGia,
                                        hanghoa.DonViTinh,
                                        nhacungcap.TenNhaCungCap,
                                        phieuNhap.NgayDatHang
                                    }).ToList();
            foreach (var item in query)
            {
                totalprice += (int)item.DonGia * item.SoLuongDat;
            }
            gcNhapKho.DataSource = query;
            report.DataSource = query;
            report.Parameters["CreateDate"].Value = dateTime;
            report.Parameters["NguoiLap"].Value =nhanvien.LayTenNhanVienbyNhanVienID(Global.NhanVienID,capheContext);
            report.Parameters["TotalPrice"].Value = totalprice;
            gvNhapKho.Columns[0].Caption = "Tên hàng hóa";
            gvNhapKho.Columns[1].Caption = "Số lượng nhập";
            gvNhapKho.Columns[2].Caption = "Đơn giá";
            gvNhapKho.Columns[3].Caption = "Đơn vị tính";
            gvNhapKho.Columns[4].Caption = "Nhà cung cấp";
            gvNhapKho.Columns[5].Caption = "Ngày nhập";
        }

        private void gcNhapKho_Click(object sender, EventArgs e)
        {
            if (gvNhapKho.RowCount > 0)
            {
                txtTenSanPham.Text = gvNhapKho.GetRowCellValue(gvNhapKho.FocusedRowHandle, gvNhapKho.Columns[0]).ToString();
                txtSoLuongNhap.Text = "";
                txtDonGia.Text = gvNhapKho.GetRowCellValue(gvNhapKho.FocusedRowHandle, gvNhapKho.Columns[2]).ToString();
                txtDonViTinh.Text = gvNhapKho.GetRowCellValue(gvNhapKho.FocusedRowHandle, gvNhapKho.Columns[3]).ToString();
                cbNCC.Text = gvNhapKho.GetRowCellValue(gvNhapKho.FocusedRowHandle, gvNhapKho.Columns[4]).ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnLuuLai.Enabled = true;
            DateTime dateTime = DateTime.Parse(dateEditTimKiem.Text);
            if (Convert.ToDateTime(dateEditTimKiem.Text).Date!=DateTime.Now.Date)
                btnLuuLai.Enabled = false;
     
            Load_gvNhapKho(dateTime);
        }

        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                     "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}