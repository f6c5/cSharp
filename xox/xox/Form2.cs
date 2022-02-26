using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form2 : Form
    {
        byte game_mod = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            pvp.ForeColor = Color.Teal;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void pvp_Click(object sender, EventArgs e)
        {
            pvp.ForeColor = Color.Teal;
            pvm.ForeColor = Color.Black;
            game_mod = 0;
            txt_p1.Text = "oyuncu1";
            pnl_mod.Visible = false;
        }

        private void pvm_Click(object sender, EventArgs e)
        {
            pvm.ForeColor = Color.Teal;
            pvp.ForeColor = Color.Black;
            pnl_mod.Visible = true;
            if (mod_e.Checked || mod_h.Checked)
            {
                
            }
            else
            {
                game_mod = 1;
            }
        }

        private void mod_e_CheckedChanged(object sender, EventArgs e)
        {
            game_mod = 1;
            txt_p2.Text = "kolay mod";
        }

        private void mod_h_CheckedChanged(object sender, EventArgs e)
        {
            game_mod = 2;
            txt_p2.Text = "zor mod";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            form1.rename(txt_p1.Text, txt_p2.Text);
            form1.change_game_mode(game_mod);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
