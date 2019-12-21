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
    public partial class frKho : DevExpress.XtraEditors.XtraForm
    {
        public frKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }
        CaPheContext capheContext = Global.context;
        Query_HangHoa hanghoa = new Query_HangHoa();
        private void frKho_Load(object sender, EventArgs e)
        {
            txtTenSanPham.Enabled = false;
            txtSoLuongTon.Enabled = false;

            txtDonGia.Enabled = false;
            txtDonViTinh.Enabled = false;
            //load_btn();
            Load_gvKho();
        }
        private void load_btn()
        {
         
            btnXoa.Enabled = true;
        }
        private void Load_gvKho()
        {
            gcKho.DataSource = (from hanghoa in capheContext.HangHoas
                                where hanghoa.TinhTrang == "Đang hoạt động"
                                    select new
                                    {
                                        hanghoa.TenHangHoa,
                                       hanghoa.SoLuongTon,
                                        hanghoa.DonGia,
                                        hanghoa.DonViTinh               
                                    }).ToList();
            gvKho.Columns[0].Caption = "Tên hàng hóa";
            gvKho.Columns[1].Caption = "Số lượng tồn";
            gvKho.Columns[2].Caption = "Đơn giá";
            gvKho.Columns[3].Caption = "Đơn vị tính";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text == null)
            {
                XtraMessageBox.Show("Xin vui lòng chọn sản phẩm!", "Thông báo!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hàng hóa này chứ!", "Xóa Hàng hóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (hanghoa.XoaHangHoa(hanghoa.LayHangHoaIDTheoTenHangHoa(txtTenSanPham.Text)))
                {
                    XtraMessageBox.Show("Xóa hàng hóa thành công!");
                    Load_gvKho();
                    
                }
                else
                {
                    XtraMessageBox.Show("Hàng hóa không tồn tại!");   
                }
            }
            ClearData();
        }

        private void gcKho_Click(object sender, EventArgs e)
        {
            if (gvKho.RowCount > 0)
            {
                load_btn();
                txtTenSanPham.Text = gvKho.GetRowCellValue(gvKho.FocusedRowHandle, gvKho.Columns[0]).ToString();
                txtSoLuongTon.Text = gvKho.GetRowCellValue(gvKho.FocusedRowHandle, gvKho.Columns[1]).ToString();
                txtDonGia.Text = gvKho.GetRowCellValue(gvKho.FocusedRowHandle, gvKho.Columns[2]).ToString();
               txtDonViTinh.Text = gvKho.GetRowCellValue(gvKho.FocusedRowHandle, gvKho.Columns[3]).ToString();
            }
        }
        public void ClearData()
        {
            txtTenSanPham.Text = "";
            txtSoLuongTon.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            load_btn();
            Load_gvKho();
        }
    }
}