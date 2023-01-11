using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Reports : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\Accounting.db";
        SQLiteDataReader dr;

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            getData();

        }
        private void getData()
        {
            
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM voucher_tbl ";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //display data in grid view
                dataGridView.Rows.Insert(0, dr.GetString(3), dr.GetString(2), dr.GetString(5));
            }

            dr.Close();
            con.Close();
            cmd.Dispose();
        }
        
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void search(object sender, EventArgs e)
        {

        }

        private void searchBtnTxtBox_TextChanged(object sender, EventArgs e)
        {
           
            //(dataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("payee LIKE '%{0}%'", searchBtnTxtBox.Text);
        }

        private void btnVoucherFilter_Click(object sender, EventArgs e)
        {
            filterData("DISBURSEMENT VOUCHER CASH/CHECK");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string query = @"SELECT * FROM voucher_tbl WHERE payee LIKE @search";
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@search", '%'+searchBtnTxtBox.Text+'%');

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //display data in grid view
                dataGridView.Rows.Insert(0, dr.GetString(3), dr.GetString(2), dr.GetString(5));
            }

            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void btnAllFilter_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            getData();
        }

        private void btnJournalFilter_Click(object sender, EventArgs e)
        {
            filterData("JOURNAL VOUCHER");
        }

        private void filterData(String type)
        {
            dataGridView.Rows.Clear();
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string query = @"SELECT * FROM voucher_tbl WHERE type LIKE @search";
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@search", '%' + type + '%');

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //display data in grid view
                dataGridView.Rows.Insert(0, dr.GetString(3), dr.GetString(2), dr.GetString(5));
            }

            dr.Close();
            con.Close();
            cmd.Dispose();
        }
    }
}
