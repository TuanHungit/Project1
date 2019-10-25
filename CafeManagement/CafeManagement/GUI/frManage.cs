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
    public partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        public frManage()
        {
            InitializeComponent();
        }
        CaPheContext caPheContext = new CaPheContext();
       
        private void frManage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_Table();
            Load_cbDanhMuc();
          
        }
        Ban ban = new Ban();
        Query_DanhMuc danhMuc = new Query_DanhMuc();
        
        private void Load_Table() 
        {
            panelListTable.Controls.Clear();
            List<Ban> danhsachban = ban.GetAllTable();
            foreach (Ban item in danhsachban)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.BanId.ToString();
                button.ImageOptions.Image = System.Drawing.Bitmap.FromFile(@"C:\Users\hung1\OneDrive\Documents\GitHub\Project1\CafeManagement\CafeManagement\Resources\Household-Table-icon.png");
                button.ImageOptions.Location = ImageLocation.TopCenter;
                panelListTable.Controls.Add(button);
               
            }
        }
        private void Load_cbDanhMuc()
        {
           cbDanhMuc.Properties.DataSource = (from item in caPheContext.LoaiSanPhams
                                                select new { item.TenLoaiSanPham, item.LoaiSanPhamId }).ToList();
           cbDanhMuc.Properties.DisplayMember = "TenLoaiSanPham";
           cbDanhMuc.Properties.ValueMember = "LoaiSanPhamId";
        }
        private void Load_cbSanPham(int DanhmucID)
        {

            if (cbDanhMuc.Text != "-- Chọn danh mục --")
            {
                cbSanPham.Properties.DataSource = (from item in caPheContext.SanPhams
                                                   where item.LoaiSanPhamId.Equals(DanhmucID)
                                                   select new { item.SanPhamId, item.TenSanPham, item.DonGia }).ToList();
                cbSanPham.Properties.DisplayMember = "TenSanPham";
                cbSanPham.Properties.ValueMember = "SanPhamId";
            }
        }

        private void cbDanhMuc_EditValueChanged_1(object sender, EventArgs e)
        {
            int DanhMucID = int.Parse(cbDanhMuc.EditValue.ToString());
            Load_cbSanPham(DanhMucID);
        }
    }
}