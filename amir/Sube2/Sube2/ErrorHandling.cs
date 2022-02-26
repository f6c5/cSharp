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
    public partial class ErrorHandling : Form
    {
        public ErrorHandling()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);
                ///a ve b
                char oper = Convert.ToChar(txtOper.Text);
                switch (oper)
                {

                    case '+':
                        c = a + b;
                        lblSonuc.Text = c.ToString();
                        break;
                    case '-':
                        c = a - b;
                        lblSonuc.Text = c.ToString();
                        break;
                    case '*':
                        c = a * b;
                        lblSonuc.Text = c.ToString();
                        break;
                    case '/':
                        c = a / b;
                        lblSonuc.Text = c.ToString();
                        break;
                    default:
                        lblSonuc.Text = "yalnış bir giriş yapıldır.";
                        break;

                }
            }
            catch (DivideByZeroException)
            {
                lblSonuc.Text = "bölen sıfır olamaz";
            }
            catch (FormatException)
            {
                lblSonuc.Text = "Hatalı giriş!!!";
            }
            catch
            {
                lblSonuc.Text = "tanımlanmayan bir hata oluştu";
            }

            finally
            {
                MessageBox.Show("Tamam");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ///A
                ///
                try
                {
                    int[] dizi = new int[] { 15, 16, 75 };
                    //     int[] dizi = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        lblSonuc.Text += dizi[i].ToString();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Dizi");
                }


                int a, b, c;
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);
                ///a ve b
                char oper = Convert.ToChar(txtOper.Text);
                c = a + b;
                lblSonuc.Text = c.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btnDeneme_Click(object sender, EventArgs e)
        {

            try
            {
                int[] dizi = new int[] { 15, 16, 75 };
                //     int[] dizi = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    lblSonuc.Text += dizi[i].ToString();
                }
            }
            catch (Exception a)
            {
                lblSonuc.Text = a.TargetSite.ToString();
            }
        }

    }
}
