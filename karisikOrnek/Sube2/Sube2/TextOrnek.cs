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
    public partial class TextOrnek : Form
    {
        public TextOrnek()
        {
            InitializeComponent();
        }

        private void TextOrnek_Load(object sender, EventArgs e)
        {

        }

        private void btnOlaylar_Click(object sender, EventArgs e)
        {
            txtOrnek1.SelectAll();
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            txtOrnek2.Select(1, 3); ;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtOrnek1.Cut();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtOrnek2.Paste();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtOrnek2.Undo();
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOrnek1.Text);
            int b = Convert.ToInt32(txtOrnek2.Text);
            int c = a + b;
            // byte a = 25;
            //  int b = 1500;
            //string c = b.ToString();         
            //byte a = (byte) b;
            MessageBox.Show(c.ToString());
        }
    }
}
