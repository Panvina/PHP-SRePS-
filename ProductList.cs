using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private int alertStock()
        {
            int proCount = 0;
            SqlCommand command = new SqlCommand("Select UnitsInStock, MaxProducts from dbo.Products", frmLogin.con);
            string[] read = System.IO.File.ReadAllLines(frmLogin.LowStockSettingFile);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int toIntUIS = int.Parse(reader["UnitsInStock"].ToString());
                    int toIntMP = int.Parse(reader["MaxProducts"].ToString());
                    double percent = (toIntUIS / (double)toIntMP) * 100;
                        if (percent < int.Parse(read[0]))
                        {
                            proCount++;
                        }                   
                }
            }
            return proCount;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            
            UpdateDB();
            int proCount = alertStock();
        
            string[] file = System.IO.File.ReadAllLines(frmLogin.LowStockSettingFile);
            if (file[2] == "true")
            {
                System.Windows.MessageBox.Show(proCount + " products are running low!");
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
    }
}
