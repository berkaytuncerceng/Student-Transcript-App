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
    public partial class ReçeteKayıt : Form
    {
        public ReçeteKayıt()
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

            komut_ekle.Parameters.AddWithValue("@TCKN", txt_tckn.Text);
            komut_ekle.Parameters.AddWithValue("@receteNo", Convert.ToInt32(txt_receteNo.Text));
            komut_ekle.Parameters.AddWithValue("@receteTarih",(dtp_ReceteTarih.Value));


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into recete (hasta_tckn,recete_no, tarih) VALUES (@TCKN,@receteNo,@receteTarih)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();
            MessageBox.Show("Reçete Kaydedildi!");
            verileri_goster("SELECT * FROM recete WHERE hasta_tckn = '" + txt_tckn.Text + "'");
            btnİlacEkleYonlendir.Visible = true;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from recete");
        }

        private void btnİlacEkleYonlendir_Click(object sender, EventArgs e)
        {
            frmReceteIlac frmreceteilac = new frmReceteIlac()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            frmreceteilac.StartPosition = FormStartPosition.CenterParent;
            frmreceteilac.ShowDialog(this);
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
