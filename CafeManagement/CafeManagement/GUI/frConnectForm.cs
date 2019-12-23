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
using System.Configuration;
using CafeManagement.GUI;
using System.Data.SqlClient;
using CafeManagement.Data;
using System.Data.Entity.Core.EntityClient;

namespace CafeManagement.GUI
{
    public partial class frConnectForm : DevExpress.XtraEditors.XtraForm
    {
        public frConnectForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Global.connect = textBox1.Text;
            CaPheContext context = new CaPheContext(Global.connect);
            using (SqlConnection cnn = new SqlConnection(Global.connectionstring))
            {
                try
                {
                    cnn.Open();
                    frLogin fr = new frLogin();
                    fr.ShowDialog();
                    this.Close();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối đến Server! ");
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}