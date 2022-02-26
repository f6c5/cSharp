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
    public partial class Tarih : Form
    {
        public Tarih()
        {
            InitializeComponent();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            //int x = int.Parse(txtOrnek.Text);
            //MessageBox.Show(x.GetType().ToString());
            ///eğer haftanın cuma günündeyiz bir ata sozu gösterelim
            //if (lblsonuc.Text == "Sunday")
            //{
            //    MessageBox.Show("Ata sozu");
            //}
        }

        private void Tarih_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //lblsonuc.Visible = true;
            //lblsonuc.Text = dt.ToString("dd/MM/yyyy HH:mm");
            lblsonuc.Visible = true;
            for (int i = 0; i < 5; i++)
            {
                lblsonuc.Text += "C# \n";
            }
        }
    }
}
