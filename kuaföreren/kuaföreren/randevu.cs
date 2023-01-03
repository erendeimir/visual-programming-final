using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace kuaföreren
{
    public partial class randevu : Form
    {


        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kuafor;Uid=root;Pwd='secret';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        string uygulama; 
        public randevu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbKiz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM randevu", conn);
            adapter.Fill(dt);
            dgvOgrenci.DataSource = dt;
            conn.Close();
        }


        private void randevu_Load(object sender, EventArgs e)
        {
            {
                this.Text = "randevu oluştur";
                VeriGetir();
               
                txtNo.Enabled = false;
            }
        }

        private void rbSs_CheckedChanged(object sender, EventArgs e)
        {
            uygulama = "SS"; 
                            
        }

        private void rbCbm_CheckedChanged(object sender, EventArgs e)
        {
            uygulama = "CB+M"; 
        }

        private void dgvOgrenci_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = dgvOgrenci.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dgvOgrenci.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dgvOgrenci.CurrentRow.Cells[2].Value.ToString();
               string cins = dgvOgrenci.CurrentRow.Cells[3].Value.ToString();
                if (dgvOgrenci.CurrentRow.Cells[3].Value.ToString() != "Saç + Sakal")
                {
                    comboBox1.SelectedIndex = 1;
                }
                else
                {
                    comboBox1.SelectedIndex = 0;
                }
                dtpDogumTarih.Text = dgvOgrenci.CurrentRow.Cells[4].Value.ToString();
                cmbSinif.Text = dgvOgrenci.CurrentRow.Cells[5].Value.ToString();
                txtPuan.Text = dgvOgrenci.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into randevu (musteriad,musterisoyad,uygulama,dtarih,islem,fiyat) values (@ad,@soyad,@uygulama,@dtarih,@islem,@fiyat)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@uygulama", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@dtarih", dtpDogumTarih.Value);
            cmd.Parameters.AddWithValue("@islem", cmbSinif.Text);
            cmd.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtPuan.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "Delete From randevu Where musterino=@no";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE randevu " +
               "SET musteriad=@ad,musterisoyad=@soyad,uygulama=@uygulama,dtarih=@dtarih,islem=@islem,fiyat=@fiyat" +
               " WHERE musterino=@no";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("uygulama", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@dtarih", dtpDogumTarih.Value);
            cmd.Parameters.AddWithValue("@islem", cmbSinif.Text);
            cmd.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtPuan.Text));
            cmd.Parameters.AddWithValue("@no", Convert.ToInt32(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "musteriad LIKE '" + txtAra.Text + "%'";
                dgvOgrenci.DataSource = dv;
            }
        }

        private void rbCbm_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
