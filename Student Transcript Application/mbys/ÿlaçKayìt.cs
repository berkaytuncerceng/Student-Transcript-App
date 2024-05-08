using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace mbys
{
    public partial class İlaçKayıt : Form
    {
        public İlaçKayıt()
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
        private void btn_ilacKaydet_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = conn;

                komut_ekle.Parameters.AddWithValue("@barkodNo", txt_barkodNo.Text);
                komut_ekle.Parameters.AddWithValue("@ad", txt_ilacAdi.Text);
                komut_ekle.Parameters.AddWithValue("@tip", txt_ilaçTipi.Text);


                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into ilac (barkodno, ad, tip) VALUES (@barkodNo, @ad, @tip)";

                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                komut_ekle.Dispose();
                conn.Close();
                verileri_goster("SELECT * FROM ilac WHERE barkodno = '" + txt_barkodNo.Text + "'");
        }
        

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from ilac");

        }
    }
}
