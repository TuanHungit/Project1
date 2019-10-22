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
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();
            if (txtTen.Text.Replace(" ", "") != "" && txtGia.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm bàn này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    var donGia = Convert.ToDouble(txtGia.Text);
                    if (sanPham.Add_Mon(tenMon, context, donGia, 1))
                    {
                        MessageBox.Show("Da them san pham");
                    }
                    else
                    {
                        MessageBox.Show("San phamda ton tai");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var context = new CaPheContext();
            var sanPham = new Query_SanPham();
            if (txtTen.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm bàn này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var tenMon = txtTen.Text;
                    if (sanPham.Delete_Mon(tenMon, context))
                        MessageBox.Show("Da xoa mon");
                    else
                        MessageBox.Show("Mon khong ton tai");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Da sua mon");
                    else
                        MessageBox.Show("Mon khong ton tai");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}