using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Media;
using System.Windows.Forms;

namespace PHP
{
    public partial class frmAddSales : Form
    {
        public frmAddSales()
        {
            InitializeComponent();
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
        /// Validate inputs (date and quantity)
        /// </summary>
        /// <returns>true if inputs valid</returns>
        public bool ValidateInputs()
		{
            return (/*ValidateDate(txtDate.Text) && */ValidateQuantity(txtQuantity.Text));
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
            if (!VerifyPositive(intQuant))
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
            // select custom date format for date time picker
            dtpDate.CustomFormat = "yyyy-MM-dd";

            // load in combo box option for product ID.
            string query = "SELECT productID, productName FROM products";

            SqlCommand command = new SqlCommand(query, frmLogin.con);

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
                string date = dtpDate.Text;

                string query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quant}, '{date}')";
                SqlCommand command = new SqlCommand(query, frmLogin.con);
                lblRowsAffected.Text = $"{command.ExecuteNonQuery()} affected rows.";

                lblRowsAffected.Visible = true;

                UpdateInventory();
                SystemSounds.Asterisk.Play();

                // reset quantity. Prevent multiple entries accidentally.
                txtQuantity.Text = "0";
                lblQuantityError.Visible = false;
            }
        }

        /// <summary>
        /// Update inventory table's units in stock
        /// </summary>
        private void UpdateInventory()
		{
            string quant = txtQuantity.Text;
            string prodID = cmbProductID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[1];

            string query = $"UPDATE Products SET UnitsInStock = UnitsInStock - {quant} WHERE ProductID = {prodID}";
            SqlCommand command = new SqlCommand(query, frmLogin.con);
            command.ExecuteNonQuery();

            int unitInStock = GetUnitsInStock(prodID);

            if (unitInStock < GetMin(prodID))
			{
                //Let the user know they run out of stock.
                MessageBox.Show("PRODUCT OUT OF STOCK! Ordering more...");

                Reorder(prodID);
			}
		}

        /// <summary>
        /// Event handler for quantity text changed
        /// </summary>
		private void txtQuantity_TextChanged(object sender, EventArgs e)
		{
            lblQuantityError.Visible = !ValidateQuantity(txtQuantity.Text);
		}

        /// <summary>
        /// Reorder stock for a given product with some ID
        /// 
        /// Placeholder. This system will never order real stock, so
        /// placeholder functions will be in place, and stock will
        /// be incremented by some number.
        /// </summary>
        /// <param name="prodID"></param>
        private void Reorder(string prodID)
		{
            ContactSupplier();
            AddStock(prodID, GetReorderQuantity(prodID));
		}

        private void ContactSupplier()
        { }

        /// <summary>
        /// Add stock to some product
        /// </summary>
        /// <param name="prodID">product ID</param>
        /// <param name="quant">quantity to add</param>
        private void AddStock(string prodID, int quant)
		{
            if (!VerifyPositive(quant))
			{
                MessageBox.Show($"{quant} is not a positive integer.\nOrdered stock must be >= 0.");
                return;
			}

            string query = $"UPDATE Products SET UnitsInStock = UnitsInStock + {quant} WHERE ProductID = {prodID}";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = frmLogin.con;
            cmd.CommandText = query;

            int success = cmd.ExecuteNonQuery();

            if (success == 1)
			{
                MessageBox.Show($"{quant} items have been ordered for {prodID}");
			}
		}

        /// <summary>
        /// Verifies that some value is positive
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private bool VerifyPositive(int val)
		{
            return (val >= 0);
		}

        /// <summary>
        /// Determines the amount to reorder
        /// </summary>
        /// <param name="ProdID">Product ID</param>
        /// <returns>Amount to reorder</returns>
        private int GetReorderQuantity(string ProdID)
		{
            int unitsInStock = GetUnitsInStock(ProdID);
            int maxProducts = GetMax(ProdID);
            
            return maxProducts - unitsInStock;

		}

        /// <summary>
        /// Determine minimum stock threshold for product
        /// 
        /// Placeholder
        /// </summary>
        /// <param name="ProdID">Product ID</param>
        /// <returns>Minimum stock threshold</returns>
        private int GetMin(string ProdID)
		{
            string query = $"SELECT MinProducts FROM Products WHERE ProductID ='{ProdID}'";

            SqlCommand command = new SqlCommand(query, frmLogin.con);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int min = int.Parse(reader[0].ToString());
                    return min;
                }
            }
            return 0;
		}

        /// <summary>
        /// Determines the maximum stock threshold for pre-ordering stock.
        /// </summary>
        /// <param name="ProdID">Product ID</param>
        /// <returns>Maximum stock threshold</returns>
        private int GetMax(string ProdID)
        {
            string query = $"SELECT MaxProducts FROM Products WHERE ProductID ='{ProdID}'";

            SqlCommand command = new SqlCommand(query, frmLogin.con);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int max = int.Parse(reader[0].ToString());
                    return max;
                }
            }

            return 0;
        }

        private int GetUnitsInStock(string ProdID)
        {
            string query = $"SELECT UnitsInStock FROM Products WHERE ProductID ='{ProdID}'";

            SqlCommand command = new SqlCommand(query, frmLogin.con);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int unitsInStock = int.Parse(reader[0].ToString());
                    return unitsInStock;
                }
            }
            return 0;
        }
    }
}
