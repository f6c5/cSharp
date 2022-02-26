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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnOrnek_Click(object sender, EventArgs e)
        {
            lstDersler.Items.Add(lstOrnek.SelectedItem);
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            lstOrnek.Sorted = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //   lstOrnek.Items.Clear();
            lstDersler.Items.Remove(lstDersler.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDersler.Text);
        }

        private void lstOrnek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDersler.Items.Add(lstOrnek.SelectedItem);
        }
    }
}
