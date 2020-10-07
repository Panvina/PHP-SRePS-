using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class LowStockAlert : Form
    {
        public LowStockAlert()
        {
            InitializeComponent();
        }

        private void btnBackToHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.ReadAllLines(frmHomepage.LowStockSettingFile);
            string homeOption = "false";
            string productListOption = "false";
            string noNotif = "false";

            if (checkBoxNotifyHome.Checked)
            {
                homeOption = "true";
            }

            if (checkBoxNotifyProd.Checked)
            {
                productListOption = "true";
            }

            if (checkBoxNoNotify.Checked)
            {
                noNotif = "true";
            }
            string[] write = { tbQuantity.Text, homeOption, productListOption, noNotif};
            File.WriteAllLines(frmHomepage.LowStockSettingFile, write);
            
            MessageBox.Show("Your settings have been saved!");
        }

        private void LowStockAlert_Load(object sender, EventArgs e)
        {
            string[] read = File.ReadAllLines(frmHomepage.LowStockSettingFile);
            tbQuantity.Text = read[0];
            if (read[1] == "true")
            {
                checkBoxNotifyHome.Checked = true;
            }

            if (read[2] == "true")
            {
                checkBoxNotifyProd.Checked = true;
            }

            if (read[3] == "true")
            {
                checkBoxNoNotify.Checked = true;
            }
        }
    }
}
