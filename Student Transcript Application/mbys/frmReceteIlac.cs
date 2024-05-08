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
    public partial class frmReceteIlac : Form
    {
        public frmReceteIlac()
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
    
        /*public void line_control()
        {
            conn.Open();
            NpgsqlCommand komut_satır = new NpgsqlCommand();
            komut_satır.Connection = conn;
            komut_satır.CommandType = CommandType.Text;

            komut_satır.CommandType = CommandType.Text;
            komut_satır.Parameters.AddWithValue("@receteno", txt_receteNo.Text);
            komut_satır.CommandText = "update recete_ilac set recete_ilac_line_item = 1 where recete_no != @receteno ";

            NpgsqlDataReader dr = komut_satır.ExecuteReader();
            conn.Close();
        }*/
        private void btn_receteyeIlacKaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@receteno", txt_receteNo.Text);
            komut_ekle.Parameters.AddWithValue("@ilac_barkod_no", txt_ilacBarkodNo.Text);
            komut_ekle.Parameters.AddWithValue("@adet", txt_adet.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into recete_ilac (recete_no,ilac_barkod_no, adet) VALUES (@receteno,@ilac_barkod_no,@adet)";
            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();
            MessageBox.Show("İlaç Reçeteye Kaydedildi!");
            verileri_goster("SELECT * FROM recete_ilac WHERE recete_no = '" + txt_receteNo.Text + "'");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from recete_ilac");
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
