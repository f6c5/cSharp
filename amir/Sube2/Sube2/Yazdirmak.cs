using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube2
{
    public partial class Yazdirmak : Form
    {
        public Yazdirmak()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dlr = printDialog1.ShowDialog();
            if (dlr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("arial", 30);
            Font myFont2 = new Font("arial", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen mypen = new Pen(Color.Red);
            //
            e.Graphics.DrawLine(mypen, 100, 100, 700, 100);
            e.Graphics.DrawString("Beykent Üniversitesi", myFont, sbrush, 180, 150);
               
            e.Graphics.DrawLine(mypen, 100, 200, 700, 200);
            //
            int y = 300;
            foreach(var x in listBox1.Items)
            {
                e.Graphics.DrawString(x.ToString(), myFont2, sbrush, 150, y);
                y += 30;
            }
            e.Graphics.DrawLine(mypen, 200, y, 600, y);
            ///
            string toplam = "1500 TL";
            e.Graphics.DrawString("toplam:" + toplam, myFont2, sbrush, 350, y+10);
        }

        private void Yazdirmak_Load(object sender, EventArgs e)
        {

        }
    }
}
