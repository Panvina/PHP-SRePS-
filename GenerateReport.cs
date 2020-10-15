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
using System.IO;
using System.Diagnostics;

namespace PHP
{
	public partial class frmGenerateCSV : Form
	{
		private string exportDirectory = Environment.CurrentDirectory + @"\reports";
		private string ext = ".csv";

		private string reportList = "reportList.txt";

		public frmGenerateCSV()
		{
			InitializeComponent();
		}

		private void frmGenerateCSV_Load(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			txtMonth.Text = dt.Month.ToString();
			txtYear.Text = dt.Year.ToString();

			if (!File.Exists(reportList))
			{
				File.Create(reportList);
			}

			PopulateCmbReportList();

			EnableCmbReportList();
			EnableReportButtons();
		}

		private void EnableCmbReportList()
		{
			cmbSelectReport.Enabled = (cmbSelectReport.Items.Count > 0);
		}

		private void EnableReportButtons()
		{
			bool enableButtons = (cmbSelectReport.Items.Count > 0);

			if (enableButtons)
			{
				btnSummary.Enabled = true;
				btnAllItems.Enabled = true;
			}
		}

		/// <summary>
		/// Get the date of a report
		/// </summary>
		private string GetReportDate()
		{
			return $"{int.Parse(txtMonth.Text)}-{int.Parse(txtYear.Text)}";
		}

		/// <summary>
		/// Update list of reports for CMB
		/// </summary>
		private void UpdateReportList()
		{
			string reportDate = GetReportDate();

			if (!cmbSelectReport.Items.Contains(reportDate))
			{
				List<string> repList = GetReportList();
				repList.Add(reportDate);
				repList.Sort();

				StreamWriter writer = new StreamWriter(reportList);
				
				for(int i = 0; i < repList.Count; i++)
				{
					writer.WriteLine(repList[i]);
				}

				writer.Close();
			}
		}

		/// <summary>
		/// Get a list of reports
		/// </summary>
		/// <returns></returns>
		private List<string> GetReportList()
		{
			StreamReader reader = new StreamReader(reportList);
			List<string> repList = new List<string>();

			while(!reader.EndOfStream)
			{
				repList.Add(reader.ReadLine());
			}
			reader.Close();

			repList.Sort();

			return repList;
		}

		/// <summary>
		/// Get report list combo box
		/// </summary>
		private void PopulateCmbReportList()
		{
			cmbSelectReport.Items.Clear();
			StreamReader reader = new StreamReader(reportList);

			while (!reader.EndOfStream)
			{
				cmbSelectReport.Items.Add(reader.ReadLine());
			}

			reader.Close();

			if (cmbSelectReport.Items.Count > 0)
			{
				cmbSelectReport.SelectedIndex = 0;
			}
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

			btnGen.Enabled = (dgvSum.Rows.Count > 0);
		}

		/// <summary>
		/// Populate individual transaction DGV
		/// </summary>
		/// <param name="cmd"></param>
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

		/// <summary>
		/// Populates Summary DGV
		/// </summary>
		/// <param name="cmd"></param>
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

		/// <summary>
		/// Get a collection of quantities for products
		/// </summary>
		/// <param name="cmd"></param>
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

		/// <summary>
		/// Get a collection of products
		/// </summary>
		/// <param name="cmd"></param>
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

		/// <summary>
		/// Update month error label
		/// </summary>
		private void txtMonth_TextChanged(object sender, EventArgs e)
		{
			ValidateMonth(txtMonth.Text);
		}

		/// <summary>
		/// Update year error label
		/// </summary>
		private void txtYear_TextChanged(object sender, EventArgs e)
		{
			ValidateYear(txtYear.Text);
		}

		/// <summary>
		/// Full validation for month
		/// </summary>
		/// <param name="text"></param>
		private bool ValidateMonth(String text)
		{
			int month = 0;
			bool errorFound = false;

			errorFound = !int.TryParse(text, out month);

			errorFound = !(!errorFound && MonthRangeValid(month));

			DisplayMonthError(errorFound);

			return errorFound;
		}

