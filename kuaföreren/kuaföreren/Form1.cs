using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace kuaföreren
{
    public partial class Form1 : Form
    {
        Metot mtt = new Metot();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(mtt.KullaniciKontrol(comboBox1.SelectedItem.ToString(),textBox1.Text)==1)
            {
                //MessageBox.Show("giriş başarılı","başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Anaform af = new Anaform();
                af.label2.Text = this.comboBox1.SelectedItem.ToString();
                af.Text = "merhaba, " + this.comboBox1.SelectedItem.ToString();
                this.Hide();
                af.Show();
            }
            else
            {
                MessageBox.Show("giriş yapılamadı", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region combo üyelerini çektim
            string ConStr = "SERVER=localhost;DATABASE=kuafor;UID=root;PWD=secret";
            using (var baglan= new MySqlConnection(ConStr))
            {
                using (var komut = new MySqlCommand("SELECT k_adi FROM kullanicilar ORDER BY k_adi ASC", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr["k_adi"].ToString());
                        }
                        comboBox1.SelectedIndex = 0; 
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                      
                    }
                }
            }
#endregion
        }
    }
}
