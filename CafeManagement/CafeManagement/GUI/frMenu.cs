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
    public partial class frMenu : DevExpress.XtraEditors.XtraForm
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void frMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_cbMenu();
            Load_Menu();
        }
        Query_DanhMuc danhMuc = new Query_DanhMuc();
        CaPheContext caPheContext = new CaPheContext();
        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();
            if (txtTen.Text.Replace(" ", "") != "" && txtGia.Text.Replace(" ", "") != "" && cbMenu.Text.Replace(" ","")!="")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm này chứ!", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    var donGia = Convert.ToDouble(txtGia.Text);
                    var DanhMucID = Convert.ToInt32(cbMenu.EditValue);
                    if (sanPham.Add_Mon(tenMon, context, donGia, DanhMucID))
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
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();
            if (txtTen.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sản phẩm này chứ!", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();

            if (txtTen.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm bàn này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    var donGia = Convert.ToDouble(txtGia.Text);
                    if (sanPham.Update_Mon(tenMon, context, donGia))
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
        }

        private void Load_cbMenu()
        {
            cbMenu.Properties.DataSource = (from item in caPheContext.LoaiSanPhams
                                            select new { item.TenLoaiSanPham, item.LoaiSanPhamId }).ToList();
           cbMenu.Properties.DisplayMember = "TenLoaiSanPham";
            cbMenu.Properties.ValueMember = "LoaiSanPhamId";
        }
        private void Load_Menu()
        {
           
            gcMenu.DataSource = (from item in caPheContext.SanPhams
                                 select new { item.SanPhamId, item.TenSanPham,item.DonGia,item.LoaiSanPhamId }).ToList();
            gvMenu.Columns[0].Caption = "Mã sản phẩm";
            gvMenu.Columns[1].Caption = "Tên sản phẩm";
            gvMenu.Columns[2].Caption = "Đơn giá";
            gvMenu.Columns[3].Caption = "Mã danh mục";
        }

       

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Menu();
        }

        private void gvMenu_Click(object sender, EventArgs e)
        {
            //txtTen.Text = gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[1]).ToString();
            //txtGia.Text = gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[2]).ToString();
            //cbMenu.Text = gvMenu.GetRowCellValue(gvMenu.FocusedRowHandle, gvMenu.Columns[3]).ToString();
        }
    }
}