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
    public partial class frBan : DevExpress.XtraEditors.XtraForm
    {
        public frBan()
        {
            InitializeComponent();
        }

        private void frBan_Load(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Maximized;
            Load_Ban();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtBan.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm bàn này chứ!", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    int soBan = Convert.ToInt32(txtBan.Text);
                    var addBan = new Query_Ban();
                    using (CaPheContext caPheContext = new CaPheContext())
                    {
                        if (addBan.Add_Ban(soBan, caPheContext))
                        {
                            MessageBox.Show("Them ban thanh cong!");
                            Load_Ban();
                        }
                        else
                        {
                            MessageBox.Show("So ban da ton tai xin nhap so khac");
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Load_Ban()
        {
            var loadban = new Query_Ban();
            using (CaPheContext caPheContext = new CaPheContext())
            {
                if (loadban.DemSoLuongBan(caPheContext))
                {
                    MessageBox.Show("Khong co ban");
                }
                else
                {
                    gcBan.DataSource = loadban.load_Ban(caPheContext);
                    gvBan.Columns[0].Caption = "Mã số bàn";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtBan.Text.Replace(" ", "") != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bàn này chứ!", "Xóa bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                var Ban = new Query_Ban();
                int soBan = Convert.ToInt32(txtBan.Text);
                using (CaPheContext context = new CaPheContext())
                {
                    if (Ban.xoaBan(context, soBan))
                    {
                        MessageBox.Show("Da xoa Ban");

                        Load_Ban();
                    }
                    else
                    {
                        MessageBox.Show("Ban Khong ton tai");
                    }
                }
            }
            else MessageBox.Show("Bạn chưa nhập Số bàn!", "Xóa bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}