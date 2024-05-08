using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace mbys
{
    public partial class İlacinVerildigiHastalar : Form
    {
        public İlacinVerildigiHastalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=mbys; user ID=postgres; password=1234");

      
        private void btn_hastalariListele_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ilac_alanlari_listele = new NpgsqlCommand();
            komut_ilac_alanlari_listele.Connection = conn;

            komut_ilac_alanlari_listele.Parameters.AddWithValue("@barkodno", txt_barkodNo.Text);

            komut_ilac_alanlari_listele.CommandType = CommandType.Text;

            komut_ilac_alanlari_listele.CommandText = ("SELECT hasta.ad, hasta.soyad FROM hasta INNER JOIN recete ON recete.hasta_tckn = hasta.tckn INNER JOIN recete_ilac ON recete.recete_no = recete_ilac.recete_no WHERE recete_ilac.ilac_barkod_no = @barkodno;");
            NpgsqlDataReader dr = komut_ilac_alanlari_listele.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ilac_alanlari_listele.Dispose();
            conn.Close();
            MessageBox.Show("Listeleme Başarılı!");
        }
    }
}
