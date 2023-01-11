using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class settings : Form
    {
        string cs = @"URI=file:" + Application.StartupPath + "\\Accounting.db";
        SQLiteDataReader dr;

        public settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(txtname.Text != gunaTextBox1.Text)
            {
                pictureBox1.Visible = true;
                label3.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
                label3.Visible = false;
                int id = int.Parse(loginForm.session.UserID);

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                var cmd2 = new SQLiteCommand(con);


                //data checking and insertion
                try
                {
                    string stm = @"SELECT * FROM Account WHERE ID = @id AND Password = @password";
                    cmd2.CommandText = stm;
                    cmd2.Connection = con;

                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.Parameters.AddWithValue("@password", gunaTextBox1.Text);

                    dr = cmd2.ExecuteReader();


                    if (dr.HasRows)
                    {

                        string query = @"UPDATE Account SET Password = @password WHERE ID = @id";
                        cmd.CommandText = query;
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@password", gunaTextBox2.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password changed!");

                        gunaTextBox2.Text = "";
                        txtname.Text = "";
                        gunaTextBox1.Text = "";
                        pictureBox1.Visible = false;
                        label3.Visible = false;
                    }
                    else
                    {
                        pictureBox1.Visible = true;
                        label3.Text = "Wrong password";
                        label3.Visible = true;
                    }



                    dr.Close();
                    cmd.Dispose();
                    cmd2.Dispose();
                    con.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Error");
                }
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label3.Visible = false;
        }
    }
}
