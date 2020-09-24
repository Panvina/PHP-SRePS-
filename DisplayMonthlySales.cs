using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class frmDisplayMonthlySales : Form
    {
        struct Product
		{
            public int id;
            public string name;
            public double price;

            public Product(int aID, string aName, double aPrice)
			{
                id = aID;
                name = aName;
                price = aPrice;
			}
		}

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

   //         // create Table structure
   //         DataTable records = new DataTable("Monthly Record");
   //         records.Columns.Add("ID");
   //         records.Columns.Add("Product name");
   //         records.Columns.Add("Quantity");
   //         records.Columns.Add("Price");
   //         records.Columns.Add("Total");

   //         // stores quantities
   //         Dictionary<int, int> quantities = new Dictionary<int, int>();
   //         // stores product info
   //         Dictionary<int, Product> products = new Dictionary<int, Product>();

   //         // get quantities from Sales table
   //         using (SqlDataReader reader = cmd.ExecuteReader())
   //         {
   //             while (reader.Read())
   //             {
   //                 int key = int.Parse($"{reader[1]}");
   //                 int quant = int.Parse($"{reader[2]}");

   //                 if (quantities.ContainsKey(key))
			//		{
   //                     quantities.Add(key, quant);
			//		}
   //                 else
			//		{
   //                     quantities[key] += quant;
			//		}
   //             }
   //         }

   //         // get product info from Products table
   //         cmd.CommandText = "SELECT * FROM Products";

   //         using (SqlDataReader reader = cmd.ExecuteReader())
   //         {
   //             while (reader.Read())
   //             {
   //                 int id = int.Parse($"{reader[0]}");
   //                 double price = double.Parse($"{reader[2]}");
   //                 string name = $"{reader[1]}";

   //                 products.Add(id, new Product(id, name, price));
   //             }
   //         }

   //         // Add information to table
   //         foreach (KeyValuePair<int,int> kvp in quantities)
			//{
   //             Product p = products[kvp.Key];

   //             records.Rows.Add(p.id, p.name, quantities[p.id], p.price, p.price * quantities[p.id]);
			//}

   //         // add table to dataset
   //         DataSet monthlyRecord = new DataSet();
   //         monthlyRecord.Tables.Add(records);

            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();                     // create new dataset

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;        // stores records from command
            adapter.Fill(ds);                   // fills dataset with records

            bs.DataSource = ds.Tables[0];       // set datasource of new BindingSource

            dgvDisplay.DataSource = bs;           // set datasource of data grid view
        }
    }
}
