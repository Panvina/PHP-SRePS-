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
            Dictionary<string, int> currCategorySales = new Dictionary<string, int>();
            Dictionary<string, int> lastCategorySales = new Dictionary<string, int>();
            int lastTotalSales = 0;

            string currMonth = DateTime.Now.ToString("MM");
            string currYear = DateTime.Now.ToString("yyyy");
            string lastYear = DateTime.Now.AddYears(-1).ToString("yyyy");

            //For each sale in current month and year crosscheck products for category and sales for amount

            //SqlCommand cmdSalesCurrYear = new SqlCommand($"Select * FROM dbo.Sales WHERE MONTH(DATE) = {currMonth} AND YEAR(DATE) = {currYear}", frmLogin.con);

            //SqlDataReader readerSales = cmdSalesCurrYear.ExecuteReader();

            //while (readerSales.Read())
            //{
            //    string prodID = readerSales.GetString(1);
            //
            //    SqlConnection con2 = new SqlConnection(frmLogin.conString);
            //    con2.Open();

            //    SqlCommand cmdProducts = new SqlCommand($"Select * FROM dbo.Products WHERE ProductID = {prodID}", con2);

            //    SqlDataReader readerProducts = cmdProducts.ExecuteReader();

            //    while (readerProducts.Read())
            //    {
            //        if(readerProducts.GetString(6) != null)
            //        {
            //            string category = readerProducts.GetString(6);
            //            int amount = readerSales.GetInt32(2);

            //            if (currCategorySales.ContainsKey(category))
            //            {
            //                currCategorySales[category] += amount;
            //                lastTotalSales += amount;
            //            }
            //            else
            //            {
            //                currCategorySales.Add(category, amount);
            //                lastTotalSales += amount;
            //            }
            //        }
            //    }
            //    readerProducts.Close();
            //    con2.Close();
            //}

            SqlCommand cmdSalesLastYear = new SqlCommand($"Select * FROM dbo.Sales WHERE MONTH(DATE) = {currMonth} AND YEAR(DATE) = {lastYear}", frmLogin.con);

            SqlDataReader readerSales = cmdSalesLastYear.ExecuteReader();

            while (readerSales.Read())
            {
                string prodID = readerSales.GetString(1);

                SqlConnection con2 = new SqlConnection(frmLogin.conString);
                con2.Open();

                SqlCommand cmdProducts = new SqlCommand($"Select * FROM dbo.Products WHERE ProductID = {prodID}", con2);

                SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                while (readerProducts.Read())
                {
                    if (readerProducts.GetString(6) != null)
                    {
                        string category = readerProducts.GetString(6);
                        int amount = readerSales.GetInt32(2);

                        if (lastCategorySales.ContainsKey(category))
                        {
                            lastCategorySales[category] += amount;
                            lastTotalSales += amount;
                        }
                        else
                        {
                            lastCategorySales.Add(category, amount);
                            lastTotalSales += amount;
                        }
                    }
                }
                readerProducts.Close();
                con2.Close();
            }

            readerSales.Close();

            int prodPlace = 0;

            foreach (KeyValuePair<string, int> entry in lastCategorySales)
            {
                SqlCommand cmd = new SqlCommand($"Select * FROM dbo.Products WHERE Category = '{entry.Key}'", frmLogin.con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProducts);

                    row.CreateCells(dgvProducts, "", "", "", "", "", "", "", "");

                    dgvProducts.Rows.Add(row);
                    dgvProducts.Rows[prodPlace].Cells[0].Value = reader.GetValue(0).ToString();
                    dgvProducts.Rows[prodPlace].Cells[1].Value = reader.GetValue(1).ToString();
                    dgvProducts.Rows[prodPlace].Cells[2].Value = reader.GetValue(2).ToString();
                    dgvProducts.Rows[prodPlace].Cells[3].Value = reader.GetValue(3).ToString();
                    dgvProducts.Rows[prodPlace].Cells[4].Value = reader.GetValue(4).ToString();
                    dgvProducts.Rows[prodPlace].Cells[5].Value = reader.GetValue(5).ToString();
                    dgvProducts.Rows[prodPlace].Cells[6].Value = reader.GetValue(6).ToString();
                    dgvProducts.Rows[prodPlace].Cells[7].Value = ((float) 100 * lastCategorySales[entry.Key] / lastTotalSales).ToString() + "%";
                    prodPlace += 1;
                }

                reader.Close();
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
