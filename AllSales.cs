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
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();
        }

        private void AllSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pHPdbDataSet.Sales);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }
    }
}
