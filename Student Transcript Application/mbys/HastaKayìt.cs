using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace mbys
{
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
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

        private void btn_hastaKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@tckn", txt_tckn.Text);
            komut_ekle.Parameters.AddWithValue("@ad", txt_ad.Text);
            komut_ekle.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            komut_ekle.Parameters.AddWithValue("@dogumYeri", txt_dogumYeri.Text);
            komut_ekle.Parameters.AddWithValue("@dogumTarihi", dtp_Tarih.Value);
            komut_ekle.Parameters.AddWithValue("@yer", txt_yer.Text);
            komut_ekle.Parameters.AddWithValue("@medeniDurum", txt_medeniDurum.Text);
            komut_ekle.Parameters.AddWithValue("@adres", txt_adres.Text);
            komut_ekle.Parameters.AddWithValue("@telNo", txt_telNo.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hasta (tckn, ad, soyad, dogumyeri, dogumTarihi,yer,medenidurum,adres,telefon) VALUES (@tckn, @ad, @soyad, @dogumYeri,@dogumTarihi, @yer,@medeniDurum,@adres,@telNo)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();
            verileri_goster("SELECT * FROM hasta WHERE tckn = '" + txt_tckn.Text + "'");
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from hasta");
        }
    }
}
