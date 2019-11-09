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
using DevExpress.XtraGrid.Views.Grid;

namespace CafeManagement.GUI
{
    public partial class frDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public frDanhMuc()
        {
            InitializeComponent();
        }

        private void frDanhMuc_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_DanhMuc();
        }
        CaPheContext caPheContext = new CaPheContext();
        Query_DanhMuc danhmuc = new Query_DanhMuc();
      
     
        private void Load_DanhMuc()
        {

            txtTen.Text= "";
            gcDanhMuc.DataSource = (from item in caPheContext.LoaiSanPhams
                                    select new { item.LoaiSanPhamId, item.TenLoaiSanPham }).ToList();
            gvDanhMuc.Columns[0].Caption = "Mã danh mục";
            gvDanhMuc.Columns[1].Caption = "Tên danh mục";
         
        }

    
     

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            string TenDanhMuc = (string)txtTenDanhMuc.EditValue;
            if (txtTenDanhMuc.EditValue != null)
            {
                int x = danhmuc.FindDanhMuc(TenDanhMuc).Count();
                if (x>0)
                {
                    gcDanhMuc.DataSource = danhmuc.FindDanhMuc(TenDanhMuc);
                }
                else MessageBox.Show("Không tìm thấy!", "Tìm danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Tên danh mục!", "Xóa danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        private void gvDanhMuc_Click(object sender, EventArgs e)
        {
            if (gvDanhMuc.RowCount > 0)
                txtTen.Text = gvDanhMuc.GetRowCellValue(gvDanhMuc.FocusedRowHandle, gvDanhMuc.Columns[1]).ToString();
        }

        private void txtTenDanhMuc_Click(object sender, EventArgs e)
        {
            txtTenDanhMuc.EditValue = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm danh mục này chứ!", "Thêm danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {


                    string TenDanhMuc = (string)txtTen.Text;

                    if (danhmuc.AddDanhMuc(TenDanhMuc))
                    {
                        MessageBox.Show("Thêm danh mục thành công!", "Thêm danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Danh mục này đã tồn tại", "Thêm danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Tên danh mục!", "Thêm danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtTen.Text != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa danh mục này chứ!", "Thêm danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {


                    string TenDanhMuc = (string)txtTen.Text;
                    if (danhmuc.DeleteDanhMuc(TenDanhMuc))
                    {
                        MessageBox.Show("Xóa danh mục thành công!", "Xóa danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DanhMuc();
                    }
                    else
                    {
                        MessageBox.Show("Danh mục này không đã tồn tại", "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Tên danh mục!", "Xóa danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_DanhMuc();
        }
    }
}