using CafeManagement.Data;
using CafeManagement.LinQ;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class frBan : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frBan()
        {
            InitializeComponent();
        }
        CaPheContext context = Global.context;
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtBanID.EditValue != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm bàn này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    int soBan = Convert.ToInt32(txtBanID.EditValue);
                    var addBan = new Query_Ban();
                  
                        if (addBan.Add_Ban(soBan))
                        {
                            MessageBox.Show("Thêm bàn thành công!");
                            Load_Ban();
                        }
                        else
                        {
                            MessageBox.Show("Số bàn đã tồn tại xin nhập số khác!");
                        }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void frBan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Load_Ban();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

            if (txtBanID.EditValue != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bàn này chứ!", "Xóa bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var Ban = new Query_Ban();
                int soBan = Convert.ToInt32(txtBanID.EditValue);
            
                    if (Ban.xoaBan( soBan))
                    {
                        XtraMessageBox.Show("Đã xóa bàn!");

                        Load_Ban();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bàn không tồn tại!");
                   }
                
            }
            else MessageBox.Show("Bạn chưa nhập Số bàn!", "Xóa bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Load_Ban()
        {
            var loadban = new Query_Ban();
           
                if (loadban.DemSoLuongBan())
                {
                    XtraMessageBox.Show("Không có bàn");
                }
                else
                {
                    gcBan.DataSource = (from item in context.Bans
                                        select new { item.BanId, item.TinhTrang }).ToList();
                    gvBan.Columns[0].Caption = "Mã số bàn";
                    gvBan.Columns[1].Caption = "Tình trạng";
                }
            
        }

        
    }
}
