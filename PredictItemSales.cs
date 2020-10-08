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
    public partial class PredictItemSales : Form
    {
        private SqlConnection connection;

        public PredictItemSales()
        {
            InitializeComponent();
            connection = new SqlConnection(frmLogin.conString);
        }

        private void PredictItemSales_Load(object sender, EventArgs e)
        {
            string productQuery = "SELECT ProductID from Products";


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


            //Commit transaction and close connection.
            transaction.Commit();
            connection.Close();

        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void lblInvalidYear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateProductID()
        {
            int Month;

            if (!int.TryParse(txtMonth.Text, out Month))
            {
                lblMonth.Visible = true;
                return false;
            }

            if (Month > 12)
            {
                lblMonth.Visible = true;
                return false;
            }

            return true;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            lblMonthError.Visible = true;
            lblInvalidYear.Visible = true;
            int Month, Year;
            // validate inputs
            if (int.TryParse(txtMonth.Text, out Month))
            {
                if ((Month >= 1) && (Month <= 12))
                {
                    lblMonthError.Visible = false;
                }
            }

            if (int.TryParse(txtYear.Text, out Year))
            {
                if ((Year >= 1753) && (Year <= 9999))
                {
                    lblInvalidYear.Visible = false;
                }
            }

            if ((lblInvalidYear.Visible == true) || (lblMonthError.Visible == true))
            {
                return;
            }





            string productID = cmbProductID.SelectedItem.ToString();
            string productName = txtProductName.Text;
            double productPrice = Convert.ToDouble(txtPrice.Text);
            int sumQuantity;
            
            string predictQuery = $"SELECT SUM(Quantity) FROM SALES WHERE MONTH(DATE) = {txtMonth.Text} AND YEAR(DATE) = {txtYear.Text}";

            double previousSales = 0;

            //Open connection and begin transaction
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            //Handle product query, update product data.
            SqlCommand productCommand = new SqlCommand(predictQuery, connection, transaction);
            object DBNULLCheck = productCommand.ExecuteScalar();

            if (DBNULLCheck != null && DBNULLCheck != DBNull.Value)
            {
                sumQuantity = (int)productCommand.ExecuteScalar();

                if (sumQuantity != 0)
                {
                    previousSales = productPrice * sumQuantity;
                }
            }
            else
            {
                MessageBox.Show("There is no sales for that item this month");
            }
                  
            txtPredictedSale.Text = previousSales.ToString();

            //Commit transaction and close connection.
            transaction.Commit();
            connection.Close();

        }

        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPriceError_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            connection.Open();

            //Gets sales data for specific sales ID.
            string query = $"SELECT ProductName, Price FROM Products WHERE ProductID={cmb.SelectedItem}";

            //Update textboxes to match Sales data.
            SqlCommand command = new SqlCommand(query, connection);
            command.Transaction = connection.BeginTransaction();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtProductName.Text = reader[0].ToString();
                    //cmbSupplierID.selecteDI.Text = reader[1].ToString();
                    
                    txtPrice.Text = reader[1].ToString();
                                     
                }
            }

            command.Transaction.Commit();
            connection.Close();
        
        }

        
    }
}
