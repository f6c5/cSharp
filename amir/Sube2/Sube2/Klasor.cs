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
    public partial class Klasor : Form
    {
        public Klasor()
        {
            InitializeComponent();
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            bool sonuc=Directory.Exists(@"C:\GörselProgramlamaSube2");
            if (!sonuc)
            {
                Directory.CreateDirectory(@"C:\GörselProgramlamaSube2");
                MessageBox.Show("Tamam");
            }
            else
                MessageBox.Show("Hata");
               
            //Directory.CreateDirectory(@"C:\GörselProgramlamaSube2");
            // string adres = "GörselProgramlamaSube2";
        }

        private void btnMOve_Click(object sender, EventArgs e)
        {
            Directory.Move(@"C:\GörselProgramlamaSube2", "C:\\Matlab\\GörselProgramlamaSube2");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool izin = true;
            Directory.Delete("C:\\Matlab\\GörselProgramlamaSube2",true);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string adres = @"C:\GörselProgramlamaSube2";
            MessageBox.Show(Directory.GetLastWriteTime(@"C:\GörselProgramlamaSube2").ToString());
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetExtension(@"C:\GörselProgramlamaSube2\Sube2.exe"));
        }

        private void btnDrcInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo drc = new DirectoryInfo(@"C:\GörselProgramlamaSube2");
            drc.Create();
            DirectoryInfo alt = drc.CreateSubdirectory("altklasor");
//            drc.CreateSubdirectory( " altklasor");
        }
    }
}
