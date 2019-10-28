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

namespace CafeManagement.GUI
{
    public partial class frNhanVien : Form
    {
        public frNhanVien()
        {
            InitializeComponent();
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            var context = new CaPheContext();
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nhân viên  này chứ!", "Thêm nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var hoten = txtHoTen.Text;
                    var chucvu = txtChucVu.Text;
                    var sdt = txtSDT.Text;
                    var cmnd = txtCMND.Text;
                    DateTime ngaysinh = Convert.ToDateTime(dtpNgaySinh.Value);
                    DateTime ngayvaolam = Convert.ToDateTime(dtpNgayVaoLam.Value);
                    var nv = new Query_NhanVien();
                    if (nv.Add_NV(context, hoten, chucvu, cmnd, sdt, ngaysinh, ngayvaolam))
                    {
                        MessageBox.Show("Da them nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc them vao");
                }
                Load_NV();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Thêm Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            var context = new CaPheContext();
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên  này chứ!", "Xóa nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var hoten = txtHoTen.Text;
                    var chucvu = txtChucVu.Text;
                    var sdt = txtSDT.Text;
                    var cmnd = txtCMND.Text;
                   
                    var nv = new Query_NhanVien();
                    if (nv.Delete_NV(context,hoten,chucvu,cmnd,sdt))
                    {
                        MessageBox.Show("Da xoa nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc xoa vao");
                }
                Load_NV();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Xóa Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void Load_NV()
        {
            var context = new CaPheContext();
            var nhanViens = (from nhanvien in context.NhanViens
                             select new { 
                               nhanvien.HoTenNV,
                               nhanvien.ChucVu,
                               nhanvien.SDT_NV,
                               nhanvien.CMND,
                               nhanvien.NgaySinh,
                               nhanvien.NgayVaoLam}).ToList();
            dgvNhanVien.DataSource = nhanViens;
            foreach (var nv in nhanViens)
            {
                for(int i = 0; i < nhanViens.Count; i++)
                {
                    dgvNhanVien.Rows[i].Cells[0].Value = nv.HoTenNV.ToString();
                    dgvNhanVien.Rows[i].Cells[1].Value = nv.ChucVu.ToString();
                    dgvNhanVien.Rows[i].Cells[2].Value = nv.SDT_NV.ToString();
                    dgvNhanVien.Rows[i].Cells[3].Value = nv.CMND.ToString();
                    dgvNhanVien.Rows[i].Cells[4].Value = nv.NgaySinh.ToString();
                    dgvNhanVien.Rows[i].Cells[5].Value = nv.NgayVaoLam.ToString();
                }               
            }
        }
        private void frNhanVien_Load(object sender, EventArgs e)
        {
            Load_NV();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            var context = new CaPheContext();
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật nhân viên  này chứ!", "Cập nhật nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var hoten = txtHoTen.Text;
                    var chucvu = txtChucVu.Text;
                    var sdt = txtSDT.Text;
                    var cmnd = txtCMND.Text;
                    DateTime ngaysinh = Convert.ToDateTime(dtpNgaySinh.Value);
                    DateTime ngayvaolam = Convert.ToDateTime(dtpNgayVaoLam.Value);
                    var nv = new Query_NhanVien();
                    if (nv.Update_NV(context, hoten, chucvu, cmnd, sdt,ngaysinh,ngayvaolam))
                    {
                        MessageBox.Show("Da cap nhat nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc cap nhat vao");
                }
                Load_NV();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Cập Nhật  Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
