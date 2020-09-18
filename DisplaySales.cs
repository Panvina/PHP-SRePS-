﻿using System;
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
    public partial class DisplaySales : Form
    {
        public DisplaySales()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        private void DisplaySales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPdbDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.pHPdbDataSet.Orders);

        }

        private bool ValidateID()
        {
            //Set lblWarning to invisible
            lblWarning.Visible = false;

            int parsedValue;
            if (!int.TryParse(txtIdInput.Text, out parsedValue))
            {
                lblWarning.Visible = true;
                return false;
            }

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.Sales", Login.con);

            int maxID = Convert.ToInt32(cmd.ExecuteScalar());

            if (!(Convert.ToInt32(txtIdInput.Text) <= maxID && Convert.ToInt32(txtIdInput.Text) > 0))
            {
                lblWarning.Visible = true;
                return false;
            }
            //Check if ID is in Sales table, return false if not
            //Also set lblWarning to visible if returning false
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(ValidateID())
            {
                SqlCommand cmd = new SqlCommand($"Select * FROM dbo.Sales WHERE SalesID LIKE {txtIdInput.Text}", Login.con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //insert data
                    dgvDisplay.Rows[0].Cells[0].Value = reader.GetInt32(0);
                    dgvDisplay.Rows[0].Cells[1].Value = reader.GetString(1);
                    dgvDisplay.Rows[0].Cells[2].Value = reader.GetInt32(2);
                    dgvDisplay.Rows[0].Cells[3].Value = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                }

                reader.Close();
            }
        }
    }
}
