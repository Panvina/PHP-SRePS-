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

        /// <summary>
        /// Event handler for form loading
        /// </summary>
        private void InventoryList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.pHPdbDataSet.Inventory);
            dgvInventory.RowHeadersVisible = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = frmLogin.con;

            // create table
            DataTable invTable = GetInvTable();

            Dictionary<int, Product> products = GetProducts(cmd);
            Dictionary<int, (int, int)> inventory = GetInventory(cmd);

            PopulateInvTable(ref invTable, ref inventory, ref products);

            FillInvDgv(ref invTable);
            SetColWidths();
        }

        /// <summary>
        /// Create inventory DataTable
        /// </summary>
        /// <returns>Data table</returns>
        private DataTable GetInvTable()
		{
            DataTable invRecord = new DataTable("Inventory List");
            invRecord.Columns.Add("ID");
            invRecord.Columns.Add("Product name");
            invRecord.Columns.Add("Price");
            invRecord.Columns.Add("Units In Stock");
            invRecord.Columns.Add("Units On Order");

            return invRecord;
        }

        /// <summary>
        /// Create and return Product details list
        /// </summary>
        /// <param name="cmd">SqlCommand object with connection</param>
        /// <returns>Product Dictionary</returns>
        private Dictionary<int, Product> GetProducts(SqlCommand cmd)
		{
            Dictionary<int, Product> products = new Dictionary<int, Product>();

            string query = "SELECT * FROM Products";
            cmd.CommandText = query;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse($"{reader[0]}");
                    double price = double.Parse($"{reader[3]}");
                    string name = $"{reader[1]}";

                    products.Add(id, new Product(id, name, price));
                }
            }

            return products;
        }

        /// <summary>
        /// Create and return Inventory details list
        /// </summary>
        /// <param name="cmd">SqlCommand object with connection</param>
        /// <returns>Inventory Dictionary</returns>
        private Dictionary<int, (int, int)> GetInventory(SqlCommand cmd)
		{
            Dictionary<int, (int, int)> inventory = new Dictionary<int, (int, int)>();

            string query = "SELECT * FROM Inventory";
            cmd.CommandText = query;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = int.Parse($"{reader[0]}");
                    int inStock = int.Parse($"{reader[1]}");
                    int onOrder = int.Parse($"{reader[2]}");

                    inventory.Add(id, (inStock, onOrder));
                }
            }

            return inventory;
        }

        /// <summary>
        /// Populate the inventory list DataTable
        /// </summary>
        /// <param name="dt">reference to inventory list datatable</param>
        /// <param name="inventory">reference to inventory dictionary</param>
        /// <param name="products">reference to products dictionary</param>
        private void PopulateInvTable(ref DataTable dt, ref Dictionary<int, (int, int)> inventory, ref Dictionary<int, Product> products)
		{
            foreach (KeyValuePair<int, (int, int)> kvp in inventory)
            {
                Product p = products[kvp.Key];

                dt.Rows.Add(p.id, p.name, p.price, kvp.Value.Item1, kvp.Value.Item2);
            }
        }

        /// <summary>
        /// Fill inventory DGV
        /// </summary>
        /// <param name="dt">reference to datatable</param>
        private void FillInvDgv(ref DataTable dt)
		{
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            bs.DataSource = ds.Tables[0];

            dgvInventory.Columns.Clear();
            dgvInventory.DataSource = bs;
        }

        /// <summary>
        /// Set column widths
        /// </summary>
        private void SetColWidths()
		{
            dgvInventory.Columns[0].Width = 60;
            dgvInventory.Columns[1].Width = 135;
            dgvInventory.Columns[2].Width = 75;
            dgvInventory.Columns[3].Width = 70;
            dgvInventory.Columns[4].Width = 70;
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
