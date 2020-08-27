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
        public string conString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PHPdb;Integrated Security=True");

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
            // Data Source=(<machine>)\<instance>;Initial Catalog=<database directory>;Integrated Security=True


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
