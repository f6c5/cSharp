using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Sube2
{
    public partial class Ornekler12 : Form
    {
        public Ornekler12()
        {
            InitializeComponent();
            //lblOrnek
        }

        private void lblOrnek_Click(object sender, EventArgs e)
        {

            //  lblSifre.Text = txtOrnek.SelectionLength.ToString(); ;
        }

        private void lblOrnek_MouseHover(object sender, EventArgs e)
        {
            //  MessageBox.Show(lblOrnek.Text);
        }

        private void Ornekler12_Load(object sender, EventArgs e)
        {
            txtKuallnici.MaxLength = 10;
            //   txtSifre.PasswordChar = '9';
        }

        private void txtKuallnici_Leave(object sender, EventArgs e)
        {
            //txtKuallnici.SelectionStart = 0;
            //txtKuallnici.SelectionLength = 3;   
            //lblSifre.Text = txtKuallnici.SelectedText;          ///kopy   

        }
        int count = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //string adres = @"C:\GörselProgramlamaSube2\sifre.txt";
            //FileStream akim = new FileStream(adres, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            //StreamReader str = new StreamReader(akim);
            //string sifre;
            //while ((sifre = str.ReadLine()) != null)
            //{
            //    }
            //str.Close();
                if (txtKuallnici.Text == "Ali" && txtSifre.Text == "123")
                {
                    string adres = @"C:\GörselProgramlamaSube2\log.txt";
                    FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
                    StreamWriter str = new StreamWriter(akim);
                    string hata = "Kullanıcı: " + txtKuallnici.Text + " Tarih:" + DateTime.Now.ToString() + " Sisteme giriş yaptı.";
                    str.WriteLine(hata);
                    str.Flush();
                    str.Close();
                    Menu frm = new Menu();
                    frm.Show();
                    this.Hide();
                  
                }
                else
                {
                    string adres = @"C:\GörselProgramlamaSube2\log.txt";
                    FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
                    StreamWriter str = new StreamWriter(akim);
                    string hata = "Kullanıcı: " + txtKuallnici.Text + " Tarih:" + DateTime.Now.ToString() + " hatalı bir giriş yaptı.";
                    str.WriteLine(hata);
                    str.Flush();
                    str.Close();


                    lblMesaj.Visible = true;
                    txtKuallnici.Text = "";
                    txtSifre.Clear();
                    count++;
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = count.ToString();
                    ////5 error
                    if (count >= 3)
                    {
                        txtKuallnici.ReadOnly = true;
                        txtSifre.ReadOnly = true;
                        btnGiris.Enabled = false;
                        MessageBox.Show("IT departamnuyal görüşünüz...");
                    }

                  

            }
           


        }
    }
}
