
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            loadForm(new DashboardForm());

        }
        
        public void loadForm(object Form)
        {
            //Dashboard mainpanel
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        
        //Navigation Buttons
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }
       

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Reports());
        }
        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new Analytics());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            loadForm(new settings());
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            loginForm log = new loginForm();
            log.Show();
            this.Hide();
        }

        //Navigation Buttons End


        private void close_btn_Click(object sender, EventArgs e)
        {
            
            //this.Dispose();
            if (MessageBox.Show ("Are you sure you want to close the application?", "Upfront Workflow", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void applicationFormBtn_Click(object sender, EventArgs e)
        {
            loadForm(new applicationFormView());
        }
    }
}
