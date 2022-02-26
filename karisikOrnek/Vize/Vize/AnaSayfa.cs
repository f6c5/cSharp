using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize
{
    public partial class AnaSayfa : Form
    {
        ProjeEntities db = new ProjeEntities();
        public AnaSayfa(int id)
        {
            InitializeComponent();
            var sonuc = db.tbl_Kullanicilar.Where(x => x.id == id).FirstOrDefault();
            tstpID.Text = sonuc.Ad;
            tstpTime.Text = sonuc.SonGiris;

        }

        private void şoförlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soforler frm = new Soforler();
            frm.Show();

        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seferler frm = new Seferler();
            frm.Show();
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otobusler frm = new otobusler();
            frm.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar frm = new Raporlar();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
