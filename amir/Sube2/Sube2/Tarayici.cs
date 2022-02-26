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
    public partial class Tarayici : Form
    {
        public Tarayici()
        {
            InitializeComponent();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void durToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri adres = new Uri("http://" + txtURL.Text);
            webBrowser1.Url = adres;
        }

        private void Tarayici_Load(object sender, EventArgs e)
        {
            Uri adres = new Uri("http://beykent.edu.tr");
            webBrowser1.Url = adres;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);

            }
            catch
            {

            }
        }
    }
}
