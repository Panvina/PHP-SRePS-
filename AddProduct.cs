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
            try
            {
                int proID = int.Parse(txtProductID.Text);
                string proName = txtProductName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string supID = cmbSupplierID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[1];
                int uIS = int.Parse(txtUnitsInStock.Text);
                int uOO = int.Parse(txtUnitsOnOrder.Text);

                string prodQuery = $"INSERT INTO Products (ProductID, ProductName, SupplierID, Price) VALUES ({proID},{proName},{supID},{price})";
                string invQuery = $"INSERT INTO Products (ProductID, UnitsInStock, UnitsOnOrder) VALUES ({proID},{uIS},{uOO})";

                SqlCommand command = new SqlCommand(prodQuery, frmLogin.con);
                int success = command.ExecuteNonQuery();
                if (success == 1)
                {
                    MessageBox.Show("The product has been added.");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                // Not updated
            }
        }

        private void cmbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {            
            string query = "SELECT SupplierID, CompanyName FROM Suppliers";

            SqlCommand command = new SqlCommand(query, frmLogin.con);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbSupplierID.Items.Add($"{reader[1]}, {reader[0]}");
                }
            }

            cmbSupplierID.SelectedIndex = 0;

        }
    }
}
