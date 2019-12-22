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
namespace CafeManagement.GUI
{
    public partial class frConnectForm : DevExpress.XtraEditors.XtraForm
    {
        public frConnectForm()
        {
            InitializeComponent();
        }
        private void Input()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                changeConnectionSettings(textBox1.Text);

                   frLogin login = new frLogin();
                login.ShowDialog();
            }
            catch(Exception E)
            {
                XtraMessageBox.Show(E.Message);
            }

        }
        private String changeConnStringItem(string connString, string option, string value)
        {
            String[] conItems = connString.Split(';');
            String result = "";
            foreach (String item in conItems)
            {
                if (item.StartsWith(option))
                {
                    result += option + "=" + value + ";";
                }
                else
                {
                    result += item + ";";
                }
            }
            return result;
        }
        private void changeConnectionSettings(string datasource)
        {
            var cnSection = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            String connString = cnSection.ConnectionStrings.ConnectionStrings["connectionString"].ConnectionString;
            connString = changeConnStringItem(connString, "provider connection string=\"data source", datasource);
            
            cnSection.ConnectionStrings.ConnectionStrings["connectionString"].ConnectionString = connString;
            cnSection.Save();
            ConfigurationManager.RefreshSection("connectionString");
        }
    }
}