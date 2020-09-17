using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class DisplayMonthlySales : Form
    {
        public DisplayMonthlySales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }


        private bool ValidateProductID()
        {
            int Month;

            if (!int.TryParse(txtMonth.Text, out Month))
            {
                lblMonth.Visible = true;
                return false;
            }

            if (Month > 12)
            {
                lblMonth.Visible = true;
                return false;
            }

            return true;
        }



            private void btnSearch_Click(object sender, EventArgs e)
        {
            
            int Month = Convert.ToInt32(txtMonth.Text);
            string Year = txtYear.Text;

            if (Month > 12 || Month <= 0)
            {
                lblMonth.Visible = true;              
            }

            if (Year.Length > 4)
            {
                lblYear.Visible = true;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Login.con;
            cmd.CommandText = $"SELECT * FROM SALES WHERE MONTH(DATE) = {txtMonth.Text} AND YEAR(DATE) = {txtYear.Text}";

           
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
