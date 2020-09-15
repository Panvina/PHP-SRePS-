using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class AddSales : Form
    {
        public AddSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        public bool ValidateInputs()
		{
            return (ValidateDate(txtDate.Text) && ValidateQuantity(txtQuantity.Text));
		}

        public bool ValidateDate(string dateStr)
		{
            DateTime date = default;

            if (!DateTime.TryParseExact(dateStr, "yyyy-mm-dd", CultureInfo.GetCultureInfo("en-US").DateTimeFormat, DateTimeStyles.None, out date))
			{
                // parse failed.
                lblDateError.Visible = true;
                return false;
			}

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

            lblDateError.Visible = false;

            return true;
		}

        public bool ValidateQuantity(string quant)
		{
            int intQuant = default;

            if (!int.TryParse(quant, out intQuant))
			{
                lblQuantityError.Visible = true;
                return false;
			}
            
            if (intQuant <= 0)
			{
                lblQuantityError.Visible = true;
                return false;
            }

            lblQuantityError.Visible = false;

            return true;
        }

		private void AddSales_Load(object sender, EventArgs e)
		{
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

		private void btnSubmit_Click(object sender, EventArgs e)
		{
            lblRowsAffected.Visible = false;

            if (ValidateInputs())
			{
                string prodID = cmbProductID.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)[1];
                int quant = int.Parse(txtQuantity.Text);
                string date = txtDate.Text;

                string query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quant}, '{date}')";
                SqlCommand command = new SqlCommand(query, Login.con);
                lblRowsAffected.Text = $"{command.ExecuteNonQuery()} affected rows.";

                lblRowsAffected.Visible = true;
            }
        }
	}
}
