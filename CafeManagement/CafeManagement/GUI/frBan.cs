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
            this.FormBorderStyle = FormBorderStyle.None;
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
                    using (CaPheContext caPheContext = new CaPheContext())
                    {
                        Ban ban = new Ban()
                        {
                            BanId = Convert.ToInt16(txtBan.Text)
                        };
                        caPheContext.Bans.Add(ban);
                        caPheContext.SaveChanges();
                        Load_Ban();
                    }
                }
            }
            else {
                MessageBox.Show("Bạn chưa nhập Số bàn!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Load_Ban()
        {
            using (CaPheContext caPheContext = new CaPheContext()) {
                gcBan.DataSource = (from Ban in caPheContext.Bans
                            select new { Số_Bàn = Ban.BanId }).ToList();
                 
            }        
        }
    }
}