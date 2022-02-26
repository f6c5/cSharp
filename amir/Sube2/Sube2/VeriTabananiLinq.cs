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
    public partial class VeriTabananiLinq : Form
    {
        public VeriTabananiLinq()
        {
            InitializeComponent();
        }
        //global
        GorselProgramlamaEntities db = new GorselProgramlamaEntities();  //model
        private void btnInsert_Click(object sender, EventArgs e)
        {
            tbl_kisisel3 tbl = new tbl_kisisel3();    //tablolar
            tbl.ad = txtAd.Text;
            tbl.soyad = txtSoyad.Text;
            db.tbl_kisisel3.Add(tbl);  //insert  row
            db.SaveChanges();
            btnSelect.PerformClick();
        }

        private void VeriTabananiLinq_Load(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = db.tbl_kisisel3.ToList();
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            int kod =Convert.ToInt32( txtIdU.Text);
            var sonuc = db.tbl_kisisel3.Where(x => x.id == kod).FirstOrDefault();
            if (sonuc != null)
            {
                sonuc.ad = txtAdU.Text;
                sonuc.soyad = txtSoyadU.Text;
                db.SaveChanges();
                btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("böyle bir kayıt yoktur");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(txtId.Text);

            var sonuc = db.tbl_kisisel3.Where(x => x.id == kod).FirstOrDefault();
            if(sonuc!=null)
            {
                db.tbl_kisisel3.Remove(sonuc);
                db.SaveChanges();
                btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show("böyle bir kayıt yoktur");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             
            if (rdbID.Checked)
            {
                int id = Convert.ToInt16(txtSearch.Text);
                var sonuc= db.tbl_kisisel3.Where(x => x.id == id).ToList();
                if (sonuc.Count != 0)
                {
                    dataGridView1.DataSource = sonuc;
                    lblMesaj.Visible = false;
                }else
                {
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "böyle bir kayıt yoktur ";
                }
            }
            if (rdbAd.Checked)
            {
                 
                var sonuc = db.tbl_kisisel3.Where(x => x.ad == txtSearch.Text).OrderByDescending(x=>x.id).ToList();
                if (sonuc.Count != 0)
                {
                    dataGridView1.DataSource = sonuc;
                    lblMesaj.Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "böyle bir kayıt yoktur ";
                }
            }
            if (rdbSoyAd.Checked)
            {

                var sonuc = db.tbl_kisisel3.Where(x => x.soyad.Contains( txtSearch.Text)).ToList();
                if (sonuc.Count != 0)
                {
                    dataGridView1.DataSource = sonuc;
                    lblMesaj.Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "böyle bir kayıt yoktur ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sonuc2 = db.tbl_kisisel3.ToList();
            lblMesaj.Visible = true;
            lblMesaj.Text = sonuc2.Count.ToString();
            //int kod;
            //kod = Convert.ToInt32(txtSearch.Text);
            //switch (rdbAd.Checked)
            //{
            //    case true:
            //        lblMesaj.Visible = true;
            //        lblMesaj.Text = "1";
            //        break;


            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           int kod=Convert.ToInt32( dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            txtId.Text = kod.ToString();
            txtIdU.Text = kod.ToString();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            ///usernem ve password
            var sonuc = db.tbl_kisisel.Where(x => x.ad == txtUser.Text && x.soyad == txtPass.Text).FirstOrDefault();
            if(sonuc != null)
            {
                lblsonuc.Visible = true;
                lblsonuc.Text = sonuc.ad;
            //    Giris frm = new Giris();
              //  frm.Show();
             
            }
            else {
                lblsonuc.Visible = true;
                lblsonuc.Text = "Giriş hatalı"; }
        }
    }
}
