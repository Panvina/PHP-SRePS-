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

            DateTime StartDate = tpDate.Value;  //gets the date from the date picker              
            StartDate = DateTime.Parse(StartDate.ToString()).StartOfWeek(DayOfWeek.Monday); //gets the starting date in that week based on the date

            DateTime EndDate = StartDate; 
            EndDate = EndDate.AddDays(6); //gets the ending date of that week
            


            string stringStartDate = StartDate.ToString("yyyy-MM-dd"); //gets rid of the time part of the date, and to be used for the query
            string stringEndDate = EndDate.ToString("yyyy-MM-dd"); //gets rid of the time part of the date, and to be used for the query
        
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Login.con;          
            cmd.CommandText = $"SELECT * FROM SALES WHERE DATE between '{stringStartDate}' AND '{stringEndDate}' ";
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();                     // create new dataset

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;        // stores records from command
            adapter.Fill(ds);                   // fills dataset with records

            bs.DataSource = ds.Tables[0];       // set datasource of new BindingSource

            dgvDisplay.DataSource = bs;           // set datasource of data grid view
        }

        private void tpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }


    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
