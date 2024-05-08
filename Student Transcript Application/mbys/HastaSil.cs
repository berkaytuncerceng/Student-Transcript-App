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
    public partial class HastaSil : Form
    {
        public HastaSil()
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
        private void btn_hastaSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = conn;
            komut_sil.Parameters.AddWithValue("@tckn", txt_tckn.Text);

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from hasta where tckn = @tckn";

            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_sil.Dispose();
            conn.Close();
            MessageBox.Show("Hasta Kaydı Başarıyla Silindi!");
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from hasta");

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
