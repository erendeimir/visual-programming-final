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
    public partial class hizmet : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kuafor;Uid=root;Pwd='secret';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public hizmet()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM fiyat", conn);
            adapter.Fill(dt);
            hizmetdata.DataSource = dt;
            conn.Close();
        }

        private void hizmet_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void hizmetdata_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into fiyat (hizmet_ismi, hizmet_fiyat) values (@isim,@fiyat)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@isim", txthizmet.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyatt.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Delete From fiyat Where id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", hizmetdata.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt silindi.");
        }
    }
}
