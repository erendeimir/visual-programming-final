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
    public partial class hesapmakinesi : Form

        
    {

        char islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;

        public hesapmakinesi()
        {
            InitializeComponent();
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
        if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";

        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void dort_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if(_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            if(_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            if(_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc;
            switch (islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;

                    default: sonuc = 0;
                    break;


            }

            ekranlabel.Text = Convert.ToString(sonuc);

        }

        private void cikar_Click(object sender, EventArgs e)
        {
            islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void carp_Click(object sender, EventArgs e)
        {
            islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
