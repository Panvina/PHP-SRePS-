﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PHP
{
    public partial class frmDisplayMonthlySales : Form
    {
		public frmDisplayMonthlySales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Month, Year;

            lblMonthError.Visible = true;
            lblInvalidYear.Visible = true;

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

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = frmLogin.con;
            cmd.CommandText = $"SELECT * FROM SALES WHERE MONTH(DATE) = {txtMonth.Text} AND YEAR(DATE) = {txtYear.Text}";

			BindingSource DispBinding = new BindingSource();
			DataSet DispData = new DataSet();                     // create new dataset

			SqlDataAdapter adapter = new SqlDataAdapter();

			adapter.SelectCommand = cmd;        // stores records from command
			adapter.Fill(DispData);                   // fills dataset with records

			DispBinding.DataSource = DispData.Tables[0];       // set datasource of new BindingSource

			dgvDisplay.DataSource = DispBinding;           // set datasource of data grid view
			dgvDisplay.Columns[0].Width = 60;
			dgvDisplay.Columns[1].Width = 100;
			dgvDisplay.Columns[2].Width = 65;
			dgvDisplay.Columns[3].Width = 112;

			// create Table structure
			DataTable records = new DataTable("Monthly Record");
			records.Columns.Add("ID");
			records.Columns.Add("Product name");
			records.Columns.Add("Quantity");
			records.Columns.Add("Price");
			records.Columns.Add("Total");

			// stores quantities
			Dictionary<int, int> quantities = new Dictionary<int, int>();
			// stores product info
			Dictionary<int, Product> products = new Dictionary<int, Product>();

			// get quantities from Sales table
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					int key = int.Parse($"{reader[1]}");
					int quant = int.Parse($"{reader[2]}");

					if (!quantities.ContainsKey(key))
					{
						quantities.Add(key, quant);
					}
					else
					{
						quantities[key] += quant;
					}
				}
			}

			// get product info from Products table
			cmd.CommandText = "SELECT * FROM Products";

			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					int id = int.Parse($"{reader[0]}");
					double price = double.Parse($"{reader[3]}");
					string name = $"{reader[1]}";

					products.Add(id, new Product(id, name, price));
				}
			}

			// Add information to table
			foreach (KeyValuePair<int, int> kvp in quantities)
			{
				Product p = products[kvp.Key];

				records.Rows.Add(p.id, p.name, quantities[p.id], p.price, p.price * quantities[p.id]);
			}

			// add table to dataset
			DataSet monthlyRecord = new DataSet();
			monthlyRecord.Tables.Add(records);

			BindingSource SumBinding = new BindingSource();
			SumBinding.DataSource = monthlyRecord.Tables[0];

			dgvSum.Columns.Clear();
			dgvSum.DataSource = SumBinding;
			SetColWidths();
		}

		private void frmDisplayMonthlySales_Load(object sender, EventArgs e)
		{
			dgvDisplay.RowHeadersVisible = false;
			dgvSum.RowHeadersVisible = false;

			//placeholders for data grid view
			dgvSum.Columns.Add("", "ID");
			dgvSum.Columns.Add("", "Product name");
			dgvSum.Columns.Add("", "Quantity");
			dgvSum.Columns.Add("", "Price");
			dgvSum.Columns.Add("", "ID");

			SetColWidths();

			// set default month and year as todays
			txtMonth.Text = DateTime.Now.Month.ToString();
			txtYear.Text = DateTime.Now.Year.ToString();
		}

		/// <summary>
		/// Set column widths for dgvDisplay
		/// </summary>
		private void SetColWidths()
		{
			dgvSum.Columns[0].Width = 50;
			dgvSum.Columns[1].Width = 107;
			dgvSum.Columns[2].Width = 50;
			dgvSum.Columns[3].Width = 50;
			dgvSum.Columns[4].Width = 80;
		}

		private void lblInvalidYear_Click(object sender, EventArgs e)
		{

		}

		private void txtYear_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblYear_Click(object sender, EventArgs e)
		{

		}
	}
}
