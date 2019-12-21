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
using System.IO;
using CafeManagement.Data;
using CafeManagement.LinQ;

namespace CafeManagement
{
    public partial class frNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frNhanvien()
        {
            InitializeComponent();
        }

        private void frNhanvien_Load(object sender, EventArgs e)
        {
            Load_NV();
            this.WindowState = FormWindowState.Maximized;

        }
        string hoten;
        string quequan ;
        string chucvu ;
        string sdt ;
        string cmnd ;
        DateTime ngaysinh;
        DateTime ngayvaolam ;
        byte[] hinh = null;
        Query_TaiKhoan taiKhoan = new Query_TaiKhoan();
       Query_NhanVien nv = new Query_NhanVien();
        CaPheContext context = Global.context;
        #region NhanVien
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((OPF.ShowDialog() == DialogResult.OK))
            {
               picImage.Image = Image.FromFile(OPF.FileName);
            }
        }
        byte[] ConvertImageToBinary(Image img)
        {
           
           
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
         
            //if (picImage.Image == null)
            //{
            //    XtraMessageBox.Show("Bạn chưa UpLoad hình!");
            //    return;
            //}
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nhân viên  này chứ!", "Thêm nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                     hoten = txtHoTen.Text;
                    quequan = txtQueQuan.Text;
                    chucvu = txtChucVu.Text;
                     sdt = txtSDT.Text;
                   cmnd = txtCMND.Text;
                   
                   ngaysinh = Convert.ToDateTime(dtpNgaySinh.Value);
                     ngayvaolam = Convert.ToDateTime(dtpNgayVaoLam.Value);
                    //hinh = ConvertImageToBinary(picImage.Image);
                   
                    if (nv.Add_NV(context, hoten,quequan, chucvu, cmnd, sdt, ngaysinh, ngayvaolam,hinh))
                    {
                        MessageBox.Show("Da them nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc them vao");
                }
                Load_NV();
                ClearInfo();
                clearTaiKhoanInfor();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Thêm Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void Load_NV()
        {
            pnlTaiKhoan.Enabled = false;
            btnSuaTK.Enabled = false;
            btnUpload.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            var nhanViens = (from nhanvien in context.NhanViens
                             select new
                             {
                                 nhanvien.HoTenNV,
                                 nhanvien.QueQuan,
                                 nhanvien.ChucVu,
                                 nhanvien.SDT_NV,
                                 nhanvien.CMND,
                                 nhanvien.NgaySinh,
                                 nhanvien.NgayVaoLam,
                                 nhanvien.NhanVienId
                             }).ToList();
            gcNhanVien.DataSource = nhanViens;
            gvNhanVien.Columns[0].Caption = "Họ tên";
            gvNhanVien.Columns[1].Caption = "Quê quán";
            gvNhanVien.Columns[2].Caption = "Chức vụ";
            gvNhanVien.Columns[3].Caption = "Số điện thoại";
            gvNhanVien.Columns[4].Caption = "CMND";
            gvNhanVien.Columns[5].Caption = "Ngày sinh";
            gvNhanVien.Columns[6].Caption = "Ngày vào làm";
            gvNhanVien.Columns[7].Visible = false;
         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên  này chứ!", "Xóa nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                   
                    cmnd = txtCMND.Text;
                    if (nv.Delete_NV(context,cmnd))
                    {
                       
                        MessageBox.Show("Da xoa nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc xoa vao");
                }
                Load_NV();
                ClearInfo();
                clearTaiKhoanInfor();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Xóa Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (picImage.Image == null)
            //{
            //    XtraMessageBox.Show("Bạn chưa UpLoad hình!");
            //    return;
            //}
            var contextt = new CaPheContext();
            if (txtHoTen.Text.Replace(" ", "") != "" && txtSDT.Text.Replace(" ", "") != "" && txtCMND.Text.Replace(" ", "") != "" && txtChucVu.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật nhân viên  này chứ!", "Cập nhật nhân viên ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[7]).ToString());
                    hoten = txtHoTen.Text;
                     quequan = txtQueQuan.Text;
                   chucvu = txtChucVu.Text;
                     sdt = txtSDT.Text;
                    cmnd = txtCMND.Text;
                    ngaysinh = Convert.ToDateTime(dtpNgaySinh.Value);
                   ngayvaolam = Convert.ToDateTime(dtpNgayVaoLam.Value);
                   // hinh = ConvertImageToBinary(picImage.Image);
                    if (nv.Update_NV(contextt,id, hoten,quequan, chucvu, cmnd, sdt, ngaysinh, ngayvaolam,hinh))
                    {
                        MessageBox.Show("Da cap nhat nhan vien");
                    }
                    else
                        MessageBox.Show("Nhan Vien chua duoc cap nhat vao");
                }
                Load_NV();
                ClearInfo();
                clearTaiKhoanInfor();
            }
            else
            {
                MessageBox.Show("Vui Long dien het thong tin", "Cập Nhật  Nhan vien", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void ClearInfo()
        {
            txtHoTen.EditValue = "";
            txtQueQuan.EditValue = "";
            txtChucVu.EditValue = "";
            txtSDT.EditValue ="";
            txtCMND.EditValue ="";
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayVaoLam.Value = DateTime.Now;
            clearTaiKhoanInfor();
            Load_NV();
        }
        #endregion
        private void gvNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.RowCount > 0)
            {
                clearTaiKhoanInfor();
                txtHoTen.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[0]).ToString();
                txtQueQuan.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[1]).ToString();
                txtChucVu.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[2]).ToString();
                txtSDT.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[3]).ToString();
                txtCMND.EditValue = gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[4]).ToString();
                dtpNgaySinh.Value = DateTime.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[5]).ToString());
                dtpNgayVaoLam.Value = DateTime.Parse(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[6]).ToString());
                //byte[] pic = (byte[])(gvNhanVien.GetRowCellValue(gvNhanVien.FocusedRowHandle, gvNhanVien.Columns[7]));
                //picImage.Image = ConvertBinaryToImage(pic);

                pnlTaiKhoan.Enabled = true;
                btnSuaTK.Enabled = true;
                btnXoa.Enabled =true;
                btnSua.Enabled = true;

               var taikhoanInfor = taiKhoan.GetTaiKhoan(nv.LayNhanVienIDbyCMND(context, txtCMND.Text));
                foreach (var item in taikhoanInfor)
                {
                    txtTenTaiKhoan.Text = item.username;
                    txtMatKhau.Text = item.password;
                   cbLoaiTaiKhoan.Text = item.LoaiTaiKhoan;
                }
            }              
        }

        #region TaiKhoan
        string TenTaiKhoan;
        string MatKhau;
        string LoaiTaiKhoan;
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.EditValue!=null&&txtMatKhau.EditValue!=null&&cbLoaiTaiKhoan.EditValue!=null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm tài khoản cho nhân viên  này chứ!", "Thêm tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    TenTaiKhoan = txtTenTaiKhoan.Text;
                    MatKhau = txtMatKhau.Text;
                    LoaiTaiKhoan = cbLoaiTaiKhoan.Text;
                    if (taiKhoan.ThemTaiKhoan(nv.LayNhanVienIDbyCMND(context,txtCMND.Text),TenTaiKhoan,MatKhau,LoaiTaiKhoan))
                    {
                        XtraMessageBox.Show("Đã thêm tài khoản");
                    }
                    else
                        XtraMessageBox.Show("Tài khoản đã tồn tại");
                }
                Load_NV();
                clearTaiKhoanInfor();
                ClearInfo();
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông thin", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.EditValue != null && txtMatKhau.EditValue != null && cbLoaiTaiKhoan.EditValue != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm tài khoản cho nhân viên  này chứ!", "Thêm tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    TenTaiKhoan = txtTenTaiKhoan.Text;
                    MatKhau = txtMatKhau.Text;
                    LoaiTaiKhoan = cbLoaiTaiKhoan.Text;
                    if (taiKhoan.SuaTaiKhoan(nv.LayNhanVienIDbyCMND(context, txtCMND.Text), TenTaiKhoan, MatKhau, LoaiTaiKhoan))
                    {
                        XtraMessageBox.Show("Đã sửa tài khoản");
                    }
                    
                }
                Load_NV();
                clearTaiKhoanInfor();
                ClearInfo();
            }
            else
            {
                MessageBox.Show("Vui lòng điền hết thông thin", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearTaiKhoanInfor()
        {
            txtTenTaiKhoan.Text ="";
            txtMatKhau.Text ="";
            cbLoaiTaiKhoan.Text = "";
        }



        #endregion

    
    }
}