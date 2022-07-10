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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] buttons = new Button[9];
        byte p1_scr = 0;
        byte p2_scr = 0;
        byte turn = 0;
        byte point = 0;
        byte equal = 0;
        byte game_mod = 0;
        int[] sdx = new int[9];
        int[] sdo = new int[9];

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                buttons[0] = btn_0;
                buttons[1] = btn_1;
                buttons[2] = btn_2;
                buttons[3] = btn_3;
                buttons[4] = btn_4;
                buttons[5] = btn_5;
                buttons[6] = btn_6;
                buttons[7] = btn_7;
                buttons[8] = btn_8;
            }
            clear();
            timer1.Interval = 2000;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            btn_select(btn_0, 0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_select(btn_1, 1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_select(btn_2, 2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_select(btn_3, 3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_select(btn_4, 4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            btn_select(btn_5, 5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            btn_select(btn_6, 6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            btn_select(btn_7, 7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            btn_select(btn_8, 8);
        }
        
        public void btn_select(Button button, byte btn_no)
        {
            if (turn % 2 == 0 && turn < 9 && point == 0)
            {
                button.Text = "X";
                sdx[btn_no] = 1;
                btn_control();
                c_point();
                button.Enabled = false;
                turn++;
            }
            else if (turn % 2 == 1 && turn < 9 && point == 0 && game_mod == 0)
            {
                button.Text = "O";
                sdo[btn_no] = 1;
                btn_control();
                c_point();
                button.Enabled = false;
                turn++;
            }

            if (turn % 2 == 1 && game_mod == 1 && turn < 9 && point == 0)
            {
                pvm();
            }

            if (turn % 2 == 1 && game_mod == 2 && turn < 9 && point == 0)
            {
                pvm();
            }

            if (turn >= 9 && point == 0)
            {
                equal++;
                timer1.Enabled = true;
                MessageBox.Show("hamle kalmadı berabere. berabere kalınan el sayısı:\n " + equal.ToString());
            }
        }

        public int pvmc()
        {
            for (int a = 0; a < 3; a++)
            {
                if (sdo[a + 3] == 1 && sdo[a] == 1 && sdx[a + 6] == 0 && sdo[a + 6] == 0)
                {
                    return a + 6;
                }
            }
            for (int a = 0; a < 3; a++)
            {
                if (sdo[a] == 1 && sdo[a + 6] == 1 && sdx[a + 3] == 0 && sdo[a + 3] == 0)
                {
                    return a + 3;
                }
            }
            for (int a = 0; a <= 2; a++)
            {
                if (sdo[a + 3] == 1 && sdo[a + 6] == 1 && sdx[a] == 0 && sdo[a] == 0)
                {
                    return a;
                }
            }
            //***************************************************************************************
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdo[a] == 1 && sdo[a + 1] == 1 && sdx[a + 2] == 0 && sdo[a + 2] == 0)
                {
                    return a + 2;
                }
            }
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdo[a] == 1 && sdo[a + 2] == 1 && sdx[a + 1] == 0 && sdo[a + 1] == 0)
                {
                    return a + 1;
                }
            }
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdo[a + 2] == 1 && sdo[a + 1] == 1 && sdx[a] == 0 && sdo[a] == 0)
                {
                    return a;
                }
            }
            //*****************************************************************************************

            if (sdo[0] == 1 && sdo[4] == 1 && sdx[8] == 0 && sdo[8] == 0)
            {
                return 8;
            }
            if (sdo[0] == 1 && sdo[8] == 1 && sdx[4] == 0 && sdo[4] == 0)
            {
                return 4;
            }
            if (sdo[8] == 1 && sdo[4] == 1 && sdx[0] == 0 && sdo[0] == 0)
            {
                return 0;
            }
            if (sdo[2] == 1 && sdo[4] == 1 && sdx[6] == 0 && sdo[6] == 0)
            {
                return 6;
            }
            if (sdo[6] == 1 && sdo[4] == 1 && sdx[2] == 0 && sdo[2] == 0)
            {
                return 2;
            }
            if (sdo[2] == 1 && sdo[6] == 1 && sdx[4] == 0 && sdo[4] == 0)
            {
                return 4;
            }
            //*****************************************************************************************************
            //*****************************************************************************************************
            for (int a = 0; a < 3; a++)
            {
                if (sdx[a + 3] == 1 && sdx[a] == 1 && sdx[a + 6] == 0 && sdo[a + 6] == 0)
                {
                    return a + 6;
                }
            }
            for (int a = 0; a < 3; a++)
            {
                if (sdx[a] == 1 && sdx[a + 6] == 1 && sdx[a + 3] == 0 && sdo[a + 3] == 0)
                {
                    return a + 3;
                }
            }
            for (int a = 0; a <= 2; a++)
            {
                if (sdx[a + 3] == 1 && sdx[a + 6] == 1 && sdx[a] == 0 && sdo[a] == 0)
                {
                    return a;
                }
            }
            //***************************************************************************************
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdx[a] == 1 && sdx[a + 1] == 1 && sdx[a + 2] == 0 && sdo[a + 2] == 0)
                {
                    return a + 2;
                }
            }
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdx[a] == 1 && sdx[a + 2] == 1 && sdx[a + 1] == 0 && sdo[a + 1] == 0)
                {
                    return a + 1;
                }
            }
            for (int a = 0; a <= 6; a += 3)
            {
                if (sdx[a + 2 ] == 1 && sdx[a + 1] == 1 && sdx[a] == 0 && sdo[a] == 0)
                {
                    return a;
                }
            }
            //*****************************************************************************************

            if (sdx[0] == 1 && sdx[4] == 1 && sdx[8] == 0 && sdo[8] == 0)
            {
                return 8;
            }
            if (sdx[0] == 1 && sdx[8] == 1 && sdx[4] == 0 && sdo[4] == 0)
            {
                return 4;
            }
            if (sdx[8] == 1 && sdx[4] == 1 && sdx[0] == 0 && sdo[0] == 0)
            {
                return 0;
            }
            if (sdx[2] == 1 && sdx[4] == 1 && sdx[6] == 0 && sdo[6] == 0)
            {
                return 6;
            }
            if (sdx[6] == 1 && sdx[4] == 1 && sdx[2] == 0 && sdo[2] == 0)
            {
                return 2;
            }
            if (sdx[2] == 1 && sdx[6] == 1 && sdx[4] == 0 && sdo[4] == 0)
            {
                return 4;
            }
            //*******************************************************************************************
            if (game_mod == 2 && sdo[4] == 0 && sdx[4] == 0 && turn <= 2)
            {
                return 4;
            }
            if (sdo[1] == 0 && sdx[1] == 0 && sdo[4] == 1)
            {
                return 1;
            }
            if (sdo[7] == 0 && sdx[7] == 0 && sdo[4] == 1)
            {
                return 7;
            }
            if (sdo[0] == 0 && sdx[0] == 0)
            {
                return 0;
            }
            if (sdo[6] == 0 && sdx[6] == 0)
            {
                return 6;
            }
            if (sdo[2] == 0 && sdx[2] == 0)
            {
                return 2;
            }
            if (sdo[8] == 0 && sdx[8] == 0)
            {
                return 8;
            }
            if (sdo[1] == 0 && sdx[1] == 0)
            {
                return 1;
            }
            if (sdo[7] == 0 && sdx[7] == 0)
            {
                return 7;
            }
            if (sdo[3] == 0 && sdx[3] == 0)
            {
                return 3;
            }
            if (sdo[5] == 0 && sdx[5] == 0)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        public void pvm()
        {
            int c = pvmc();
            buttons[c].Text = "O";
            buttons[c].Enabled = false;
            sdo[c] = 1;
            btn_control();
            c_point();
            turn++;
        }

        public void btn_control()
        {
            if (turn % 2 == 0)
            {
                if (sdx[0] + sdx[1] + sdx[2] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_1.ForeColor = Color.White;
                    btn_2.ForeColor = Color.White;
                }
                if (sdx[3] + sdx[4] + sdx[5] == 3)
                {
                    point++;
                    btn_3.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_5.ForeColor = Color.White;
                }
                if (sdx[6] + sdx[7] + sdx[8] == 3)
                {
                    point++;
                    btn_6.ForeColor = Color.White;
                    btn_7.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdx[0] + sdx[3] + sdx[6] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_3.ForeColor = Color.White;
                    btn_6.ForeColor = Color.White;
                }
                if (sdx[1] + sdx[4] + sdx[7] == 3)
                {
                    point++;
                    btn_1.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_7.ForeColor = Color.White;
                }
                if (sdx[2] + sdx[5] + sdx[8] == 3)
                {
                    point++;
                    btn_2.ForeColor = Color.White;
                    btn_5.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdx[0] + sdx[4] + sdx[8] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdx[2] + sdx[4] + sdx[6] == 3)
                {
                    point++;
                    btn_2.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_6.ForeColor = Color.White;
                }
            }
            else
            {
                if (sdo[0] + sdo[1] + sdo[2] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_1.ForeColor = Color.White;
                    btn_2.ForeColor = Color.White;
                }
                if (sdo[3] + sdo[4] + sdo[5] == 3)
                {
                    point++;
                    btn_3.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_5.ForeColor = Color.White;
                }
                if (sdo[6] + sdo[7] + sdo[8] == 3)
                {
                    point++;
                    btn_6.ForeColor = Color.White;
                    btn_7.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdo[0] + sdo[3] + sdo[6] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_3.ForeColor = Color.White;
                    btn_6.ForeColor = Color.White;
                }
                if (sdo[1] + sdo[4] + sdo[7] == 3)
                {
                    point++;
                    btn_1.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_7.ForeColor = Color.White;
                }
                if (sdo[2] + sdo[5] + sdo[8] == 3)
                {
                    point++;
                    btn_2.ForeColor = Color.White;
                    btn_5.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdo[0] + sdo[4] + sdo[8] == 3)
                {
                    point++;
                    btn_0.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_8.ForeColor = Color.White;
                }
                if (sdo[2] + sdo[4] + sdo[6] == 3)
                {
                    point++;
                    btn_2.ForeColor = Color.White;
                    btn_4.ForeColor = Color.White;
                    btn_6.ForeColor = Color.White;
                }
            }
        }

        public void c_point()
        {
            if (turn % 2 == 0)
            {
                if (point != 0)
                {
                    p1_scr++;
                    btn_p1scr.Text = p1_scr.ToString();
                    pnl_oyun.Enabled = false;
                    pnl_ust.Enabled = false;
                    MessageBox.Show(btn_p1.Text + " kazandı");
                    timer1.Enabled = true;
                }
            }
            else
            {
                if (point != 0)
                {
                    p2_scr++;
                    btn_p2scr.Text = p2_scr.ToString();
                    pnl_oyun.Enabled = false;
                    pnl_ust.Enabled = false;
                    MessageBox.Show(btn_p2.Text + " kazandı");
                    timer1.Enabled = true;
                }
            }
        }

        public void clear()
        {
            for(int i = 0; i < 9; i++)
            {
                buttons[i].Text = "";
                buttons[i].Enabled = true;
                buttons[i].ForeColor = Color.Black;
                sdo[i] = 0;
                sdx[i] = 0;
            }
            turn = 0;
            point = 0;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            pnl_ust.Enabled = false;
            pnl_oyun.Enabled = false;
            timer1.Enabled = true;
        }

        public void rename(string p1_name, string p2_name)
        {
            btn_p1.Text = p1_name;
            btn_p2.Text = p2_name;
        }

        public void change_game_mode(byte mod)
        {
            game_mod = mod;
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pnl_ust.Enabled = false;
            pnl_oyun.Enabled = false;
            equal = 0;
            p1_scr = 0;
            p2_scr = 0;
            btn_p1scr.Text = "0";
            btn_p2scr.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clear();
            timer1.Enabled = false;
            pnl_oyun.Enabled = true;
            pnl_ust.Enabled = true;
        }
    }
}
