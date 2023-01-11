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

    public partial class DashboardForm : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\Accounting.db";
        SQLiteDataReader dr;

        public static string typeOFvoucher = "";

        public DashboardForm()
        {
            InitializeComponent();
           
        }

      

       

        private void voucherBtn_Click(object sender, EventArgs e)
        {
            typeOFvoucher = "DISBURSEMENT VOUCHER CASH/CHECK";

            voucherCheckForm log = new voucherCheckForm();
            log.Show();
          
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            typeOFvoucher = "JOURNAL VOUCHER";
            voucherCheckForm log = new voucherCheckForm();
            log.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            cardData();
        }
        private void cardData()
        {
          
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            string query = @"SELECT type FROM voucher_tbl ";
            cmd.CommandText = query;
            cmd.Connection = con;

            dr = cmd.ExecuteReader();
            int voucher = 0;
            int journal = 0;
            int transac = 0;
            while (dr.Read())
            {
                if(dr.GetString(0) == "JOURNAL VOUCHER")
                {
                    journal++;
                }
                else
                {
                    voucher ++;
                }
                transac++;
            }
            label5.Text = voucher.ToString();
            label8.Text = journal.ToString();
            label11.Text = transac.ToString();
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
