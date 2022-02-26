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
    public partial class otobusler : Form
    { ProjeEntities db = new ProjeEntities();
        public otobusler()
        {
            InitializeComponent();
        }
        public  class bilet
        {
            public string ad;
            public string soyad;
            public string TC;
            public string tel;
            public string cinsiyet;
            public string No;
        }
      
        private void btnOnay_Click(object sender, EventArgs e)
        {
            string cinsiyet="";
            if (radioButton1.Checked)
                cinsiyet = "bay";
            if (radioButton2.Checked)
                cinsiyet = "bayan";
            int idk = Convert.ToInt32(txtNo.Text);
            var sonuc = db.tbl_biletler.Where(x => x.seferid == _seferid && x.id == idk).FirstOrDefault();
            sonuc.Ad = txtAd.Text;
            sonuc.SoyAd = TxtSoyAd.Text;
            sonuc.TC = txtTC.Text;
            sonuc.koltukNO =idk;
            sonuc.Cinsiyet = cinsiyet.ToString();
            db.SaveChanges();

            //bilet yolcu = new bilet();
            //string veri;
            //yolcu.ad = txtAd.Text;
            //yolcu.soyad = TxtSoyAd.Text;
            //yolcu.TC = txtTC.Text;
            //yolcu.No = txtNo.Text;
            //if (radioButton1.Checked)
            //    yolcu.cinsiyet = "Bay";
            //if (radioButton2.Checked)
            //    yolcu.cinsiyet = "Bayan";
            //veri ="Ad:"+ yolcu.ad + " SoyAd: " + yolcu.soyad + " " + yolcu.TC + " " + yolcu.No + " " + yolcu.cinsiyet;
            //listBox1.Items.Add(veri);
            //secili.Enabled = false;


            //if (radioButton1.Checked)
            //    secili.BackColor = Color.Blue;
            //if (radioButton2.Checked)
            //    secili.BackColor = Color.Pink;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void otobusler_Load(object sender, EventArgs e)
        {
            //  comboBox1.DataSource = db.tbl_seferler.ToList();
            //nereden nereye
            var sonuc = (from x in db.tbl_seferler select new { Value = x.id, Names = x.Nereden + " " + x.Nereye }).ToList();
            comboBox1.DataSource = sonuc;
            comboBox1.DisplayMember = "Names";
            comboBox1.ValueMember = "value";
            comboBox1.SelectedIndex = 1;
                
        }
        public int _seferid;
        void araba(int seferid)
        {
             
            var sonuc = db.tbl_biletler.Where(x => x.seferid == seferid).ToList();
            _seferid =Convert.ToInt32( sonuc[1].seferid);
            int koltuk = sonuc.Count;
            int bosluk = 3;
            int basilacak = 0;
            int atlanan = 0;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= koltuk + atlanan; i++)
            {
                ////dinamik button
                Button btn = new Button();
                btn.Width = 40;
                btn.Margin = new Padding(all: 1);
                if (bosluk == i)
                {
                    bosluk += 5;
                    btn.Height = 0;
                    atlanan++;
                }
                else if (bosluk != i)
                {
                    basilacak++;
                    btn.Height = 40;
                    btn.Text = basilacak.ToString();
                    btn.Tag = basilacak;

                }
                if (sonuc[(i - 1) - atlanan].Cinsiyet == "Bayan")
                {
                    btn.BackColor = Color.Aqua;
                }
                if (sonuc[(i - 1) - atlanan].Cinsiyet == "Bay")
                {
                    btn.BackColor = Color.Red;
                }
                if (sonuc[(i - 1) - atlanan].Durum != true)
                {
                    btn.Enabled = false;
                }
                    btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
            Label kapi = new Label();
            kapi.Width = 80;
            kapi.Height = 40;
            kapi.Text = "kapi";
            kapi.BackColor = Color.Red;
            flowLayoutPanel1.Controls.Add(kapi);
        }
        Button secili;
        void btn_Click(object sender, EventArgs e)
        {
            Button btn2 = sender as Button;
            txtNo.Text = btn2.Tag.ToString();
            groupBox1.Enabled = true;

            secili = btn2;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(comboBox1.SelectedValue.ToString(), out id);
            if (result)
            {
                araba(id);
                dataGridView1.DataSource = db.tbl_biletler.Where(x => x.seferid == id).ToList();

            }
            else { return; }
        }
    }
}