		/// <summary>
		/// Full validation for year
		/// </summary>
		/// <param name="text"></param>
		private bool ValidateYear(String text)
		{
			int year = 0;
			bool errorFound = false;

			errorFound = !int.TryParse(text, out year);

			errorFound = !(!errorFound && YearRangeValid(year));

			DisplayYearError(errorFound);

			return errorFound;
		}

		/// <summary>
		/// Checks a month is acceptable
		/// </summary>
		/// <param name="month"></param>
		/// <returns></returns>
		private bool MonthRangeValid(int month)
		{
			return (month >= 1 && month <= 12);
		}

		/// <summary>
		/// Checks if an integer is within a select range of values 
		/// acceptable for SQL DateTime type
		/// </summary>
		/// <param name="year"></param>
		/// <returns></returns>
		private bool YearRangeValid(int year)
		{
			return (year >= 1753 && year <= 9999);
		}

		/// <summary>
		/// Displays month error label
		/// </summary>
		/// <param name="error"></param>
		private void DisplayMonthError(bool error)
		{
			lblInvalidMonth.Visible = error;
		}

		/// <summary>
		/// Displays year error label
		/// </summary>
		/// <param name="error"></param>
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

		/// <summary>
		/// Event handler for clicking generate report button
		/// </summary>
		private void btnGen_Click(object sender, EventArgs e)
		{
			// create directory if it does not exist
			if (!Directory.Exists(exportDirectory))
			{
				Directory.CreateDirectory(exportDirectory);
			}

			string dateSelected = GetReportDate();
			string individualRepName = $"{dateSelected} Transaction Report";
			string sumRepName = $"{dateSelected} Summary Report";

			// start timer
			Timer.Start();

			WriteToFile($"{exportDirectory}\\{individualRepName}{ext}", dgvDisplay);
			WriteToFile($"{exportDirectory}\\{sumRepName}{ext}", dgvSum);

			// stop timer and get time
			long ms = Timer.Stop();

			UpdateReportList();
			PopulateCmbReportList();
			EnableCmbReportList();
			EnableReportButtons();

			//MessageBox.Show($"{ms}, Items: {dgvDisplay.Rows.Count}");

			// open file directory if requested
			DialogResult result = MessageBox.Show($"Report for {dateSelected} generated.\nOpen directory?", "Report generated", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Process.Start($"{exportDirectory}");
			}
		}

		/// <summary>
		/// Writes contents of a data grid view to a file
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="dgv"></param>
		private void WriteToFile(String fileName, DataGridView dgv)
		{
			StreamWriter sw = new StreamWriter(fileName);

			int rows = dgv.RowCount;
			int cols = dgv.ColumnCount;

			for(int i = 0; i < cols; i++)
			{
				if (i != cols - 1)
				{
					sw.Write($"{dgv.Columns[i].HeaderText}, ");
				}
				else
				{
					sw.WriteLine($"{dgv.Columns[i].HeaderText}");
				}
			}

			for(int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (j != cols - 1)
					{
						sw.Write($"{dgv.Rows[i].Cells[j].Value}, ");
					}
					else
					{
						sw.WriteLine($"{dgv.Rows[i].Cells[j].Value}");
					}
				}
			}

			sw.Close();
		}

		/// <summary>
		/// Open transaction report
		/// </summary>
		private void btnAllItems_Click(object sender, EventArgs e)
		{
			Process.Start($"{exportDirectory}\\{cmbSelectReport.Text} Transaction Report.csv");
		}

		/// <summary>
		/// Open summary report
		/// </summary>
		private void btnSummary_Click(object sender, EventArgs e)
		{
			Process.Start($"{exportDirectory}\\{cmbSelectReport.Text} Summary Report.csv");
		}

		private void grbGenerateReport_Enter(object sender, EventArgs e)
		{

		}

		private void cmbSelectReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
