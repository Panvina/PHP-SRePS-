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
    public partial class frmDeleteSales : Form
    {
        public frmDeleteSales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate SaleID integer
        /// </summary>
        /// <param name="salesID">integer to validate</param>
        /// <returns>true if input integer is found in table</returns>
        public bool ValidateSaleID(int salesID)
        {
            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Sales WHERE SalesID = @salesID", frmLogin.con);
            command.Parameters.AddWithValue("@salesID", salesID);
            var res = (int)command.ExecuteScalar();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Event handler for exit button clicked
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        /// <summary>
        /// Event handler for delete button click
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int salesID = int.Parse(txtID.Text);
            if (ValidateSaleID(salesID))
            {            
                SqlCommand command = new SqlCommand($"DELETE FROM Sales WHERE SalesID = @salesID", frmLogin.con);
                command.Parameters.AddWithValue("@salesID", salesID);
                command.ExecuteNonQuery();
                MessageBox.Show("Sale deleted");
            }
            else
            {
                MessageBox.Show("Sale not found");
            }
            
        }

    }
}
