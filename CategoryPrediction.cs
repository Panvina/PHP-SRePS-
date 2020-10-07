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
    public partial class CategoryPrediction : Form
    {
        //On load check current month's sales
        //Have a dictionary where categories are keys and total sales are values
        //Go through all sales and add to dictionary, skipping category-less sales
        //If a category has over 20 sales, display all products with that category in the table
        //Modify threshold later based on team discussion
        public CategoryPrediction()
        {
            InitializeComponent();
        }

        private void CategoryPrediction_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> categorySales = new Dictionary<string, int>();

            string currMonth = DateTime.Now.ToString("MM");
            string currYear = DateTime.Now.ToString("yyyy");

            //For each sale in current month and year crosscheck products for category and sales for amount

            SqlCommand cmdSales = new SqlCommand($"Select * FROM dbo.Sales WHERE MONTH(DATE) = {currMonth} AND YEAR(DATE) = {currYear}", frmLogin.con);

            SqlDataReader readerSales = cmdSales.ExecuteReader();

            while (readerSales.Read())
            {
                string prodID = readerSales.GetString(1);

                SqlConnection con2 = new SqlConnection(frmLogin.conString);
                con2.Open();

                SqlCommand cmdProducts = new SqlCommand($"Select * FROM dbo.Products WHERE ProductID = {prodID}", con2);

                SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                while (readerProducts.Read())
                {
                    if(readerProducts.GetString(6) != null)
                    {
                        string category = readerProducts.GetString(6);
                        int amount = readerSales.GetInt32(2);

                        if (categorySales.ContainsKey(category))
                        {
                            categorySales[category] += amount;
                        }
                        else
                        {
                            categorySales.Add(category, amount);
                        }
                    }
                }
                readerProducts.Close();
                con2.Close();
            }
            readerSales.Close();

            int prodPlace = 0;

            foreach (KeyValuePair<string, int> entry in categorySales)
            {
                if(categorySales[entry.Key] >= 20)
                {
                    SqlCommand cmd = new SqlCommand($"Select * FROM dbo.Products WHERE Category = '{entry.Key}'", frmLogin.con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvProducts.Rows[prodPlace].Cells[0].Value = reader[0].ToString();
                        dgvProducts.Rows[prodPlace].Cells[1].Value = reader[1].ToString();
                        dgvProducts.Rows[prodPlace].Cells[2].Value = reader[2].ToString();
                        dgvProducts.Rows[prodPlace].Cells[3].Value = reader[3].ToString();
                        dgvProducts.Rows[prodPlace].Cells[4].Value = reader[4].ToString();
                        dgvProducts.Rows[prodPlace].Cells[5].Value = reader[5].ToString();
                        dgvProducts.Rows[prodPlace].Cells[6].Value = reader[6].ToString();
                    }
                    prodPlace += 1;
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }
    }
}
