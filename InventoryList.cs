using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class InventoryList : Form
    {
        public InventoryList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pHPdbDataSet.Inventory);         
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
