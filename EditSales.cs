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
    public partial class EditSales : Form
    {

        public EditSales()
        {
            InitializeComponent();
        }

        private void EditSales_Load(object sender, EventArgs e)
        {
            //Gets all sales IDs from sales table.
            string query = "SELECT SalesID from Sales";

            SqlCommand command = new SqlCommand(query, Login.con);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbSalesID.Items.Add(reader[0].ToString());
                }
            }

            HideErrorLabels();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            Homepage home = new Homepage();
            home.Show();
        }

        private void cmbSalesID_IndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            //Gets sales data for specific sales ID.
            string query = $"SELECT ProductID, Quantity, Date from Sales WHERE SalesID={cmb.SelectedItem}";

            //Update textboxes to match Sales data.
            SqlCommand command = new SqlCommand(query, Login.con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtProductID.Text = reader[0].ToString();
                    txtQuantity.Text = reader[1].ToString();
                    tpDate.Value = Convert.ToDateTime(reader[2]);
                }
            }

            HideErrorLabels();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                int productID = int.Parse(txtProductID.Text);
                int quantity = int.Parse(txtQuantity.Text);

                string date = tpDate.Value.ToString("yyyy-MM-dd");

                string query = $"UPDATE Sales SET ProductID={productID}, quantity={quantity}, Date='{date}' WHERE SalesID={cmbSalesID.SelectedItem}";

                SqlCommand command = new SqlCommand(query, Login.con);
                int rowsAffected = command.ExecuteNonQuery();

                lblRecordResult.Text = $"Success! {rowsAffected} records affected.";
                lblRecordResult.Visible = true;

            }
        }


        private bool ValidateInputs()
        {
            return ValidateProductID() && ValidateQuantity();
        }

        private bool ValidateProductID()
        {
            int productID;

            if(!int.TryParse(txtProductID.Text, out productID))
            {
                lblProductIDError.Visible = true;
                return false;
            }

            if(productID <= 0)
            {
                lblProductIDError.Visible = true;
                return false;
            }

            //Check to see if the product ID exists in the database.
            string query = $"SELECT Count(*) from Products WHERE ProductID={productID}";
            SqlCommand command = new SqlCommand(query, Login.con);
            int rowCount = (int) command.ExecuteScalar();
            if(rowCount <= 0)
            {
                lblProductIDError.Visible = true;
                return false;
            }

            return true;
        }

        private bool ValidateQuantity()
        {
            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                lblQuantityError.Visible = true;
                return false;
            }

            if (quantity <= 0)
            {
                lblQuantityError.Visible = true;
                return false;
            }

            return true;
        }

        private void HideErrorLabels()
        {
            lblProductIDError.Visible = false;
            lblQuantityError.Visible = false;
            lblRecordResult.Visible = false;
        }
    }
}
