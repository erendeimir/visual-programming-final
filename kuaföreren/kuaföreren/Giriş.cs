using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuaföreren
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             fiyat fytt = new fiyat();
            fytt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gazeteler gzt = new gazeteler();
            gzt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randevu rndv = new randevu();
            rndv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteritakip tkp = new musteritakip();
            tkp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel prs = new personel();
            prs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hizmet hizmet = new hizmet();
            hizmet.Show();
        }

        private void rdybtn_Click(object sender, EventArgs e)
        {
            radyodinle rdyyy = new radyodinle();
            rdyyy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hesapmakinesi hsp = new hesapmakinesi();
            hsp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltarih.Text = DateTime.Now.ToLongDateString();
            labelsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void hakkimizdabtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kuaför Eren 2022-Kütahya/Merkez", "hakkımızda");
        }

        private void doviz_Click(object sender, EventArgs e)
        {
            doviz dvz = new doviz();
            dvz.Show();
        }
    }
}
