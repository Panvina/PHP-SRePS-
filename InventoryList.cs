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
    public partial class frmInventoryList : Form
    {
        public frmInventoryList()
        {
            InitializeComponent();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM dbo.Inventory", frmLogin.con);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);                   

            bs.DataSource = ds.Tables[0];

            dgvInventory.DataSource = bs;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
