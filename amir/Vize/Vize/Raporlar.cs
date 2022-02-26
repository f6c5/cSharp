using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize
{
    public partial class Raporlar : Form
    {
        ProjeEntities db = new ProjeEntities();
        public Raporlar()
        {
            InitializeComponent();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ///soforler
                printDocument1.Print();
                dataGridView1.DataSource = db.tbl_soforler.ToList();
            }
            if (radioButton2.Checked)
            {
                ///otobusler
                printDocument2.Print();
                dataGridView1.DataSource = db.tbl_otubusler.ToList();

            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ///soforler
                 printDocument1.Print();
                dataGridView1.DataSource = db.tbl_soforler.ToList();
            }
            if (radioButton2.Checked)
            {
                ///otobusler
                  printDocument2.Print();
                dataGridView1.DataSource = db.tbl_otubusler.ToList();

            }

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
            Bitmap bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            Bitmap bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
