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
    public partial class frXuatKho : DevExpress.XtraEditors.XtraForm
    {
        
        public frXuatKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }
        CaPheContext capheContext = new CaPheContext();
        Query_PhieuXuat phieuxuat = new Query_PhieuXuat();
        Query_HangHoa hanghoa = new Query_HangHoa();
        Query_ChiTietPhieuXuat chitietphieuxuat = new Query_ChiTietPhieuXuat();
         private void frXuatKho_Load(object sender, EventArgs e)
        {
            Load_CbHangHoa();
            Load_gvXuatKho(DateTime.Now);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnXuatPhieuNhap_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //ReportPrintTool tool = new ReportPrintTool(report);
                //tool.ShowPreview();
            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            int SoLuong = 0;
            if (txtSoLuongTon.Text != "")
                SoLuong = int.Parse(txtSoLuongTon.Text);
            string TenHangHoa = cbTenHangHoa.Text;
            DateTime NgayLap = DateTime.Now;
            string DonViTinh = txtDonViTinh.Text;
            if (txtDonViTinh.Text != "" && txtSoLuongTon.Text != ""  && cbTenHangHoa != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lấy sản phẩm này từ kho chứ!", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (phieuxuat.LayPhieuXuatIdTheoNgayNhap(NgayLap) == 0)
                    {
                        phieuxuat.ThemPhieuXuat( Global.NhanVienID,NgayLap);
                    }
                    if (!phieuxuat.KiemTraHangHoaTheoNgay(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), NgayLap))
                    {
                        hanghoa.CapNhatSoLuongHangHoaKhiXuat(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa),SoLuong,NgayLap);
                        
                        chitietphieuxuat.ThemChiTietPhieuXuat(phieuxuat.LayPhieuXuatIdTheoNgayNhap(NgayLap), hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong);
                    }
                    else chitietphieuxuat.CapNhatChiTietPhieuXuat(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                    hanghoa.CapNhatSoLuongHangHoaKhiXuat(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                    Load_gvXuatKho(DateTime.Now);
                }
            }
            else XtraMessageBox.Show("Xin nhập thêm thông tin!", "Thông báo");
        }
        private void Load_gvXuatKho(DateTime dateTime)
        {
            var query = (from hanghoa in capheContext.HangHoas
                         join chitietPhieuXuat in capheContext.ChiTietPhieuXuats on hanghoa.HangHoaId equals chitietPhieuXuat.HangHoaId
                         join phieuXuat in capheContext.PhieuXuats on chitietPhieuXuat.PhieuXuatId equals phieuXuat.PhieuXuatId
                         where DbFunctions.TruncateTime(phieuXuat.NgayLap) == dateTime.Date
                         select new
                         {
                             hanghoa.TenHangHoa,
                             chitietPhieuXuat.SoLuongXuat,
                             hanghoa.DonGia,
                             hanghoa.DonViTinh,
                             phieuXuat.NgayLap
                         }).ToList();
            gcXuatKho.DataSource = query;
            //report.DataSource = query;
            //report.Parameters["CreateDate"].Value = dateTime;
            //report.Parameters["NguoiLap"].Value = Global.NhanVienID;
            //report.Parameters["TotalPrice"].Value = totalprice;
            gvXuatKho.Columns[0].Caption = "Tên hàng hóa";
            gvXuatKho.Columns[1].Caption = "Số lượng xuất";
            gvXuatKho.Columns[2].Caption = "Đơn vị tính";
            gvXuatKho.Columns[3].Caption = "Ngày xuất";
        }
        private void Load_CbHangHoa()
        {
            cbTenHangHoa.Properties.DataSource = (from item in capheContext.HangHoas
                                           select new
                                           {
                                               item.HangHoaId,
                                               item.TenHangHoa
                                           }).ToList();

            cbTenHangHoa.Properties.DisplayMember = "TenHangHoa";
            cbTenHangHoa.Properties.ValueMember = "HangHoaId";
        }

        private void gcXuatKho_Click(object sender, EventArgs e)
        {
            //txtSoLuongTon.Text = "";
            //txtDonViTinh.Text = gcXuatKho.GetRowCellValue(gcXuatKho.FocusedRowHandle, gcXuatKho.Columns[3]).ToString();
            //cbTenHangHoa.Text = gcXuatKho.GetRowCellValue(gcXuatKho.FocusedRowHandle, gcXuatKho.Columns[4]).ToString();
        }
    }
}