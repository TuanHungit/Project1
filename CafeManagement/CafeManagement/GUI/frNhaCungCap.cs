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
    public partial class frNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frNhaCungCap()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            LoadData();
            ClearData();
        }
        CaPheContext caPheContext = new CaPheContext();
        Query_NhaCungCap NhaCungCap = new Query_NhaCungCap();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string TenNCC = txtTenNCC.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            if (TenNCC !="" && SDT != "" && DiaChi != "" && Email != "")
            {
                if (NhaCungCap.ThemNhaCungCap(TenNCC, SDT, DiaChi, Email))
                {
                    XtraMessageBox.Show("Thêm nhà cung cấp thành công!", "Thêm nhà cung cấp");
                    LoadData();
                   
                }else XtraMessageBox.Show("Nhà cung cấp đã tồn tại!", "Thêm nhà cung cấp");
            }
            else XtraMessageBox.Show("Xin hãy nhập thêm thông tin!", "Thêm nhà cung cấp");
            ClearData();
        }
        private void LoadData()
        {
            gcNCC.DataSource = (from item in caPheContext.NhaCungCaps
                                select new { item.TenNhaCungCap, item.SDT, item.DiaChi, item.Email }).ToList();
            gvNCC.Columns[0].Caption = "Tên nhà cung cấp";
            gvNCC.Columns[1].Caption = "Số điện thoại";
            gvNCC.Columns[2].Caption = "Địa chỉ";
            gvNCC.Columns[3].Caption = "Email";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string TenNCC = txtTenNCC.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            if (TenNCC != "" && SDT != "" && DiaChi != "" && Email != "")
            {
                if (NhaCungCap.SuaNhaCungCap(NccId,TenNCC, SDT, DiaChi, Email))
                {
                    XtraMessageBox.Show("Sửa nhà cung cấp thành công!", "Sửa nhà cung cấp");
                    LoadData();
                    
                }else XtraMessageBox.Show("Nhà cung cấp đã tồn tại!", "Sửa nhà cung cấp");
            }
            else XtraMessageBox.Show("Xin hãy nhập thêm thông tin!", "Sửa nhà cung cấp");
            ClearData();
        }
        int NccId = 0;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string TenNCC = txtTenNCC.Text;
           
            if (TenNCC != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc xóa nhà cung cấp này chứ!"),
                        "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (NhaCungCap.XoaNhaCungCap(TenNCC))
                    {
                        XtraMessageBox.Show("Xóa nhà cung cấp thành công!", "Xóa nhà cung cấp");
                        LoadData();

                    }
                    else XtraMessageBox.Show("Nhà cung cấp này không tồn tại!", "Xóa nhà cung cấp");
                }
            }
            else XtraMessageBox.Show("Xin hãy nhập thêm thông tin!", "Xóa nhà cung cấp");
            ClearData();
        }

        private void gvNCC_Click(object sender, EventArgs e)
        {
            if (gvNCC.RowCount > 0)
            {
                txtTenNCC.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, gvNCC.Columns[0]).ToString();
                txtSDT.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, gvNCC.Columns[1]).ToString();
                txtDiaChi.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, gvNCC.Columns[2]).ToString();
                txtEmail.Text = gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, gvNCC.Columns[3]).ToString();
                NccId = NhaCungCap.LayIDByTenNhaCungCap(gvNCC.GetRowCellValue(gvNCC.FocusedRowHandle, gvNCC.Columns[0]).ToString());
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }
        private void ClearData()
        {
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void gcNCC_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frNhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}