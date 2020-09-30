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
    public partial class frmDisplaySuppliers : Form
    {
        public frmDisplaySuppliers()
        {
            InitializeComponent();
        }

        private void frmDisplaySuppliers_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.pHPdbDataSet.Suppliers);
        }

        public void UpdateTable()
        {
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM Suppliers", frmLogin.con);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            bs.DataSource = ds.Tables[0];

            dgvSuppliers.DataSource = bs;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int temp;
            DataTable dt = new DataTable();
            if (int.TryParse(txtSearch.Text, out temp) && txtSearch.Text != "")     //ensuring that the input is in a correct format
            {
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT * FROM Suppliers where SupplierID = '" + txtSearch.Text + "'", frmLogin.con);
                adapter.Fill(dt);
                dgvSuppliers.DataSource = dt;
            }
            else
            {
                UpdateTable();
            }
        }
    }
}
