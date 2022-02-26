using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sube2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linq frm = new Linq();
            frm.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string adres = @"C:\GörselProgramlamaSube2\log.txt";
            FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter str = new StreamWriter(akim);
            string hata = "Kullanıcı: " +  " Tarih:" + DateTime.Now.ToString() + " Sistemden Çıkış yaptı.";
            str.WriteLine(hata);
            str.Flush();
            str.Close();
            this.Close();
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if ((x) is Button){
                    x.Font = new System.Drawing.Font("Arial", 7);
                   
                }
            }
           
        }

        private void yazıRenkleriDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if ((x) is Button)
                {
                    x.ForeColor = Color.Red;

                }
            }

        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.Text = "Bir renk seçiniz...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            tsslTime.Text =dt.DayOfWeek+"/"+ dt.Hour + ":" + dt.Minute + ":" + dt.Second;

        }

        private void iletşimToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            object[] hafta = new object[] {"Pztesi","Salı","çarşamba","perşembe","cuma","cumartesi","pazar" };
            comboBox1.Items.AddRange(hafta);

          //  tabControl1.TabIndex = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Beyaz")
            {
                this.BackColor = Color.White;
            }
            if(comboBox1.SelectedItem=="Mavi")
            {
                this.BackColor = Color.Blue;
            }
        //    label1.Text = comboBox1.SelectedValue.ToString();
            label2.Text = comboBox1.SelectedText.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked)
                MessageBox.Show("Erkek");
            if (rdb2.Checked)
                MessageBox.Show("Kadin");
        }
    }
}
