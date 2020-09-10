using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHP
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryList pl = new InventoryList();
            pl.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAllSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Sales s = new All_Sales();
            s.Show();
        }
    }
}
