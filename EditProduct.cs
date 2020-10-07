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
    public partial class EditProduct : Form
    {
        private SqlConnection connection;

        private int SupplierIndex
        {
            get
            {
                return 0;
            }
        }


        public EditProduct()
        {
            InitializeComponent();
            connection = new SqlConnection(frmLogin.conString);
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            string productQuery = "SELECT ProductID from Products";
            string supplierQuery = "SELECT SupplierID, CompanyName FROM Suppliers";

            //Open connection and begin transaction
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            //Handle product query, update product data.
            SqlCommand productCommand = new SqlCommand(productQuery, connection, transaction);
            using (SqlDataReader productReader = productCommand.ExecuteReader())
            {
                while (productReader.Read())
                {
                    cmbProductID.Items.Add(productReader[0].ToString());
                }
            }

            //Handle supplier query, update supplier data.
            SqlCommand supplierCommand = new SqlCommand(supplierQuery, connection, transaction);
            using (SqlDataReader supplierReader = supplierCommand.ExecuteReader())
            {
                while(supplierReader.Read())
                {
                    cmbSupplierID.Items.Add($"{supplierReader[1]}, {supplierReader[0]}");
                }
            }

            //Commit transaction and close connection.
            transaction.Commit();
            connection.Close();
            HideErrorLabels();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            connection.Open();

            //Gets sales data for specific sales ID.
            string query = $"SELECT ProductName, SupplierID, Price, UnitsInStock, UnitsOnOrder, Category FROM Products WHERE Products.ProductID={cmb.SelectedItem}";

            //Update textboxes to match Sales data.
            SqlCommand command = new SqlCommand(query, connection);
            command.Transaction = connection.BeginTransaction();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtProductName.Text = reader[0].ToString();
                    //cmbSupplierID.selecteDI.Text = reader[1].ToString();
                    int supplierIndex = GetSupplierIndex(reader[1].ToString());

                    if(supplierIndex != -1)
                    {
                        cmbSupplierID.SelectedIndex = supplierIndex;
                    }

                    txtPrice.Text = reader[2].ToString();
                    txtUnitsInStock.Text = reader[3].ToString();
                    txtUnitsOnOrder.Text = reader[4].ToString();
                    txtCategory.Text = reader[5].ToString();
                }
            }

            command.Transaction.Commit();
            connection.Close();
            HideErrorLabels();
        }


        //Gets the supplier ID and returns the index position in the dropdownlist. Returns -1 if non-existant.
        private int GetSupplierIndex(string id)
        {
            for (int i = 0; i < cmbSupplierID.Items.Count; i++)
            {
                var supplierIDBox = cmbSupplierID.Items[i];

                string supplierIDString = supplierIDBox.ToString().Split(',')[1].Trim();

                Console.WriteLine($"Testing {id} : {supplierIDString}");

                if (supplierIDString.Equals(id))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool ValidateInputs()
        {
            return ValidateProductName() && ValidatePrice() && ValidateUnitsInStock() && ValidateUnitsOnOrder();
        }

        private bool ValidateProductName()
        {
            if(string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                lblProductNameError.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidatePrice()
        {
            float price;

            if(!float.TryParse(txtPrice.Text, out price))
            {
                lblPriceError.Visible = true;
                return false;
            }

            if(price < 0)
            {
                lblPriceError.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidateUnitsInStock()
        {
            int units;

            if (!int.TryParse(txtUnitsInStock.Text, out units))
            {
                lblUnitsInStockError.Visible = true;
                return false;
            }

            if(units < 0)
            {
                lblUnitsInStockError.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidateUnitsOnOrder()
        {
            int units;

            if (!int.TryParse(txtUnitsOnOrder.Text, out units))
            {
                txtUnitsOnOrder.Visible = true;
                return false;
            }

            if (units < 0)
            {
                lblUnitsInStockError.Visible = true;
                return false;
            }

            return true;
        }

        private void HideErrorLabels()
        {
            lblProductNameError.Visible = false;
            lblPriceError.Visible = false;
            lblUnitsInStockError.Visible = false;
            lblUnitsOnOrderError.Visible = false;
            lblRecordResult.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                string productID = cmbProductID.SelectedItem.ToString();
                string productName = txtProductName.Text;
                float price = float.Parse(txtPrice.Text);
                int unitsInStock = int.Parse(txtUnitsInStock.Text);
                int unitsOnOrder = int.Parse(txtUnitsOnOrder.Text);
                string category = txtCategory.Text;
                if(category == "")
                {
                    category = null;
                }

                string supplierID = cmbSupplierID.SelectedItem != null ? cmbSupplierID.SelectedItem.ToString().Split(',')[1].Trim() : "";

                string query = $"UPDATE Products SET ProductName='{productName}', SupplierID='{supplierID}', Price='{price}', UnitsInStock='{unitsInStock}', UnitsOnOrder='{unitsOnOrder}', Category='{category}' " +
                    $"WHERE ProductID={productID}";

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Transaction = connection.BeginTransaction();

                int rowsAffected = command.ExecuteNonQuery();

                lblRecordResult.Text = $"Success! {rowsAffected} records affected.";
                lblRecordResult.Visible = true;

                command.Transaction.Commit();
                connection.Close();
            }
        }
    }
}
