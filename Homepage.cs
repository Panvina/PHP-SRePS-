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
    public partial class frmHomepage : Form
    {

        public frmHomepage()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductList pl = new ProductList();
            pl.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.con.Close();
            Application.Exit();
        }

        private void addSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSales addSales = new frmAddSales();
            addSales.Show();
        }

        private void deleteSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteSales deleteSales = new frmDeleteSales();
            deleteSales.Show();
        }

        private void editSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditSales editSales = new frmEditSales();
            editSales.Show();
        }

        private void displaySales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDisplaySales displaySales = new frmDisplaySales();
            displaySales.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAllSales s = new frmAllSales();
            frmLogin.con.Close();
            frmLogin.con.Open();
            s.UpdateTable();
            s.Show();
        }

        private void btnDisplayMonthlySales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDisplayMonthlySales d = new frmDisplayMonthlySales();
            frmLogin.con.Close();
            frmLogin.con.Open();
            d.Show();
        }

        private void btnDisplayYearlySales_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDisplayYearlySales d = new frmDisplayYearlySales();
            frmLogin.con.Close();
            frmLogin.con.Open();
            d.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct d = new AddProduct();
            frmLogin.con.Close();
            frmLogin.con.Open();
            d.Show();
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduct d = new EditProduct();
            frmLogin.con.Close();
            frmLogin.con.Open();
            d.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProduct d = new DeleteProduct();
            frmLogin.con.Close();
            frmLogin.con.Open();
            d.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSuppliers addSupplier = new frmAddSuppliers();
            addSupplier.Show();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditSuppliers editSupplier = new frmEditSuppliers();
            editSupplier.Show();
        }

        private void btnDisplaySupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDisplaySuppliers displaySupplier = new frmDisplaySuppliers();
            displaySupplier.Show();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteSuppliers deleteSupplier = new frmDeleteSuppliers();
            deleteSupplier.Show();
        }
    }
}
