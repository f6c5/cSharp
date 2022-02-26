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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }
        public class araba
        {
            public string marka;
            public string model;
            public int motor;
            public float uzunluk;
            public float genislik;
            public virtual float agirlik(float x, float y)
            {
                return x * y;
            }
        }
        public class hesaplama
        {
            public int a;
            public int b;
            public int c;

            public virtual int hesaplma(int x,int y)
            {
                this.c = a + b;
                return c;
            }
            //public hesaplama(int x, int y)
            //{
            //    this.a = x;
            //    this.b = y;
            //    this.c = (a + b);
            //}
        }
        public class A : hesaplama
        {

        }
        public class B : hesaplama
        {
            public override int hesaplma(int x, int y)
            {
                if (a < b)
                {
                    this.c = a * b;
                    return c;
                }
                else
                {
                    this.c = a / b;
                    return c;
                }
                
            }
        }
        private void Class_Load(object sender, EventArgs e)
        {
           
            //hesaplama(5, 9);
           //araba vw = new araba();
            //vw.marka = "Vw";
            //vw.model = "polo";
            //vw.uzunluk = 2.7f;
            //vw.genislik = 3.9f;
            //float agirlik = vw.agirlik(vw.uzunluk, vw.genislik);



        }

        private void btnOlay_Click(object sender, EventArgs e)
        {
            A ornek = new A();

            ornek.a =Convert.ToInt32( txtA.Text);
            ornek.b =Convert.ToInt32( txtB.Text);
            lblOrnek.Text = ornek.hesaplma(ornek.a, ornek.b).ToString();

        }

        private void btnOlayB_Click(object sender, EventArgs e)
        {
            B ornek = new B();

            ornek.a = Convert.ToInt32(txtA.Text);
            ornek.b = Convert.ToInt32(txtB.Text);
            lblOrnek.Text = ornek.hesaplma(ornek.a, ornek.b).ToString();
        }
    }
}
