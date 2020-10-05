using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHP
{
	public partial class frmGenerateCSV : Form
	{
		public frmGenerateCSV()
		{
			InitializeComponent();
		}

		private void frmGenerateCSV_Load(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			txtMonth.Text = dt.Month.ToString();
			txtYear.Text = dt.Year.ToString();
		}

		private void lblInvalidYear_Click(object sender, EventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmHomepage home = new frmHomepage();
			home.Show();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (ValidateMonth(txtMonth.Text) || ValidateYear(txtYear.Text))
			{
				return;
			}

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = frmLogin.con;

			PopulateSingle(cmd);

			PopulateTotals(cmd);
		}

		private void PopulateSingle(SqlCommand cmd)
		{
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
		}

		private void PopulateTotals(SqlCommand cmd)
		{
			// get quantities from Sales table
			Dictionary<int, int> quantities = GetQuantities(cmd);

			// get product info from Products table
			Dictionary<int, Product> products = GetProducts(cmd);

			// Populate data table
			DataTable records = GetRecordsTable(quantities, products);

			// add table to dataset
			DataSet monthlyRecord = new DataSet();
			monthlyRecord.Tables.Add(records);

			BindingSource SumBinding = new BindingSource();
			SumBinding.DataSource = monthlyRecord.Tables[0];

			dgvSum.Columns.Clear();
			dgvSum.DataSource = SumBinding;
			SetColWidths();
		}

		private Dictionary<int, int> GetQuantities(SqlCommand cmd)
		{
			Dictionary<int, int> quantities = new Dictionary<int, int>();

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

			return quantities;
		}

		private Dictionary<int, Product> GetProducts(SqlCommand cmd)
		{
			Dictionary<int, Product> products = new Dictionary<int, Product>();
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

			return products;
		}

		private DataTable GetRecordsTable(Dictionary<int, int> quantities, Dictionary<int, Product> products)
		{
			// create Table structure
			DataTable records = new DataTable("Monthly Record");
			records.Columns.Add("ID");
			records.Columns.Add("Product name");
			records.Columns.Add("Quantity");
			records.Columns.Add("Price");
			records.Columns.Add("Total");

			// Add information to table
			foreach (KeyValuePair<int, int> kvp in quantities)
			{
				Product p = products[kvp.Key];

				records.Rows.Add(p.id, p.name, quantities[p.id], p.price, p.price * quantities[p.id]);
			}

			return records;
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

		private void txtMonth_TextChanged(object sender, EventArgs e)
		{
			ValidateMonth(txtMonth.Text);
		}

		private void txtYear_TextChanged(object sender, EventArgs e)
		{
			ValidateYear(txtYear.Text);
		}

		private bool ValidateMonth(String text)
		{
			int month = 0;
			bool errorFound = false;

			errorFound = !int.TryParse(text, out month);

			errorFound = !(!errorFound && MonthRangeValid(month));

			DisplayMonthError(errorFound);

			return errorFound;
		}

		private bool ValidateYear(String text)
		{
			int year = 0;
			bool errorFound = false;

			errorFound = !int.TryParse(text, out year);

			errorFound = !(!errorFound && YearRangeValid(year));

			DisplayYearError(errorFound);

			return errorFound;
		}

		private bool MonthRangeValid(int month)
		{
			return (month >= 1 && month <= 12);
		}

		private bool YearRangeValid(int year)
		{
			return (year >= 1753 && year <= 9999);
		}

		private void DisplayMonthError(bool error)
		{
			lblInvalidMonth.Visible = error;
		}

		private void DisplayYearError(bool error)
		{
			lblInvalidYear.Visible = error;
		}

		private void btnBack_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			frmHomepage home = new frmHomepage();
			home.Show();
		}
	}
}
