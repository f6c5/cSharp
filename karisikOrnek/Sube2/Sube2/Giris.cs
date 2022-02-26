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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            //this.BackColor = Color.FromKnownColor(KnownColor.Coral);
            ///   this.BackColor = Color.FromArgb(145,125,0);
            //this.ForeColor = Color.Cyan;
            // this.FormBorderStyle=
            this.BackgroundImage = Properties.Resources.logo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
