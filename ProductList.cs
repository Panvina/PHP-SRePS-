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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void UpdateDB()
        {
            this.productsTableAdapter.Fill(this.pHPdbDataSet.Products);
            BindingSource bindingS = new BindingSource();
            DataSet proDS = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM dbo.Products", frmLogin.con);

            adapter.SelectCommand = cmd;
            adapter.Fill(proDS);

            bindingS.DataSource = proDS.Tables[0];

            dgvProduct.DataSource = bindingS;

            DataSet changes = proDS.GetChanges();
            if (changes != null)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();

                adapter.Update(changes);
                proDS.AcceptChanges();
            }
            //this.productsTableAdapter.Update(this.pHPdbDataSet.Products);       //send the data in the dataset to the database
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomepage home = new frmHomepage();
            home.Show();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
