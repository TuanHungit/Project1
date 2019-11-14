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
    public partial class frDanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frDanhThu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            btnXuatBaoCao.Enabled = false;
        }
        CaPheContext context = new CaPheContext();
        Query_DanhThu danhthu = new Query_DanhThu();

        private void btnXem_Click(object sender, EventArgs e)
        {
            double doanhthu = 0;
            if (deFromDate.Text == "")
                MessageBox.Show("Vui Lòng Chọn Ngày");
            else
            {
                DateTime date1 = Convert.ToDateTime(deFromDate.Text).Date;
                DateTime date2;
                if (deToDate.Text == "")
                {
                    date2 = date1;
                    labelDanhThu.Text = danhthu.TinhTongDoanhThu(context, doanhthu, date1, date2).ToString();
                    Load(date1, date2);
                }
                else
                {
                    date2 = Convert.ToDateTime(deToDate.Text).Date;
                    if (date2.Date < date1.Date)
                    {
                        MessageBox.Show("Vui lòng chọn ngày khác");
                    }
                    else
                    {
                        labelDanhThu.Text = danhthu.TinhTongDoanhThu(context, doanhthu, date1, date2).ToString();
                        Load(date1, date2);
                    }
                }
            }
        }
        reportBaoCaoDanhThu report = new reportBaoCaoDanhThu();
        private void Load(DateTime date1, DateTime date2)
        {
            var query = (from hoadon in context.HoaDons
                         join nhanvien in context.NhanViens on hoadon.NhanVienId equals nhanvien.NhanVienId
                         where DbFunctions.TruncateTime(hoadon.NgayLap) >= date1.Date && DbFunctions.TruncateTime(hoadon.NgayLap) <= date2.Date
                               && hoadon.TinhTrang.Equals(1)
                         select new
                         {
                             hoadon.HoaDonId,
                             hoadon.NgayLap,
                             nhanvien.HoTenNV,
                             hoadon.BanID,
                             hoadon.TongGia
                         }).ToList();


            gridControl1.DataSource = query;
            report.DataSource = query;
            report.Parameters["FromDate"].Value = deFromDate.Text;
            report.Parameters["ToDate"].Value = deToDate.Text;
            report.Parameters["NguoiLap"].Value = "NguyenTuanHung";

            report.Parameters["CreateDate"].Value = DateTime.Now;
            report.Parameters["TotalPrice"].Value = labelDanhThu.Text;
            gridView1.Columns[0].Caption = "ID Hóa Đơn";
            gridView1.Columns[1].Caption = "Ngày Lập";
            gridView1.Columns[2].Caption = "Tên Nhân Viên ";
            gridView1.Columns[3].Caption = "Số Bàn";
            gridView1.Columns[4].Caption = "Tổng Giá";
            if (gridView1.RowCount > 0)
            {
                btnXuatBaoCao.Enabled = true;
            }else btnXuatBaoCao.Enabled = false;
        }
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(string.Format("Bạn có chắc xuất báo cáo doanh thu này chứ?"),
                       "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }

        }
    }
}
