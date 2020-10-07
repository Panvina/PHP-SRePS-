using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    int proID = int.Parse(txtProductID.Text);
                    string proName = txtProductName.Text;
                    decimal price = decimal.Parse(txtPrice.Text);
                    string supID = cmbSupplierID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[0];
                    string catID = cmbCategoryID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[0];
                    int uIS = int.Parse(txtUnitsInStock.Text);
                    int uOO = int.Parse(txtUnitsOnOrder.Text);

                    string prodQuery = "INSERT INTO Products values ('"
                        + proID + "','" + proName + "','" + supID + "','" + price + "','" + uIS + "','" + uOO+ "','" + catID +"')";

                    SqlCommand command = new SqlCommand(prodQuery, frmLogin.con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The product has been added.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " please try again!");

                }
            }

        }

        private void cmbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string supQuery = "SELECT SupplierID, CompanyName FROM Suppliers";
            string catQuery = "SELECT categoryID, catName FROM Category";
            loadData(supQuery, cmbSupplierID);
            loadData(catQuery, cmbCategoryID);
        }

        private void loadData(string query, ComboBox cb)
        {
            SqlCommand command = new SqlCommand(query, frmLogin.con);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    cb.Items.Add($"{reader[0]}, {reader[1]}");
                }
            }
            cb.SelectedIndex = 0;
            reader.Close();
        }
        
        private void errorProName_validating(object sender, CancelEventArgs e)
        {
            blankValidating(errorProName, txtProductName, e, "Product Name");
        }

        private void errorProID_validating(object sender, CancelEventArgs e)
        {
            blankValidating(errorProdID, txtProductID, e, "ProductID");
        }

        private void errorPrice_validating(object sender, CancelEventArgs e)
        {
            blankValidating(errorPrice, txtPrice, e, "Price");
        }

        private void errorUIS_validating(object sender, CancelEventArgs e)
        {
            blankValidating(errorUIS, txtUnitsInStock, e, "Units In Stock");
        }

        private void errorUOO_validating(object sender, CancelEventArgs e)
        {
            blankValidating(errorUOO, txtUnitsOnOrder, e, "Units On Order");
        }

        private void blankValidating(ErrorProvider ep, TextBox tb, CancelEventArgs e, string errorText)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                tb.Focus();
                ep.SetError(tb, errorText + " cannot be left blank!");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(tb, "");
            }
        }
        
    }
}
