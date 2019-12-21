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
            txtDonGia.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtSoLuongTon.Enabled = false;
            btnLuuLai.Enabled = false;
        }
        Query_PhieuXuat phieuxuat = new Query_PhieuXuat();
        Query_HangHoa hanghoa = new Query_HangHoa();
        Query_ChiTietPhieuXuat chitietphieuxuat = new Query_ChiTietPhieuXuat();
        Query_NhanVien nhanvien = new Query_NhanVien();
        reportPhieuXuat report = new reportPhieuXuat();
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
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            int SoLuong = 0;
            int SoLuongTon = int.Parse(txtSoLuongTon.Text);
            if (txtSoLuongXuat.Text != "")
                SoLuong = int.Parse(txtSoLuongXuat.Text);
            string TenHangHoa = cbTenHangHoa.Text;
            DateTime NgayLap = DateTime.Now;
            string DonViTinh = txtDonViTinh.Text;
            if (txtDonViTinh.Text != "" && txtSoLuongXuat.Text != ""  && cbTenHangHoa != null)
            {
                if (XtraMessageBox.Show("Bạn muốn lấy sản phẩm này từ kho chứ!", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (SoLuong > SoLuongTon)
                    {
                        XtraMessageBox.Show("Kho không đủ số lượng để xuất!", "Thông báo");
                    }
                    else
                    {
                      

                        if (phieuxuat.LayPhieuXuatIdTheoNgayNhap(NgayLap) == 0)
                        {
                            phieuxuat.ThemPhieuXuat(Global.NhanVienID, NgayLap);
                        }
                        if (!phieuxuat.KiemTraHangHoaTheoNgay(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), NgayLap))
                        {
                            chitietphieuxuat.ThemChiTietPhieuXuat(phieuxuat.LayPhieuXuatIdTheoNgayNhap(NgayLap), hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong);
                        }
                        else chitietphieuxuat.CapNhatChiTietPhieuXuat(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                        hanghoa.CapNhatHangHoa(hanghoa.LayHangHoaIDTheoTenHangHoa(TenHangHoa), SoLuong, NgayLap);
                        Load_gvXuatKho(DateTime.Now);
                    }
                }
            }
            else XtraMessageBox.Show("Xin nhập thêm thông tin!", "Thông báo");
            clearInfo();
            Load_CbHangHoa();
        }
        private void Load_gvXuatKho(DateTime dateTime)
        {
            double totalprice = 0;
            var query = (from hanghoa in Global.context.HangHoas
                         join chitietPhieuXuat in Global.context.ChiTietPhieuXuats on hanghoa.HangHoaId equals chitietPhieuXuat.HangHoaId
                         join phieuXuat in Global.context.PhieuXuats on chitietPhieuXuat.PhieuXuatId equals phieuXuat.PhieuXuatId
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
            foreach (var item in query)
            {
                totalprice += item.SoLuongXuat * item.DonGia;
            }
            report.DataSource = query;
            report.Parameters["CreateDate"].Value = dateTime;
            report.Parameters["NguoiLap"].Value = nhanvien.LayTenNhanVienbyNhanVienID(Global.NhanVienID, Global.context);
            report.Parameters["TotalPrice"].Value = totalprice;
            gvXuatKho.Columns[0].Caption = "Tên hàng hóa";
            gvXuatKho.Columns[1].Caption = "Số lượng xuất";
            gvXuatKho.Columns[2].Caption = "Đơn giá";
            gvXuatKho.Columns[3].Caption = "Đơn vị tính";
            gvXuatKho.Columns[4].Caption = "Ngày xuất";
        }
        private void Load_CbHangHoa()
        {
            cbTenHangHoa.Properties.DataSource = (from item in Global.context.HangHoas
                                                  where item.TinhTrang=="Đang hoạt động"
                                           select new
                                           {
                                               item.HangHoaId,
                                               item.TenHangHoa
                                           }).ToList();

            cbTenHangHoa.Properties.DisplayMember = "TenHangHoa";
            cbTenHangHoa.Properties.ValueMember = "HangHoaId";
          
        }


        private void cbTenHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            Load_Info();
        }
        private void Load_Info()
        {
            btnLuuLai.Enabled = true;
            var query = (from item in Global.context.HangHoas
                         where item.HangHoaId == (int)cbTenHangHoa.EditValue
                         select item).ToList();
            foreach (var item in query)
            {
                txtDonGia.Text = item.DonGia.ToString();
                txtDonViTinh.Text = item.DonViTinh;
                txtSoLuongTon.Text = item.SoLuongTon.ToString();
            }
        }
        private void clearInfo()
        {
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuongTon.Text = "";
            txtSoLuongXuat.Text = "";
            cbTenHangHoa.Properties.DataSource = null;
            Load_CbHangHoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnLuuLai.Enabled = true;
            if (dateEditTimKiem.Text == "")
            {
                XtraMessageBox.Show("Xin nhập thêm thông tin!");
                return;
            }
            DateTime dateTime = DateTime.Parse(dateEditTimKiem.Text);
            if (Convert.ToDateTime(dateEditTimKiem.Text).Date != DateTime.Now.Date)
                btnLuuLai.Enabled = false;

            Load_gvXuatKho(dateTime);
        }
    }
}