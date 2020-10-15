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
        public CategoryPrediction()
        {
            InitializeComponent();
        }

        private void CategoryPrediction_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> lastCategorySales = new Dictionary<string, int>();
            int lastTotalSales = 0;

            string currMonth = DateTime.Now.ToString("MM");
            string currYear = DateTime.Now.ToString("yyyy");
            string lastYear = DateTime.Now.AddYears(-1).ToString("yyyy");

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
                    if (readerProducts.GetString(8) != null)
                    {
                        string categoryID = readerProducts.GetString(8);
                        int amount = readerSales.GetInt32(2);

                        if (lastCategorySales.ContainsKey(categoryID))
                        {
                            lastCategorySales[categoryID] += amount;
                            lastTotalSales += amount;
                        }
                        else
                        {
                            lastCategorySales.Add(categoryID, amount);
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
                SqlCommand cmdProducts = new SqlCommand($"Select * FROM dbo.Products WHERE CategoryID = '{entry.Key}'", frmLogin.con);

                SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                while (readerProducts.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProducts);

                    row.CreateCells(dgvProducts, "", "", "", "", "", "", "", "");

                    dgvProducts.Rows.Add(row);
                    dgvProducts.Rows[prodPlace].Cells[0].Value = readerProducts.GetValue(0).ToString();
                    dgvProducts.Rows[prodPlace].Cells[1].Value = readerProducts.GetValue(1).ToString();
                    dgvProducts.Rows[prodPlace].Cells[2].Value = readerProducts.GetValue(2).ToString();
                    dgvProducts.Rows[prodPlace].Cells[3].Value = readerProducts.GetValue(3).ToString();
                    dgvProducts.Rows[prodPlace].Cells[4].Value = readerProducts.GetValue(4).ToString();
                    dgvProducts.Rows[prodPlace].Cells[5].Value = readerProducts.GetValue(5).ToString();

                    SqlConnection con2 = new SqlConnection(frmLogin.conString);
                    con2.Open();
                    SqlCommand cmdCategories = new SqlCommand($"Select * FROM dbo.Category WHERE CategoryID = '{readerProducts.GetValue(8).ToString()}'", con2);
                    SqlDataReader readerCategories = cmdCategories.ExecuteReader();
                    while (readerCategories.Read())
                    {
                        dgvProducts.Rows[prodPlace].Cells[6].Value = readerCategories.GetValue(1).ToString();
                    }
                    readerCategories.Close();
                    con2.Close();

                    dgvProducts.Rows[prodPlace].Cells[7].Value = ((float) 100 * lastCategorySales[entry.Key] / lastTotalSales).ToString() + "%";
                    prodPlace += 1;
                }

                readerProducts.Close();
            }
            if (lastCategorySales.Count() == 0)
            {
                MessageBox.Show("No categories of items sold on " + currMonth + " of " + lastYear + ". Prediction impossible.");
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
