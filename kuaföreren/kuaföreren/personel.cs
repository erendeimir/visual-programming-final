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
    public partial class personel : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kuafor;Uid=root;Pwd='secret';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public personel()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM kullanicilar", conn);
            adapter.Fill(dt);
            personeldata.DataSource = dt;
            conn.Close();
        }


        private void personel_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void personeldata_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtno.Text = personeldata.CurrentRow.Cells[0].Value.ToString();
                txtkad.Text = personeldata.CurrentRow.Cells[1].Value.ToString();
                txtsifre.Text = personeldata.CurrentRow.Cells[2].Value.ToString();
                txtad.Text = personeldata.CurrentRow.Cells[3].Value.ToString();
                txtsoyad.Text = personeldata.CurrentRow.Cells[4].Value.ToString();
                txtemail.Text = personeldata.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into kullanicilar (k_adi,k_sifre,ad,soyad,mail) values (@kad,@sifre,@ad,@soyad,@mail)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@kad", txtkad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@mail", txtemail.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Delete From kullanicilar Where id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtno.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt silindi.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kullanicilar " +
               "SET k_adi=@kad,k_sifre=@sifre,ad=@ad,soyad=@soyad,mail=@mail" +
               " WHERE id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kad", txtkad.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
            cmd.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@mail", txtemail.Text);
            cmd.Parameters.AddWithValue("@id", personeldata.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "k_adi LIKE '" + txtara.Text + "%'";
                personeldata.DataSource = dv;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
