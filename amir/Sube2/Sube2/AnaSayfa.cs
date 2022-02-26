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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            //  this.StartPosition = FormStartPosition.WindowsDefaultBounds;
            this.Cursor = Cursors.Help;
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
    /////   ////// select color form tbl_style;

          //  btnGiris.PerformClick();
            this.Text = DateTime.Now.Hour.ToString();
         //   MessageBox.Show(DateTime.Now.ToShortDateString(), "Tarih");
            textBox1.Enabled = false;
        }
        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.A && Control.ModifierKeys == Keys.Shift)
        //    {
        //        this.Visible = false;
        //        // this.BackgroundImage = Properties.Resources.logo;
        //        //  this.BackColor = Color.Aqua;
        //        //   this.Enabled = false;
        //    }
        //    else if (e.KeyCode == Keys.B)
        //    {
        //        this.Show();
        //        MessageBox.Show("B tüşünü basdınız....", "Uyarı");
        //        this.BackgroundImage = null;
        //        this.BackColor = Color.Beige;

        //    }
        //    else if (e.KeyCode == Keys.L)
        //    {
        //        textBox1.Enabled = true;
        //        this.BackColor = Color.Lavender;
        //    }
        //    else if (e.KeyCode == Keys.X)
        //    {
        //        this.MaximizeBox = false;
        //        //textBox1.Enabled = false;
        //    }
        //    //  base.OnKeyDown(e);
        //}

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = new DialogResult();
            ////sınıf dialogresuly  class
            ///nesne dr             object
            dr = MessageBox.Show("kapatmak istiyorsunuz mu?", "Çıkış?????", MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.No || dr == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void AnaSayfa_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
           
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show("Programdan çıktınız");
        }

        private void AnaSayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.U)
            {
                DialogResult dr = new DialogResult();
                ////sınıf dialogresuly  class
                ///nesne dr             object
                dr = MessageBox.Show("Programdan memnun musunuz?", "feedback?????", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No || dr == DialogResult.Cancel)
                {
                    MessageBox.Show("yeni versyon için günceleniyoruz.");
                }
                else
                {
                    MessageBox.Show("teşekkür ederiz.");
                }
            }
        }

        private void AnaSayfa_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("X: " + e.X + "    Y: " + e.Y + " Tıldakınız");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //this.ForeColor = Color.Gold;
            Kayit frm = new Kayit();
            frm.Show();
            this.Hide();
        }

        private void btnRenk1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            /// insert red color to tbl_style; 

        }

        private void btnRenk2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrnek_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.MediumSlateBlue;
        }

        private void btnOrnek_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.Gainsboro;
        }
    }
}
