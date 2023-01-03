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
    public partial class musteritakip : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kuafor;Uid=root;Pwd='secret';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public musteritakip()
        {
            InitializeComponent();
        }

        private void musteritakip_Load(object sender, EventArgs e)
        {
            {
                this.Text = "müşteri takip";
                

                
            }
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT musteriad,musterisoyad FROM randevu", conn);
            adapter.Fill(dt);
            musteridata.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "musteriad LIKE '" + textBox1.Text + "%'";
                musteridata.DataSource = dv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            VeriGetir();
            
        }
    }
}
