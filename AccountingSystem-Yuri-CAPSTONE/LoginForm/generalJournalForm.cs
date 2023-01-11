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
    public partial class generalJournalForm : Form
    {
        public generalJournalForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
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

       
    }
}
