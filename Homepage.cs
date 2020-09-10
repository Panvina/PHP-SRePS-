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
            Application.Exit();
        }

        private void addSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSales addSales = new AddSales();
            addSales.Show();
        }

        private void deleteSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteSales deleteSales = new DeleteSales();
            deleteSales.Show();
        }

        private void editSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSales editSales = new EditSales();
            editSales.Show();
        }

        private void displaySales_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplaySales displaySales = new DisplaySales();
            displaySales.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllSales s = new AllSales();
            s.Show();
        }
    }
}
