using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;
namespace Sube2
{
    public partial class Captcha : Form
    {  
        public Captcha()
        {
            InitializeComponent();
        }
         /// <summary>
         /// ////fonksiyon
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Captcha_Load(object sender, EventArgs e)
        {
            string time;
            time = (DateTime.Now.Hour + DateTime.Now.Minute).ToString();
            Guvenlikkodu();
            int kod=GuvenlikKodu2(time);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Guvenlikkodu();
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
            lblKod.Text = GuvenlikKodu;
        }

        int GuvenlikKodu2(string x)
        {
            int a = DateTime.Now.Second;
            int b = Convert.ToInt32(x);
            int kod = (b * 100) * a;
            return kod;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Ali" && txtPass.Text == "123" && txtKod.Text == lblKod.Text)
            {
                Tarayici frm = new Tarayici();
                frm.Show();
            }
            else
                MessageBox.Show("tekrar kontrol ediniz");
        }
    }
}
