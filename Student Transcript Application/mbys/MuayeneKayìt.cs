using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mbys
{
    public partial class MuayeneKayıt : Form
    {
        public MuayeneKayıt()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=mbys; user ID=postgres; password=1234");

        public void verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }
        private void btn_muayeneKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;
            komut_ekle.Parameters.AddWithValue("@TCKN", txt_tckn.Text);
            komut_ekle.Parameters.AddWithValue("@muayeneTarihi",dtp_Tarih.Value);
            komut_ekle.Parameters.AddWithValue("@hastaSikayeti", txt_sikayet.Text);
            komut_ekle.Parameters.AddWithValue("@tedavi", txt_tedavi.Text);
            komut_ekle.Parameters.AddWithValue("@tani", txt_tani.Text);
            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into muayene (hasta_tckn, tarih, sikayet,tedavi,tani) VALUES (@TCKN, @muayeneTarihi, @hastaSikayeti,@tedavi,@tani)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();
            verileri_goster("SELECT * FROM muayene WHERE sikayet = '" + txt_sikayet.Text + "'");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from muayene");
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
