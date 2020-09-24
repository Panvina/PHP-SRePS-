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
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
