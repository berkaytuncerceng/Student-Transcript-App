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
    public partial class MuayeneDefteri : Form
    {
        public MuayeneDefteri()
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
        private void btn_muayeneListele_Click(object sender, EventArgs e)
        {
            verileri_goster("select muayene.tarih, hasta.ad , hasta.soyad,hasta.dogumyeri,hasta.dogumtarihi ,muayene.sikayet,muayene.tani,muayene.tedavi\r\nfrom hasta inner join muayene on muayene.hasta_tckn = hasta.tckn ");
        }
    }
}
