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
    public partial class Linq : Form
    {
        public Linq()
        {
            InitializeComponent();
        }

        private void Linq_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            lstOrnek.Items.Clear();
            string[] isimler = { "elif", "murat", "yakup", "Muhammet" };
            var sonuc = from x in isimler
                        where x.Contains(txtOrnek.Text)
                        select x;
            //if (sonuc.First().Length == 0)
            //{
            //    MessageBox.Show("SOnuc bulunmadai");

            //}else
            foreach (var a in sonuc)
            {
                lstOrnek.Items.Add(a);
            }
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            try
            {
                int[] sayilar = { 85, 14, 25, 36, 75, 96 };
                int a = Convert.ToInt32(txtOrnek.Text);

                var sonuc1 = sayilar.Where(sayi => sayi > a).OrderByDescending(sayi => sayi);
                foreach (var x in sonuc1)
                {
                    lstOrnek.Items.Add(x);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }
    }
}
