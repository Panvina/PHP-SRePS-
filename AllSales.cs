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
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();

        }

        private void AllSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Sales' table. You can move, or remove it, as needed.
            UpdateTable();
        }

        public void UpdateTable()
		{
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();                     // create new dataset

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM dbo.Sales", Login.con);
            
            adapter.SelectCommand = cmd;        // stores records from command
            adapter.Fill(ds);                   // fills dataset with records

            bs.DataSource = ds.Tables[0];       // set datasource of new BindingSource

            dgvSales.DataSource = bs;           // set datasource of data grid view
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
