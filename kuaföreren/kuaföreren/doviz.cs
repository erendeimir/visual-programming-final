using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace kuaföreren
{
    public partial class doviz : Form
    {
        public doviz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TCMB_Kur = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("tarih_date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            usdalis.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("tarih_date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            usdsatis.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("taih_date/Currency [@Kod='GBP']/fOREXbUYİNG").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("taih_date/Currency [@Kod='GBP']/fOREXbUYİNG").InnerXml;
            gbpalis.Text = GBPAlış;
            gbpsatis.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("taih_date/Currency [@Kod='EUR']/fOREXbUYİNG").InnerXml;
            string EURSatış = TCMB_xml.SelectSingleNode("taih_date/Currency [@Kod='EUR']/fOREXbUYİNG").InnerXml;
            euralis.Text = EURAlış;
            eursatis.Text = EURSatış;
        }
    }
}
