using Guna.UI2.WinForms;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using LoginForm.Class;
using System.Xml.Linq;

namespace LoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            register_panel.Visible = false;
        }
        public static class session
        {
            public static string UserID;
        }


        private void register_pn_button_Click(object sender, EventArgs e)
        {
            register_panel.Visible = true;
            //Guna2Transition.ShowSync(register_panel);
        }


        private void login_pn_btn_Click(object sender, EventArgs e)
        {
            register_panel.Visible = false;
           // Guna2Transition.HideSync(register_panel);
        }

        //CREATE ACCOUNT STARTS
        // public static int restrict = 0;

        Authentication auth;

        private void createbtn_Click(object sender, EventArgs e)
        {
            if(txtusr.Text != string.Empty
                && txtname.Text != string.Empty
                && txtpass.Text != string.Empty
                && txtconfirmpass.Text != string.Empty)
            {
                if (txtpass.Text == txtconfirmpass.Text)
                {
                    checkAccount(txtusr.Text);
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }


           /* if (restrict == 0)
            {
                restrict++;
                ConfirmAdmin confirm = new ConfirmAdmin();
                confirm.Show();
                confirm.TopMost = true;
            }
            else
            {
                MessageBox.Show("Please confirm by the administrator first");

            } */
        }

        private void checkAccount(string Username)
        {
            auth = new Authentication();
            auth.CreateDatabase();
            auth.getConnection();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    con.Open();

                    int count = 0;
                    string query = "SELECT * FROM Account WHERE Username ='" + Username + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Account is already created");
                      
                        return;
                    }
                    else if (count == 0)
                    {
                        InsertData(txtusr.Text, txtpass.Text, txtname.Text);
                    }
                    cmd.Dispose();
                    con.Close();
                    reader.Close();
                }

              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }


        private void InsertData(string Username, string Password, string FullName)
        {
            try
            {
                auth = new Authentication();
                auth.getConnection();
                
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"INSERT INTO Account(Username, Password, FullName) VALUES (@Username, @Password, @Fullname)";
                    cmd.CommandText= query;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter ("@Username", Username));
                    cmd.Parameters.Add(new SQLiteParameter ("@Password", Password));
                    cmd.Parameters.Add(new SQLiteParameter ("@FullName", FullName));
                    cmd.ExecuteNonQuery ();
                    MessageBox.Show("The account has been successfully created");
                    register_panel.Visible = false;
                    cmd.Dispose();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //CREATE ACCOUNT END
        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //LOGIN STARTS
        public static string passingtxt;
        public static string usernames;
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            //sign in button
         
            if (txtusr2.Text != string.Empty
                &&txtpass2.Text != string.Empty)
            {
                checkAccount2(txtusr2.Text, txtpass2.Text);
            }



        }

        private void checkAccount2(string Username, string Password)
        {
            
            auth = new Authentication();
            auth.getConnection();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(auth.connectionString))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    string query = @"SELECT * FROM Account WHERE Username='" + Username + "'AND Password = '" + Password + "'";

                    cmd.CommandText = query;
                    cmd.Connection = con;

                    SQLiteDataReader read = cmd.ExecuteReader();
                   
                    if (read.HasRows)
                    {
                        MessageBox.Show("The Password and the Username are right");
                        Dashboard dash = new Dashboard();

                        passingtxt = txtusr.Text;
                        while (read.Read())
                        {
                            session.UserID = read.GetInt32(0).ToString();
                        }

                        cmd.Dispose();
                        con.Close();


                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password. Please try again");
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void txtusr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpass2_TextChanged(object sender, EventArgs e)
        {

        }

        //LOGIN ENDS
    }

        
    }

