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
    public partial class frmDisplayYearlySales : Form
    {
        public frmDisplayYearlySales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Year;

            lblInvalidYear.Visible = true;

            if (int.TryParse(txtYear.Text, out Year))
            {
                if ((Year >= 1753) && (Year <= 9999))
                {
                    lblInvalidYear.Visible = false;
                }
            }

            if ((lblInvalidYear.Visible == true)) 
            {
                return;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Login.con;
            cmd.CommandText = $"SELECT * FROM SALES WHERE YEAR(DATE) = {txtYear.Text}";

            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();                     // create new dataset

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;        // stores records from command
            adapter.Fill(ds);                   // fills dataset with records

            bs.DataSource = ds.Tables[0];       // set datasource of new BindingSource

            dgvDisplay.DataSource = bs;           // set datasource of data grid view
        }
    }
}
