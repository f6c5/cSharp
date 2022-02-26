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
    public partial class Soforler : Form
    {
        public Soforler()
        {
            InitializeComponent();
        }
        public class soforler
        {
            public string ad;
            public string soyad;
            public string tel;
        }
        ProjeEntities db = new ProjeEntities();
        private void Soforler_Load(object sender, EventArgs e)
        {
            goster();
        }
        

        private void btnOnay_Click(object sender, EventArgs e)
        {
            soforler sofor = new soforler();
            sofor.ad = txtAd.Text;
            sofor.soyad = txtSoyad.Text;
            sofor.tel = txtTell.Text;

            ///

            tbl_soforler tbl = new tbl_soforler();
            tbl.Ad = sofor.ad;
            tbl.SoyAd = sofor.soyad;
            tbl.Telefon = sofor.tel;
            db.tbl_soforler.Add(tbl);
            db.SaveChanges();
         //   lstSoforler.Visible = true;
            string veri;

            veri = sofor.ad + "  " + sofor.soyad + "  " + sofor.tel;
          //  lstSoforler.Items.Add(veri);

        }
        void goster()
        {
            dataGridView1.DataSource = db.tbl_soforler.ToList();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
