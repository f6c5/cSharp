using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sube2
{
    public partial class VeriTabani : Form
    {
        public VeriTabani()
        {
            InitializeComponent();
        }
        //  string baglanti = "Data Source=YAMIRSEYYEDBBS; Initial Catalog=GorselProgramlama;Integrated security=True";
        string baglanti2 = "Data Source=YAMIRSEYYEDBBS; Initial Catalog=GorselProgramlama;Integrated security=False;User ID=sa;Password=123";
        private void VeriTabani_Load(object sender, EventArgs e)
        {

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Ekle = "Insert into tbl_kisisel3(ad,soyad)values('" + txtAd.Text + "','" + txtSoyad.Text + "')";
            try
            {

                SqlConnection con = new SqlConnection(baglanti2);
                con.Open();
                SqlCommand com = new SqlCommand(Ekle, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarılı");
                button1.PerformClick();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());

                ///STREAM LOG

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string goster = "select * from tbl_kisisel3";
            SqlConnection con = new SqlConnection(baglanti2);

            con.Open();

            SqlCommand com = new SqlCommand(goster,con);
            //com.CommandType = CommandType.Text;
            //SqlDataAdapter dta = new SqlDataAdapter(com);
            //DataSet ds = new DataSet();
            //dta.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            SqlDataReader oku = com.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                listView1.Items.Add(oku["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["ad"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["soyad"].ToString());
            }
            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sil = "delete from tbl_kisisel3 where id='"+txtId.Text+"' ";

            SqlConnection con = new SqlConnection(baglanti2);
            con.Open();
            SqlCommand com = new SqlCommand(sil,con);
            com.ExecuteNonQuery();
            con.Close();
            button1.PerformClick();
        }

        private void btnGunceleme_Click(object sender, EventArgs e)
        {
            string gunceleme = "update tbl_kisisel3 set ad='" + txtAdU.Text + "',soyad= '" + txtSoyadU.Text + "' where id= '" + txtIdU.Text + "'  ";
            SqlConnection con = new SqlConnection(baglanti2);
            con.Open();
            SqlCommand com = new SqlCommand(gunceleme, con);
            com.ExecuteNonQuery();
            con.Close();
            button1.PerformClick();
        }
        int idnumber;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          idnumber= Convert.ToInt32( listView1.SelectedItems[0].SubItems[0].Text);
            txtId.Text = idnumber.ToString();
            txtIdU.Text= idnumber.ToString();
           txtAdU.Text= listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadU.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
 * 
 *  SqlDataReader oku = com.ExecuteReader();
            while (oku.Read())
            {
                listView1.Items.Add(oku["id"].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["ad"].ToString());
             //   listView1.Items[listView1.Items.Count - 1].SubItems.Add(oku["soyad"].ToString());
            }
            */