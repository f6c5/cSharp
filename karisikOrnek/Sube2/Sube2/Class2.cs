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
    public partial class Class2 : Form
    {
        public Class2()
        {
            InitializeComponent();
        }
        abstract public class Ayakkabi
        {
            public string markasi;

            public string malzemesi;
            public byte numarasi;  //////25-46
            private string renk;
            public bool bagicklimi;

            public string Renk
            {
                get { return renk; }
                set
                {
                    if (value == "Beyaz")
                        this.renk = "Mevcut degil";
                    else
                        this.renk = value;
                }
            }
           
        }
        public class Kadin : Ayakkabi
        {
            public string tipi;
        }
        public class Erkek : Ayakkabi
        {
            public string tipi;

        }
        private void Class2_Load(object sender, EventArgs e)
        {


        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            bool bagicik;
            if (checkBox1.Checked)
            {
                bagicik = true;
            }
            else
                bagicik = false;
            Erkek model1 = new Erkek();
            model1.markasi = txtNumarasi.Text;




            //Ayakkabi spor = new Ayakkabi();
            //spor.bagicklimi = bagicik;
            //spor.markasi = txtMarkasi.Text;
            //// spor.tipi = txtTipi.Text;
            //spor.malzemesi = txtMalzemesi.Text;
            //spor.numarasi = Convert.ToByte(txtNumarasi.Text);
            //spor.Renk = txtRenk.Text;
            ////   lstSiparish.Items.AddRange(spor.numarasi,spor.renk);

        }
    }
}
