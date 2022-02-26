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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string str;
            str = txtSoyaAd.SelectedText;
            lblSoyAd.Text = str;
            //  MessageBox.Show("Kayıtız başarılı....");
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Lower;
            txtSoyaAd.CharacterCasing = CharacterCasing.Upper;
            txtCinsiyet.CharacterCasing = CharacterCasing.Upper;
            txtTc.CharacterCasing = CharacterCasing.Normal;
        }

        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            //e.KeyCode=Keys.Shift 
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.ForeColor = Color.Red;
            lblAd.Text = txtAd.Text;
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            txtAd.ForeColor = Color.Yellow;
        }

        private void txtSoyaAd_Leave(object sender, EventArgs e)
        {
            //DialogResult rs = new DialogResult();
            //rs = MessageBox.Show("Soy adınızı doğru yazdınız mı?", "Uyarı", MessageBoxButtons.YesNo);
            //if (rs == DialogResult.Yes)
            //{
            //    txtCinsiyet.Focus();
            //}
            //else
            //{
            //    txtSoyaAd.Clear();
            //    txtSoyaAd.Focus();
            //}
        }

        private void txtSoyaAd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
            this.Hide();
        }
    }
}
