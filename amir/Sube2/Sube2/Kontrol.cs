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
    public partial class Kontrol : Form
    {
        public Kontrol()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            // lblText.Font = new Font("Arial", a);
            progressBar1.Value = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabIndex = 2;
            progressBar1.Value = 60;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            MessageBox.Show("İşlem tamamnlandı");
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblText.Text = treeView1.SelectedNode.FullPath;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //progressBar1.Value = trackBar1.Value;
            lblText.Font = new Font("arial", trackBar1.Value);
            
        }
    }
}
