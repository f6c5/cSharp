<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çevir_Click(object sender, EventArgs e)
        {
            buyuk.Text = kucuk.Text.ToUpper();
        }

        private void degis_Click(object sender, EventArgs e)
        {
            kucuk.Text = kucuk.Text.Replace(hedef.Text, kelime.Text);
            buyuk.Text = (kucuk.Text.ToUpper()).Replace(hedef.Text, kelime.Text);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çevir_Click(object sender, EventArgs e)
        {
            buyuk.Text = kucuk.Text.ToUpper();
        }

        private void degis_Click(object sender, EventArgs e)
        {
            kucuk.Text = kucuk.Text.Replace(hedef.Text, kelime.Text);
            buyuk.Text = (kucuk.Text.ToUpper()).Replace(hedef.Text, kelime.Text);
        }
    }
}
>>>>>>> 906a39ed4508a79311a0c0f6699cc8842744d447
