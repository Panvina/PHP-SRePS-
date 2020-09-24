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
    public partial class DisplayWeeklySales : Form
    {
        public DisplayWeeklySales()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Login.con;
            //cmd.CommandText = $"SELECT * FROM SALES WHERE MONTH(DATE) = {txtMonth.Text} AND YEAR(DATE) = {txtYear.Text}";
            //cmd.CommandText = $"SELECT * FROM SALES WHERE  MONTH(DATE) = {txtMonth.Text} AND DATE >= dateadd(day, 1-datepart(dw, getdate()), CONVERT(date,getdate())) AND DATE <  dateadd(day, 8-datepart(dw, getdate()), CONVERT(date,getdate()))";
            //cmd.CommandText = $"SELECT * FROM SALES WHERE DATE >= DATE_SUB(GETDATE(), INTERVAL 10 DAY)";
            //cmd.CommandText = $"SELECT * FROM SALES WHERE DATE = DATEPART(week, GETDATE())";
            //cmd.CommandText = $"SELECT * FROM SALES WHERE DATE >= DATEADD(day,-7, GETDATE())";
            //cmd.CommandText = $"SELECT * FROM SALES WHERE  MONTH(DATE) = {txtMonth.Text} AND DATE >= dateadd(day, 2-datepart(dw, getdate()), CONVERT(date,getdate())) AND DATE <  dateadd(day, 9-datepart(dw, getdate()), CONVERT(date,getdate()))";
            cmd.CommandText = $"SELECT * FROM SALES WHERE  MONTH(DATE) = {txtMonth.Text} AND DATE >= dateadd(day, 2-datepart(dw, getdate()), CONVERT(date,getdate())) AND DATE <  dateadd(day, 9-datepart(dw, getdate()), CONVERT(date,getdate()))";
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
