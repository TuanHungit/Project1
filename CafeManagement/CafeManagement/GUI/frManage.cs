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
using System.Data.Linq;
using DevExpress.SpreadsheetSource.Implementation;
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
        private SimpleButton currentClickButton = new SimpleButton();
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
                button.Tag = item;
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

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            Ban table = lsvBill.Tag as Ban;
            Query_HoaDon hoaDon = new Query_HoaDon();
           
            if (table == null)
            {
                XtraMessageBox.Show("Xin hãy chọn bàn!");
                return;
            }
            if (spSoLuong.Value == 0)
                return;
            int soluong = (int)spSoLuong.Value;
            int HoaDonID = hoaDon.LayHoaDonChuaThanhToan(table.BanId);
            if (cbSanPham.EditValue == null)
            {
                XtraMessageBox.Show("Xin hãy chọn món!");
                return;
            }
            if (HoaDonID == 0)
            { 
                
            }
            
        }
        void btn_Click(object sender, EventArgs e)
        {
          //  if ((sender as SimpleButton) != currentClickButton)
          //  {
          //      if (currentClickButton != null)
          //      {
          //          if ((currentClickButton.Tag as Ban).TinhTrang == "Có người")
          //              currentClickButton.ImageIndex = 0;
          //          else
          //              currentClickButton.ImageIndex = -1;
          //      }
          //  }

          //(sender as SimpleButton).ImageIndex = 1;
          //  int tableID = ((sender as SimpleButton).Tag as Ban).BanId;
          //  lsvBill.Tag = (sender as SimpleButton).Tag;
            
          //  currentClickButton = sender as SimpleButton;
          //  btnChangeTable.Enabled = true;
          //  btnMergeTable.Enabled = true;
        }
    }
}