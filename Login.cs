using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static readonly string LowStockSettingFile = $"{Environment.CurrentDirectory}\\LowStockSetting.txt";
        private static readonly string databaseLocation = $"{Environment.CurrentDirectory}\\PHPdb.mdf";        //should be the machine name
        private static readonly string userName = @"(LocalDB)\MSSQLLocalDB";

        public static string conString = @"Data Source="+userName+";AttachDbFilename=" + databaseLocation + ";Integrated Security=True";
        public static SqlConnection con;

        private void Connect_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string [] read = File.ReadAllLines(LowStockSettingFile);
                if (read[3] != "0")
                {
                    Alert_Box();
                } else
                {
                    frmHomepage hp = new frmHomepage();
                    hp.Show();
                    this.Hide();
                }
			}

            //Random rnd = new Random();
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;

            //string query = "SELECT * FROM Products";
            //cmd.CommandText = query;
            //List<string> products = new List<string>();

            //using (SqlDataReader reader = cmd.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        products.Add($"{reader[0]}");
            //    }
            //}

            //for (int i = 2000; i <= 2020; i++)
            //{
            //    for (int j = 0; j < 2000; j++)
            //    {
            //        string prodID = products[rnd.Next(0, products.Count - 1)];
            //        string quant = $"{rnd.Next(5, 50)}";
            //        string date = $"{i}-{rnd.Next(1, 12)}-{rnd.Next(1, 27)}";
            //        query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quant}, '{date}')";
            //        cmd.CommandText = query;
            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }
        private void Alert_Box()
        {
            string[] text = System.IO.File.ReadAllLines(LowStockSettingFile);
            if (text[1] == "true")
            {
                string message = "Your product(s) are running low!\nPlease check the product list for more information.\n"
                    + "Would you like to check now?";
                const string caption = "Low Stock Alert";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ProductList pl = new ProductList();
                    pl.Show();
                    this.Hide();
                } else
                {
                    frmHomepage hp = new frmHomepage();
                    hp.Show();
                    this.Hide();
                }
            }
        }
    }
    
}
