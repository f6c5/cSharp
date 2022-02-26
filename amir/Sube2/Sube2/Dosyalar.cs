using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Sube2
{
    public partial class Dosyalar : Form
    {
        public Dosyalar()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string adres = @"C:\GörselProgramlamaSube2\altklasor\";
            string extension = chkExtension.Text;
            File.Create(adres + txtIsim.Text +extension);
            
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            string adres = @"C:\GörselProgramlamaSube2\log.txt";
            FileStream akim = new FileStream(adres,FileMode.Append,FileAccess.Write,FileShare.None);
            StreamWriter str = new StreamWriter(akim);
            str.WriteLine(txtIsim.Text);
            str.Flush();
            str.Close();

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            sonuc= (dateTimePicker1.Value - dateTimePicker2.Value).Days.ToString();
            int a =  Convert.ToInt32(sonuc);
            if (a < 0){a *= -1;}
            lblSonuc.Text = a.ToString();
        }
    }
}

//string adres = @"C:\GörselProgramlamaSube2\log.txt";
//FileStream akim = new FileStream(adres, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
//StreamReader str = new StreamReader(akim);
//string kelime;
//            while ((kelime = str.ReadLine())!=null)
//            {
//                   listBox1.Items.Add(kelime);
//            }
//            str.Close();