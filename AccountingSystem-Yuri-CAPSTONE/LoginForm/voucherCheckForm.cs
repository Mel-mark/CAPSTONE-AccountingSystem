using LoginForm.Class;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class voucherCheckForm : Form
    {

        string cs = @"URI=file:" + Application.StartupPath + "\\Accounting.db";
        Authentication auth;

        public voucherCheckForm()
        {
            InitializeComponent();
        }
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("Account Code");
            ss.Columns.Add("Account Title");
            ss.Columns.Add("Debit");
            ss.Columns.Add("Credit");

            DataRow row = ss.NewRow();
            /*   row["Account Code"] = "97342";
               row["Account Title"] = "Total Service Loan";
               row["Debit"] = "5,000";
               row["Credit"] = "3,000"; */
            ss.Rows.Add(row);

            foreach (DataRow Drow in ss.Rows)
            {
                int num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = Drow["Account Code"].ToString();
                dataGridView1.Rows[num].Cells[0].Value = Drow["Account Title"].ToString();
                dataGridView1.Rows[num].Cells[0].Value = Drow["Debit"].ToString();
                dataGridView1.Rows[num].Cells[0].Value = Drow["Credit"].ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            insertVoucher();
        }
        private void insertVoucher()
        {
            String Type = DashboardForm.typeOFvoucher;
           
            String Voucher = textBox1.Text;
            String Date = textBox2.Text;
            String Payee = textBox3.Text;
            String Address = textBox4.Text;
            String SoF = " ";

            String Account = " ";
            String Tittle = " ";
            String Debit = " ";
            String Credit = " ";


            // Source of found
            bool isChecked1 = guna2CustomRadioButton1.Checked;
            bool isChecked2 = guna2CustomRadioButton2.Checked;
            bool isChecked3 = guna2CustomRadioButton3.Checked;

            if (isChecked1)
                SoF = "LBP SA# 1571-0103-87";
            if (isChecked2)
                SoF = "LBP SA# 1571-0583-39";
            if (isChecked3)
                SoF = "LBP CA# 1572-1021-53";

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            long rowID;
            Console.WriteLine(Voucher + SoF + Date + Payee + Address);
            //data checking and insertion
            try
            {
                string query = @"INSERT INTO voucher_tbl(v_n,date,payee,address,SoF,type) VALUES(@v_n,@date,@payee,@address,@SoF,@type)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@v_n", Voucher);
                cmd.Parameters.AddWithValue("@date", Date);
                cmd.Parameters.AddWithValue("@payee", Payee);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@SoF", SoF);
                cmd.Parameters.AddWithValue("@type", Type);

                cmd.ExecuteNonQuery();

                rowID = con.LastInsertRowId;
                cmd.Dispose();
                con.Close();
              
                //get data from datagrid
                
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {

                    if (dataGridView1.Rows[rows].Cells[0].Value != null)
                    {
                        if (dataGridView1.Rows[rows].Cells[2].Value != null)
                        {
                            Debit = dataGridView1.Rows[rows].Cells[2].Value.ToString();
                        }
                        else
                        {
                            Debit = " ";
                        }
                        if (dataGridView1.Rows[rows].Cells[3].Value != null)
                        {
                            Credit = dataGridView1.Rows[rows].Cells[3].Value.ToString();
                        }
                        else
                        {
                            Credit = " ";
                        }
                        Account = dataGridView1.Rows[rows].Cells[0].Value.ToString();
                        Tittle = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                        insertAccount(rowID, Account, Tittle, Debit, Credit);
                        Console.WriteLine(Account + Tittle + Debit + Credit);
                    }
                }
                insertParticular(rowID);
                insertPayment(rowID);
                insertSignature(rowID);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }
        }
        private void insertAccount(long Id, String Account, String Tittle, String Debit, String Credit)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                auth = new Authentication();
                auth.getConnection();

                string query = @"INSERT INTO accountingEntry_tbl(v_id,acc_code,acc_title,debit,credit) VALUES(@v_id,@acc_code,@acc_title,@debit,@credit)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@v_id", Id);
                cmd.Parameters.AddWithValue("@acc_code", Account);
                cmd.Parameters.AddWithValue("@acc_title", Tittle);
                cmd.Parameters.AddWithValue("@debit", Debit);
                cmd.Parameters.AddWithValue("@credit", Credit);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }
        }
        private void insertParticular(long id)
        {
            String comment1 = " ";
            String comment2 = " ";
            String comment3 = " ";
            String amount_due = " ";

            if(textBox10 != null)
            {
                comment1 = textBox10.Text;
            }

            if(textBox9 != null)
            {
                comment2 = textBox9.Text;
            }
            if(textBox8 != null)
            {
                comment3 = textBox8.Text;
            }
            if(textBox6 != null)
            {
                amount_due = textBox6.Text;
            }

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                auth = new Authentication();
                auth.getConnection();

                string query = @"INSERT INTO particular_tbl(v_id,comment1,comment2,comment3,ammount_due) VALUES(@v_id,@comment1,@comment2,@comment3,@amount_due)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@v_id", id);
                cmd.Parameters.AddWithValue("@comment1", comment1);
                cmd.Parameters.AddWithValue("@comment2", comment2);
                cmd.Parameters.AddWithValue("@comment3", comment3);
                cmd.Parameters.AddWithValue("@amount_due", amount_due);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }
        }
        private void insertPayment(long id)
        {
            //type of payment
            String ToP = " ";
            bool loan = guna2CustomRadioButton4.Checked;
            bool replenishment = guna2CustomRadioButton5.Checked;
            bool payment = guna2CustomRadioButton6.Checked;

            bool sbma_bills = guna2CustomRadioButton7.Checked;
            bool tie_up = guna2CustomRadioButton8.Checked;
            bool others = guna2CustomRadioButton9.Checked;

            string specify = textBox5.Text;

            if (loan)
            { 
                ToP = "Loan";
            }
            if (replenishment)
            {
                ToP = "Replenishment";
            }
            if (payment)
            {
                if (sbma_bills)
                {
                    ToP = "SBMA Bills";
                }
                if (tie_up)
                {
                    ToP = "Tie-Up";
                }
                if (others)
                {
                    ToP = specify;
                }
            }
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                auth = new Authentication();
                auth.getConnection();

                string query = @"INSERT INTO payment_tbl(v_id,Type_of_payment) VALUES(@v_id,@Type_of_payment)";
                cmd.CommandText = query;
                cmd.Connection = con;
            
                cmd.Parameters.AddWithValue("@v_id", id);
                cmd.Parameters.AddWithValue("@Type_of_payment", ToP);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }
        }
        private void insertSignature(long id)
        {
            String Approved_by = " ";
            string Received_by = " ";

            // Signature
            Approved_by = textBox11.Text;
            Received_by = textBox13.Text;

            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                auth = new Authentication();
                auth.getConnection();

                string query = @"INSERT INTO signature_tbl(v_id,approved_by,recieve_by) VALUES(@v_id,@approved_by,@recieve_by)";
                cmd.CommandText = query;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@v_id", id);
                cmd.Parameters.AddWithValue("@approved_by", Approved_by);
                cmd.Parameters.AddWithValue("@recieve_by", Received_by);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                MessageBox.Show("Data Saved!");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error");
            }

        }
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void guna2CustomRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            guna2CustomRadioButton7.Enabled = true;
            guna2CustomRadioButton8.Enabled = true;
            guna2CustomRadioButton9.Enabled = true;
        }

        private void guna2CustomRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = false;

        }

        private void guna2CustomRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void voucherCheckForm_Load(object sender, EventArgs e)
        {
            label3.Text = DashboardForm.typeOFvoucher;

            guna2CustomRadioButton8.Enabled = false;
            guna2CustomRadioButton9.Enabled = false;
            guna2CustomRadioButton7.Enabled = false;
            textBox5.Enabled = false;
        }

        private void guna2CustomRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            guna2CustomRadioButton8.Enabled = false;
            guna2CustomRadioButton9.Enabled = false;
            guna2CustomRadioButton7.Enabled = false;
            textBox5.Enabled = false;
        }

        private void guna2CustomRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            guna2CustomRadioButton8.Enabled = false;
            guna2CustomRadioButton9.Enabled = false;
            guna2CustomRadioButton7.Enabled = false;
            textBox5.Enabled = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
