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
    public partial class frmAllSales : Form
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public frmAllSales()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load form event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Sales' table. You can move, or remove it, as needed.
            UpdateTable();
        }

        /// <summary>
        /// Update table with new data
        /// </summary>
        public void UpdateTable()
		{
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();                     // create new dataset

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM dbo.Sales", frmLogin.con);
            
            adapter.SelectCommand = cmd;        // stores records from command
            adapter.Fill(ds);                   // fills dataset with records

            bs.DataSource = ds.Tables[0];       // set datasource of new BindingSource

            dgvSales.DataSource = bs;           // set datasource of data grid view
            SetColWidths();
        }

        /// <summary>
        /// Event handler for back to homepage button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        /// <summary>
        /// Set column widths for dgv
        /// </summary>
        private void SetColWidths()
		{
            dgvSales.Columns[0].Width = 75;
            dgvSales.Columns[1].Width = 120;
            dgvSales.Columns[2].Width = 150;
            dgvSales.Columns[3].Width = 125;
        }

        /// <summary>
        /// Search function implementation for SalesID search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int temp;
            DataTable dt = new DataTable();
            if (int.TryParse(txtSearch.Text, out temp) && txtSearch.Text != "")     //ensuring that the input is in a correct format
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM dbo.Sales where SalesID = '" + txtSearch.Text + "'",frmLogin.con);           
                adapter.Fill(dt);
                dgvSales.DataSource = dt;
                SetColWidths();
            }
            else
			{
                UpdateTable();
                SetColWidths();
            } 
        }
    }
}
