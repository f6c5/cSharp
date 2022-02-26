using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Sube2
{
    public partial class DovizKurlari : Form
    {
        XDocument mb = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
        public DovizKurlari()
        {
            InitializeComponent();
        }

        private void DovizKurlari_Load(object sender, EventArgs e)
        {
            var sonuc = from x in mb.Descendants("Currency") select new { doviz = x.Element("Isim").Value };
            foreach(var item in sonuc)
            {
                lstdoviz.Items.Add(item.doviz.ToString());
            }
        }

        private void lstdoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            var KurBilgileri = from x in mb.Descendants("Currency")
                               where
                               x.Element("Isim").Value == lstdoviz.SelectedItem.ToString()
                               select new
                               {
                                   ad = x.Element("CurrencyName").Value,
                                   alis = x.Element("ForexBuying").Value,
                                   satis = x.Element("ForexSelling").Value
                               };

            foreach (var x in KurBilgileri)
            {
                lblAd.Text = x.ad;
                lblSatis.Text = x.satis;
                lblAlis.Text = x.alis;
            }
        }
    }
}
