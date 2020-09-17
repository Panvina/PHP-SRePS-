using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PHP
{
    public partial class AddSales : Form
    {
        public AddSales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for exit button clicked
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        /// <summary>
        /// Validate inputs (date and quantity)
        /// </summary>
        /// <returns>true if inputs valid</returns>
        public bool ValidateInputs()
		{
            return (ValidateDate(txtDate.Text) && ValidateQuantity(txtQuantity.Text));
		}

        /// <summary>
        /// Validates date input in textbox
        /// </summary>
        /// <param name="dateStr">String to validate</param>
        /// <returns>true if input string is valid date</returns>
        public bool ValidateDate(string dateStr)
		{
            DateTime date = default;

            // Validate that date format is valid
            if (!DateTime.TryParseExact(dateStr, "yyyy-mm-dd", CultureInfo.GetCultureInfo("en-US").DateTimeFormat, DateTimeStyles.None, out date))
			{
                // parse failed.
                lblDateError.Visible = true;
                return false;
			}

            // validate that date can be parsed to SQL DateTime type
            try
			{
                System.Data.SqlTypes.SqlDateTime dtSql = System.Data.SqlTypes.SqlDateTime.Parse(date.ToString("yyyy-mm-dd"));
            }
            catch (System.FormatException e)
			{
                lblDateError.Visible = true;
                return false;
            }
            catch (System.Data.SqlTypes.SqlTypeException e)
			{
                lblDateError.Visible = true;
                return false;
            }

            // remove error message
            lblDateError.Visible = false;

            return true;
		}

        /// <summary>
        /// Validate quantity string
        /// </summary>
        /// <param name="quant">string to validate</param>
        /// <returns>true if input string valid quantity</returns>
        public bool ValidateQuantity(string quant)
		{
            int intQuant = default;

            // ensure input can be converted to int
            if (!int.TryParse(quant, out intQuant))
			{
                lblQuantityError.Visible = true;
                return false;
			}
            
            // ensure positive integer
            if (intQuant <= 0)
			{
                lblQuantityError.Visible = true;
                return false;
            }

            // hide error message
            lblQuantityError.Visible = false;

            return true;
        }

        /// <summary>
        /// Event handler for form load
        /// </summary>
		private void AddSales_Load(object sender, EventArgs e)
		{
            // load in combo box option for product ID.
            string query = "SELECT productID, productName FROM products";

            SqlCommand command = new SqlCommand(query, Login.con);

            using (SqlDataReader reader = command.ExecuteReader())
			{
                while(reader.Read())
				{
                    cmbProductID.Items.Add($"{reader[1]}, {reader[0]}");
				}
			}

            cmbProductID.SelectedIndex = 0;
		}

        /// <summary>
        /// Event handler for submit button click
        /// </summary>
		private void btnSubmit_Click(object sender, EventArgs e)
		{
            // hide output from DB
            lblRowsAffected.Visible = false;

            if (ValidateInputs())
			{
                // add sales record to table
                string prodID = cmbProductID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[1];
                int quant = int.Parse(txtQuantity.Text);
                string date = txtDate.Text;

                string query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quant}, '{date}')";
                SqlCommand command = new SqlCommand(query, Login.con);
                lblRowsAffected.Text = $"{command.ExecuteNonQuery()} affected rows.";

                lblRowsAffected.Visible = true;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateError_Click(object sender, EventArgs e)
        {

        }
    }
}
