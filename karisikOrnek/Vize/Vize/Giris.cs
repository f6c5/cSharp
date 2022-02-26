using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vize
{
    public partial class Giris : Form
    {
        ProjeEntities db = new ProjeEntities();
        public Giris()
        {
            InitializeComponent();
        }
        string sifreleme(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(text);
            byte[] sonuc = md5.ComputeHash(dizi);
            return Convert.ToBase64String(sonuc);
        }
        void Guvenlikkodu()
        {
            Random rnd = new Random();
            string GuvenlikKodu = "";
            string harfler = "QAZWSXEDCRFVqazwsxedcrfv123456789!+%&/()=}][{$#£>";

            ///6karakter
            for (int i = 0; i < 6; i++)
            {
                GuvenlikKodu += harfler[rnd.Next(harfler.Length)];
                ///// harfler[1] +   harfler[9]+  harfler[52] 
            }
           lblCaptcha.Text = GuvenlikKodu;
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string decsifre = sifreleme(txtSifre.Text);
                var sonuc = db.tbl_Kullanicilar.Where(x => x.KullaniciAdi == txtAdi.Text && x.Sifre == decsifre).FirstOrDefault();
                if (sonuc != null)
                {
                    //if (lblCaptcha.Text == txtCaptcha.Text)
                    //{
                        sonuc.SonGiris = DateTime.Now.ToString();
                        db.SaveChanges();

                        //2
                        this.Hide();
                        AnaSayfa frm = new AnaSayfa(sonuc.id);
                        frm.ShowDialog();
                    //}
                   // MessageBox.Show("giriş basarli");
                }else
                {
                    MessageBox.Show("kontrol ediniz");
                }
            }
            catch (Exception exp)
            {
                ///log and save to txt file or db
            }
            
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Guvenlikkodu();
        }

        private void lblCaptcha_Click(object sender, EventArgs e)
        {
            Guvenlikkodu();
        }
    }
}
