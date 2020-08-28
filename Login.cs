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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private static readonly string databaseLocation = @"D:\Projects\SalesPoint\PHPdb.mdf";
        //should be the machine name
        private static readonly string userName = @"(LocalDB)\MSSQLLocalDB";

        public string conString = @"Data Source="+userName+";AttachDbFilename=" + databaseLocation + ";Integrated Security=True";
        
        private void Connect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connecting...");
                Homepage hp = new Homepage();
                hp.Show();               
                this.Hide();              
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
