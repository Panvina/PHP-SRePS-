using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PHP
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void UpdateDB()
        {
            this.productsTableAdapter.Fill(this.pHPdbDataSet.Products);
            BindingSource bindingS = new BindingSource();
            DataSet proDS = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM dbo.Products", frmLogin.con);

            adapter.SelectCommand = cmd;
            adapter.Fill(proDS);

            bindingS.DataSource = proDS.Tables[0];

            dgvProduct.DataSource = bindingS;
            
        }

        private void alertStock()
        {
            int proCount = 0;
            SqlCommand command = new SqlCommand("Select UnitsInStock, MaxProducts from dbo.Products", frmLogin.con);
            string[] read = File.ReadAllLines(frmLogin.LowStockSettingFile);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int toIntUIS = int.Parse(reader["UnitsInStock"].ToString());
                    int toIntMP = int.Parse(reader["MaxProducts"].ToString());
                    //double percent = (toIntUIS / (double)toIntMP) * 100;
                    double percent = CalcPercent(toIntUIS, toIntMP);
                        if (percent < int.Parse(read[0]))
                        {
                            proCount++;
                        }                   
                }
            }
            read[3] = proCount.ToString();
            File.WriteAllLines(frmLogin.LowStockSettingFile, read);
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            UpdateDB();
            alertStock();
            
            string[] file = System.IO.File.ReadAllLines(frmLogin.LowStockSettingFile);
            if (file[2] == "true" && file[3] != "0")
            {
                System.Windows.MessageBox.Show(file[3] + " products are running low!");
            }
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            this.Hide();
            LowStockAlert alert = new LowStockAlert();
            alert.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private double CalcPercent(int firstNum, int secNum)
        {
            double percent = (firstNum / (double)secNum) * 100;
            return percent;
        }

        private void Lowstock_ColourChange(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string [] read = File.ReadAllLines(frmLogin.LowStockSettingFile);
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells[4].Value != DBNull.Value && row.Cells[7].Value != DBNull.Value)
                {
                    int uis = Convert.ToInt32(row.Cells[4].Value);
                    int maxstock = Convert.ToInt32(row.Cells[7].Value);
                    double percent = CalcPercent(uis, maxstock);
                    if (percent < Convert.ToInt32(read[0]))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
