using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement.Data;
using CafeManagement.LinQ;
using System.Data.Entity;

namespace CafeManagement.GUI
{
    public partial class frChinhSuaNV : Form
    {
        public frChinhSuaNV()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        CaPheContext context = Global.context;
        Query_NhanVien nv = new Query_NhanVien();
        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật nhân viên  này chứ!", "Cập nhật nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string hoten = txtHoTen.Text;
                   string  quequan = txtQueQuan.Text;
                    string chucvu = txtChucVu.Text;
                    string sdt = txtSDT.Text;
                    string cmnd = txtCMND.Text;
                    DateTime ngaysinh = Convert.ToDateTime(dtpNgaySinh.Value);
                    DateTime ngayvaolam = Convert.ToDateTime(dtpNgayVaoLam.Value);
                    byte[] hinh = null;
                    // hinh = ConvertImageToBinary(picImage.Image);
                    if (nv.Update_NV(context,Global.NhanVienID, hoten, quequan, chucvu, cmnd, sdt, ngaysinh, ngayvaolam, hinh))
                    {
                        MessageBox.Show("Da cap nhat nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc cap nhat vao");
                }
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Cập Nhật  Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
