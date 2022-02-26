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
using System.Data.SqlClient;
namespace Sube2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string baglanti2 = "Data Source=YAMIRSEYYEDBBS; Initial Catalog=GorselProgramlama;Integrated security=False;User ID=sa;Password=123";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adres = @"C:\GörselProgramlamaSube2\log.txt";

            try
            {
                string kontrol = "select * from tbl_kisisel3 where ad='" + txtUsername.Text + "' and soyad='" + txtPassword.Text + "' ";
                SqlConnection con = new SqlConnection(baglanti2);
                con.Open();
                SqlCommand com = new SqlCommand(kontrol,con);
                SqlDataReader oku = com.ExecuteReader();
                while (oku.Read())
                {
                    FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
                    StreamWriter str = new StreamWriter(akim);
                    string hata = "+Kullanıcı: " + txtUsername.Text + " Tarih:" + DateTime.Now.ToString() + " Sisteme giriş yaptı.";
                    str.WriteLine(hata);
                    str.Flush();
                    str.Close();


                    AnaSayfa frm = new AnaSayfa();
                    frm.Show();
                    this.Hide();
                }

                con.Close();


                //int password = Convert.ToInt32(txtPassword.Text);
                //if (txtUsername.Text == "Admin" && password==123)
                //{
                    
                  

                //}
                //else
                //{
                //    FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
                //    StreamWriter str = new StreamWriter(akim);
                //    string hata = "**Kullanıcı: " + txtUsername.Text + " Tarih:" + DateTime.Now.ToString() + " hatalı bir giriş yaptı.";
                //    str.WriteLine(hata);
                //    str.Flush();
                //    str.Close();
                //    MessageBox.Show("giriş bilgilerin kontrol ediniz");
                //}
                
            }
            catch (Exception exp)
            {
                FileStream akim = new FileStream(adres, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter str = new StreamWriter(akim);
                string error ="S "+  DateTime.Now.ToString() + "  " + txtUsername.Text +" "+ exp.Source + " " + exp.TargetSite.ToString() + " " + " hatalı bir giriş yaptı";
                str.WriteLine(error);
                str.Flush();
                str.Close();

            }
            finally
            {

            }



        }
    }
}
