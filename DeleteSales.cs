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
    public partial class DeleteSales : Form
    {
        public DeleteSales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string salesID = txtID.Text;
            SqlCommand command = new SqlCommand("DELETE FROM Sales WHERE SalesID = @salesID");
            MessageBox.Show("Sale Deleted");
        }

    }
}
