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
    public partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        public frManage()
        {
            InitializeComponent();
        }

        private void frManage_Load(object sender, EventArgs e)
        {
       
    
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Load_Table();

        }
        Ban ban = new Ban();
        
        private void Load_Table() 
        {
            panelListTable.Controls.Clear();
            List<Ban> danhsachban = ban.GetAllTable();
            foreach (Ban item in danhsachban)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.BanId.ToString();
                panelListTable.Controls.Add(button);
                
            }
        
        }
    }
}