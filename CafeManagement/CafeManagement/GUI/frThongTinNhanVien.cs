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
using System.IO;
using CafeManagement.GUI;

namespace CafeManagement
{
    public partial class frThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Query_NhanVien nhanVien = new Query_NhanVien();
        CaPheContext context = Global.context;
        public frThongTinNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void frThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
        void LoadNV()
        {
            NhanVien nv = new NhanVien();
            nv = nhanVien.GetNhanVien(context);
            txtHoTen.Text = nv.HoTenNV;
            txtChucVu.Text = nv.ChucVu;
            txtQueQuan.Text = nv.QueQuan;
            txtCMND.Text = nv.CMND;
            txtSDT.Text = nv.CMND;
            dtpNgaySinh.Value = nv.NgaySinh;
            dtpNgayVaoLam.Value = nv.NgayVaoLam;

            txtHoTen.Enabled = false;
            txtChucVu.Enabled = false;
            txtQueQuan.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgayVaoLam.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }
        byte[] ConvertImageToBinary(Image img)
        {


            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }


        }
        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            frChinhSuaNV fr = new frChinhSuaNV();
            fr.Show();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}