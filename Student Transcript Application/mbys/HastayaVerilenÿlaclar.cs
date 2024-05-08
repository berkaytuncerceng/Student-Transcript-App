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
    public partial class HastayaVerilenİlaclar : Form
    {
        public HastayaVerilenİlaclar()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=mbys; user ID=postgres; password=1234");

        private void btn_ilacListele_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ilac_listele = new NpgsqlCommand();
            komut_ilac_listele.Connection = conn;

            komut_ilac_listele.Parameters.AddWithValue("@tckn", txt_TCKN.Text);

            komut_ilac_listele.CommandType = CommandType.Text;

            komut_ilac_listele.CommandText = ("SELECT hasta.ad, hasta.soyad, recete_ilac.ilac_barkod_no, recete_ilac.adet FROM hasta INNER JOIN recete ON recete.hasta_tckn = hasta.tckn INNER JOIN recete_ilac ON recete.recete_no = recete_ilac.recete_no WHERE hasta.tckn = @tckn");
            NpgsqlDataReader dr = komut_ilac_listele.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ilac_listele.Dispose();
            conn.Close();
            MessageBox.Show("Listeleme Başarılı!");
        }
    }
}
