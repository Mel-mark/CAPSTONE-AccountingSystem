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

namespace LoginForm
{
    public partial class ConfirmAdmin : Form
    {
        public ConfirmAdmin()
        {
            InitializeComponent();
        }

       // Authentication auth;
        private void confirmbtn_Click(object sender, EventArgs e)
        {
          /*  loginForm x = new loginForm();
            x.Show();
            this.Close(); */
        }

       

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
           // loginForm.restrict = 0;
        }

        private void confirmbtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
