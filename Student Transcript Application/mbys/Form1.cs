namespace mbys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKay�tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaKay�t hastakay�t = new HastaKay�t()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hastakay�t.StartPosition = FormStartPosition.CenterParent;
            hastakay�t.ShowDialog(this);
        }

        private void ila�Kay�tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            �la�Kay�t ila�kay�t = new �la�Kay�t()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            ila�kay�t.StartPosition = FormStartPosition.CenterParent;
            ila�kay�t.ShowDialog(this);
        }

        private void muayeneKAy�tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKay�t muayeneKay�t = new MuayeneKay�t()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            muayeneKay�t.StartPosition = FormStartPosition.CenterParent;
            muayeneKay�t.ShowDialog(this);
        }

        private void re�eteKay�tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Re�eteKay�t re�etekay�t = new Re�eteKay�t()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            re�etekay�t.StartPosition = FormStartPosition.CenterParent;
            re�etekay�t.ShowDialog(this);
        }

        private void hastayaVerilen�la�larToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaVerilen�laclar hvi = new HastayaVerilen�laclar()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hvi.StartPosition = FormStartPosition.CenterParent;
            hvi.ShowDialog(this);
        }

        private void ilac�nVerildi�iHastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            �lacinVerildigiHastalar ivh = new �lacinVerildigiHastalar()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            ivh.StartPosition = FormStartPosition.CenterParent;
            ivh.ShowDialog(this);
        }

        private void muayeneDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneDefteri muayenedefteri = new MuayeneDefteri()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            muayenedefteri.StartPosition = FormStartPosition.CenterParent;
            muayenedefteri.ShowDialog(this);
        }

        private void re�eteye�la�KayderToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaSil hastasil = new HastaSil()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hastasil.StartPosition = FormStartPosition.CenterParent;
            hastasil.ShowDialog(this);
        }

        private void hastalarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastalarListesl hastaL = new HastalarListesl()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hastaL.StartPosition = FormStartPosition.CenterParent;
            hastaL.ShowDialog(this);
        }

        private void ila�larListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ila�lar�Listele ila�L = new Ila�lar�Listele()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            ila�L.StartPosition = FormStartPosition.CenterParent;
            ila�L.ShowDialog(this);
        }

        private void re�eteListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Re�eteListele re�eteL = new Re�eteListele()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            re�eteL.StartPosition = FormStartPosition.CenterParent;
            re�eteL.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}