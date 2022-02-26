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
    public partial class Dizi : Form
    {
        public Dizi()
        {
            InitializeComponent();
        }

        private void Dizi_Load(object sender, EventArgs e)

        {
            lstOrnek.Items.Add("C# Beykent");
            lstOrnek.Items.Add("Görsel Programlama");
            //int[] dizi = new int[10];
            //int[] dizi2= { 101, 75, 42 };        ////0 1 2

            //for(int i = 0; i < dizi2.Length; i++)
            //{
            //    lblOrnek.Text +=dizi2[i].ToString() + " ";
            //}
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            char[] harflar = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'ü', 'u' };

            string kelime = txtOrnek.Text;
            for (int i = 0; i < kelime.Length; i++)
            {
                ///beykent
                for (int j = 0; j < harflar.Length; j++)
                {
                    //a
                    if (kelime[i] == harflar[j])   ///kelime.Length* harflar.Length
                    {
                        lblOrnek.Text += harflar[j] + " ";
                    }
                }
            }
        }

        private void btnDizi_Click(object sender, EventArgs e)
        {
            ///// birini eleman:  kapasite
            /////  ikinci eleman: yerleşim 1:salon  2:bahçe

            int[,] masalar;
            masalar = new int[,] { { 4, 2 }, { 2, 2 }, { 4, 1 }, { 2, 2 }, { 2, 1 } };
            int kapasite = 0, salon = 0, bahce = 0, deger = 0;
            ///kaç tane masa bahçe ?kaç masa salon? toplamda kaç kişilik kapasitesi var nu kafenin?
            ///
            for (int i = 0; i < masalar.GetLength(0); i++)   ///sutun
            {
                for (int j = 0; j < masalar.GetLength(1); j++)    ///satir
                {
                    deger = Convert.ToInt16(masalar.GetValue(i, j));
                    if (j == 0)
                    { kapasite += deger; }
                    if (j == 1)
                    {
                        //1salon 2bahce
                        if (deger == 1) salon++;
                        else if (deger == 2) bahce++;
                    }
                    //lblOrnek.Text+= deger+" ";
                }

            }
            lblOrnek2.Text = "kapasiete" + kapasite.ToString() + " salon:" + salon.ToString() + " bahce:" + bahce.ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] sayilar = new int[15];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(0, 100);
                lblOrnek.Text += sayilar[i] + " ";
            }
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            for (int j = 0; j < sayilar.Length; j++)
            {
                lblOrnek2.Text += sayilar[j] + " ";
                lblornek3.Text += j.ToString() + " ";

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string[] isimler = { "elif", "emre" };
            int sonuc = Array.IndexOf(isimler, txtOrnek.Text);
            //lblOrnek.Text = sonuc.ToString();
            if (sonuc == -1)
            {
                MessageBox.Show("kullanıcı adınızı kontrol ediniz..");
            }

        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            int[] dizi2 = { 101, 75, 42 };
            int toplam = 0;
            foreach(var x in dizi2)
            {
                toplam += x;
            }
            lblOrnek.Text = toplam.ToString();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if((x) is Label)
                {
                    x.BackColor = Color.Red;
                    x.ForeColor = Color.Yellow;
                    x.Cursor = Cursors.Hand;
                }
            }
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            lstOrnek.Items.Add(txtOrnek.Text);
        }
    }
}
