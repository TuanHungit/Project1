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

namespace Cafe_Management.GUI
{
    public partial class frManage : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();

        public frManage()
        {
            InitializeComponent();
        }

        private void frManage_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            currentClickButton = null;
            btnMergeTable.Enabled = false;
            btnChangeTable.Enabled = false;


            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}