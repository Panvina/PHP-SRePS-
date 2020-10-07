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
            File.ReadAllLines(frmLogin.LowStockSettingFile);
            string homeOption = "false";
            string productListOption = "false";

            if (checkBoxNotifyHome.Checked)
            {
                homeOption = "true";
            }

            if (checkBoxNotifyProd.Checked)
            {
                productListOption = "true";
            }

                if (tbQuantity.Text != "")
                {
                    string[] write = { tbQuantity.Text, homeOption, productListOption };
                    File.WriteAllLines(frmLogin.LowStockSettingFile, write);

                    MessageBox.Show("Your settings have been saved!");
                } else
                {
                MessageBox.Show("Your input cannot be blank!");
                }
        }

        private void LowStockAlert_Load(object sender, EventArgs e)
        {
            string[] read = File.ReadAllLines(frmLogin.LowStockSettingFile);
            tbQuantity.Text = read[0];
            if (read[1] == "true")
            {
                checkBoxNotifyHome.Checked = true;
            }

            if (read[2] == "true")
            {
                checkBoxNotifyProd.Checked = true;
            }
        }
    }
}
