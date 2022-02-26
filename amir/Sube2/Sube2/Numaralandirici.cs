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
    public partial class Numaralandirici : Form
    {
        public Numaralandirici()
        {
            InitializeComponent();
        }
        enum mevsimler
        {
            ilkbahar = 1,
            yaz,
            sonbahar,
            kis
        }
        enum plakalar
        {
            istanbul = 34,
            Ankara = 06,
            izmir = 35
        }
        enum Aylar : byte
        {
            ocak = 1,
            subat,
            mart

        }
        private void Numaralandirici_Load(object sender, EventArgs e)
        {

        }

        private void btnMevsim_Click(object sender, EventArgs e)
        {
            lstDeneme.Items.Clear();
            foreach (var x in Enum.GetValues(typeof(mevsimler)))
            {
                lstDeneme.Items.Add(x);
            }
        }

        private void btnPlaka_Click(object sender, EventArgs e)
        {
            lstDeneme.Items.Clear();
          foreach(var x in Enum.GetValues(typeof(plakalar)))
            {
                lstDeneme.Items.Add(x);
            }
        }

        private void btnAylar_Click(object sender, EventArgs e)
        {
            lstDeneme.Items.Clear();
            foreach(var x in Enum.GetNames(typeof(Aylar)))
            {
                lstDeneme.Items.Add(x);
            }
        }

        private void lstDeneme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstDeneme.GetItemText(Convert.ToInt32(lstDeneme.SelectedItem));
            lblDeger.Text = "";
            lblDeger.Text = Convert.ToInt32(plakalar.Ankara).ToString();
        }
    }
}
