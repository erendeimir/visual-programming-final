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
    public partial class fiyat : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kuafor;Uid=root;Pwd='secret';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public fiyat()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM fiyat", conn);
            adapter.Fill(dt);
            fiyatdata.DataSource = dt;
            conn.Close();
        }

        private void fiyat_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void fiyatdata_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtfiyat.Text = fiyatdata.CurrentRow.Cells[2].Value.ToString();
                
                textBox1.Text = fiyatdata.CurrentRow.Cells[1].Value.ToString();

                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE fiyat " +
               "SET hizmet_fiyat=@fiyat " +
               " WHERE id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            cmd.Parameters.AddWithValue("@id", fiyatdata.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }
    }
}
