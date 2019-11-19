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
    public delegate void Load_CbMenu();
    public delegate void ShowDanhmuc();
    public partial class frMenu : DevExpress.XtraEditors.XtraForm
    {
        public frMenu()
        {
            InitializeComponent();
        }
        Query_DanhMuc danhMuc = new Query_DanhMuc();
        CaPheContext caPheContext = Global.context;
        Query_SanPham sanPham = new Query_SanPham();
        int SanPhamId = 0;
        private void frMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_cbMenu();
            Load_Menu();
            ClearInfor();
        }
        private void ShowFrDanhMuc()
        {
            frDanhMuc fr = new frDanhMuc(Load_Menu);
            fr.ShowDialog();
        }
        public void Load_cbMenu()
        {
            var query = (from item in caPheContext.LoaiSanPhams
                         select new { item.TenLoaiSanPham, item.LoaiSanPhamId }).ToList();
            cbMenu.Properties.DataSource = query;
           cbMenu.Properties.DisplayMember = "TenLoaiSanPham";
            cbMenu.Properties.ValueMember = "LoaiSanPhamId";

            cbTimKiem.Properties.DataSource = query;
            cbTimKiem.Properties.DisplayMember = "TenLoaiSanPham";
            cbTimKiem.Properties.ValueMember = "LoaiSanPhamId";
        }
        private void Load_Menu()
        {
          
            gcMenu.DataSource = (from item in caPheContext.SanPhams
                                 select new { item.SanPhamId, item.TenSanPham,item.DonGia,item.TinhTrang,item.LoaiSanPhamId }).ToList();
            gvMenu.Columns[0].Caption = "Mã sản phẩm";
            gvMenu.Columns[1].Caption = "Tên sản phẩm";
            gvMenu.Columns[2].Caption = "Đơn giá";
            gvMenu.Columns[3].Caption = "Tình trạng";
            gvMenu.Columns[4].Caption = "Mã danh mục";
        }
        private void gvMenu_Click(object sender, EventArgs e)
        {
            if (gvMenu.RowCount > 0)
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                SanPhamId = int.Parse(gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[0]).ToString());
                txtTen.Text = gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[1]).ToString();
                txtGia.Text = gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[2]).ToString();
                cbMenu.EditValue =(gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[4])).ToString();
            }
        }

        private void ClearInfor()
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnXem.Enabled = false;
            cbTimKiem.Enabled = false;
            txtTen.Text = "";
            txtGia.Text = "";
            cbMenu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
         
            if (txtTen.Text.Replace(" ", "") != "" && txtGia.Text.Replace(" ", "") != "" && cbMenu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm này chứ!", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    var donGia = Convert.ToDouble(txtGia.Text);
                    var DanhMucID = Convert.ToInt32(cbMenu.EditValue);
                    if (sanPham.Add_Mon(tenMon, caPheContext, donGia, DanhMucID))
                    {
                        MessageBox.Show("Đã thêm sản phẩm!");
                        Load_Menu();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearInfor();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         
            if (txtTen.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa món này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string tenMon = txtTen.Text;
                   double donGia = Convert.ToDouble(txtGia.Text);
                   int LoaiSanPham = (int)cbMenu.EditValue;
                    if (sanPham.Update_Mon(SanPhamId,tenMon, caPheContext, donGia,LoaiSanPham))
                    {
                        MessageBox.Show("Đã sửa sản phẩm");
                        Load_Menu();
                    }
                    else
                        MessageBox.Show("Sản phẩm không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearInfor();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();
            if (txtTen.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có xóa món này chứ!", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    if (sanPham.Delete_Mon(tenMon, context))
                    {
                        MessageBox.Show("Đã xóa sản phẩm");
                        Load_Menu();
                    }
                    else
                        MessageBox.Show("Sản phẩm không tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thêm thông tin!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearInfor();
        }

        private void radioXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            btnXem.Enabled = true;
            cbTimKiem.Enabled = false;
        }

        private void radioXemTheoDanhMuc_CheckedChanged(object sender, EventArgs e)
        {
            btnXem.Enabled = true;
            cbTimKiem.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load_MenuTheoTen(txtSearchCategory.Text);
        }
        private void Load_MenuTheoTen(string TenSanPham)
        {
            string TinhTrang = "Đang hoạt động";
            gcMenu.DataSource = (from item in caPheContext.SanPhams
                                 where item.TinhTrang.Contains(TinhTrang) && item.TenSanPham.Contains(TenSanPham)
                                 select new { item.SanPhamId, item.TenSanPham, item.DonGia, item.TinhTrang, item.LoaiSanPhamId }).ToList();
            gvMenu.Columns[0].Caption = "Mã sản phẩm";
            gvMenu.Columns[1].Caption = "Tên sản phẩm";
            gvMenu.Columns[2].Caption = "Đơn giá";
            gvMenu.Columns[3].Caption = "Tình trạng";
            gvMenu.Columns[4].Caption = "Mã danh mục";
        }
        private void Load_MenuTheoDanhMuc(int DanhMucID)
        {
            string TinhTrang = "Đang hoạt động";
            gcMenu.DataSource = (from item in caPheContext.SanPhams
                                 where item.TinhTrang.Contains(TinhTrang) && item.LoaiSanPhamId.Equals(DanhMucID)
                                 select new { item.SanPhamId, item.TenSanPham, item.DonGia, item.TinhTrang, item.LoaiSanPhamId }).ToList();
            gvMenu.Columns[0].Caption = "Mã sản phẩm";
            gvMenu.Columns[1].Caption = "Tên sản phẩm";
            gvMenu.Columns[2].Caption = "Đơn giá";
            gvMenu.Columns[3].Caption = "Tình trạng";
            gvMenu.Columns[4].Caption = "Mã danh mục";
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
           
            if (radioXemTatCa.Checked == true)
            {
                Load_Menu();
            }
            if (radioXemTheoDanhMuc.Checked == true)
            {
                if (cbTimKiem.EditValue == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn danh mục!", "Thông báo");
                    return;

                }
                Load_MenuTheoDanhMuc((int)cbTimKiem.EditValue);
            }
        }
    }
}