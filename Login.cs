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
                frmHomepage hp = new frmHomepage();
                hp.Show();               
                this.Hide();
                string[] text = System.IO.File.ReadAllLines(LowStockSettingFile);
                if (text[1] == "true")
                { 
                    MessageBox.Show( "Your product(s) are running low!\n Please check the inventory list for more information.");
                }
            }

   //         SqlCommand cmd = new SqlCommand();
   //         cmd.Connection = con;

   //         cmd.CommandText = $"SELECT * FROM Products";
   //         List<string> products = new List<string>();
   //         Random rnd = new Random();

   //         using (SqlDataReader reader = cmd.ExecuteReader())
			//{
   //             while(reader.Read())
			//	{
   //                 products.Add($"{reader[0]}");
			//	}
			//}                

			//cmd.CommandText = "DELETE FROM Sales WHERE 1=1";
			//cmd.ExecuteNonQuery();

			//for (int j = 2000; j <= 2020; j++)
			//{
   //             for (int i = 0; i < 2500; i++)
			//	{
   //                 string prodID = products[rnd.Next(0, products.Count - 1)];
			//		int quant = rnd.Next(1, 50);
			//		string date = $"{j}-{rnd.Next(1, 12)}-{rnd.Next(1, 28)}";

			//		string query = $"INSERT INTO Sales (ProductID, Quantity, Date) VALUES ({prodID}, {quant}, '{date}')";
			//		cmd.CommandText = query;
			//		cmd.ExecuteNonQuery();
			//	}
			//}
		}
    }
}
