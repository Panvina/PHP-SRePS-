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
    public partial class frmDeleteSales : Form
    {
        public frmDeleteSales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate SaleID integer
        /// </summary>
        /// <param name="salesID">integer to validate</param>
        /// <returns>true if input integer is found in table</returns>
        public bool ValidateSaleID(int salesID)
        {
            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Sales WHERE SalesID = @salesID", frmLogin.con);
            command.Parameters.AddWithValue("@salesID", salesID);
            var res = (int)command.ExecuteScalar();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Event handler for exit button clicked
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        /// <summary>
        /// Event handler for delete button click
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbSales.Items.Count != 0)
			{
                int salesID = int.Parse(cmbSales.Text);

                // no need to validate salesID
                SqlCommand command = new SqlCommand($"DELETE FROM Sales WHERE SalesID = @salesID", frmLogin.con);
                command.Parameters.AddWithValue("@salesID", salesID);
                command.ExecuteNonQuery();

                cmbSales.Items.RemoveAt(cmbSales.SelectedIndex);
                
                if (cmbSales.Items.Count != 0)
				{
                    cmbSales.SelectedIndex = 0;
                }
                else
                {
                    cmbSales.Text = "";
                    txtProductID.Text = "";
                    txtProductName.Text = "";
                    txtQuantity.Text = "";
                    txtDate.Text = "";
                }
            }

            //if (ValidateSaleID(salesID))
            //{            
            //    SqlCommand command = new SqlCommand($"DELETE FROM Sales WHERE SalesID = @salesID", frmLogin.con);
            //    command.Parameters.AddWithValue("@salesID", salesID);
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Sale deleted");
            //}
            //else
            //{
            //    MessageBox.Show("Sale not found");
            //}
            
        }

		private void frmDeleteSales_Load(object sender, EventArgs e)
		{
            string query = "SELECT SalesID from Sales";
            SqlCommand cmd = new SqlCommand(query, frmLogin.con);

            using (SqlDataReader reader = cmd.ExecuteReader())
			{
                while(reader.Read())
				{
                    cmbSales.Items.Add($"{reader[0]}");
				}
			}

            if(cmbSales.Items.Count != 0)
			{
                cmbSales.SelectedIndex = 0;
            }
		}

		private void cmbSales_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (cmbSales.Items.Count != 0)
			{
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = frmLogin.con;

                string query = $"SELECT * FROM Sales WHERE SalesID = {cmbSales.Text}";
                cmd.CommandText = query;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    txtProductID.Text = $"{reader[1]}";
                    txtQuantity.Text = $"{reader[2]}";
                    txtDate.Text = DateTime.Parse($"{reader[3]}").ToString("dd/MM/yyyy");
                }

                query = $"SELECT * FROM Products WHERE ProductID = {txtProductID.Text}";
                cmd.CommandText = query;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    txtProductName.Text = $"{reader[1]}";
                }
            }
            else
			{
                txtProductID.Text = "";
                txtProductName.Text = "";
                txtQuantity.Text = "";
                txtDate.Text = "";
			}
        }
	}
}
