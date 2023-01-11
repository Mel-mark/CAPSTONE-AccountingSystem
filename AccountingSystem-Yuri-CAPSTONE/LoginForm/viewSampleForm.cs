using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class viewSampleForm : Form
    {
        public viewSampleForm()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
            //  Rectangle pagearea = e.PageBounds;
            // e.Graphics.DrawImage(memorying,0,0);
            // (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y)
        }
     


/*
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

       // Bitmap memorying;


        private void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0,0,pnl.Width,pnl.Height));
        } */
        Bitmap bitmap;

       



        private void printBtn_Click(object sender, EventArgs e)
        {
            //Print(this.panel1);

            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

      
    }
}
