namespace mbys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKayýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaKayýt hastakayýt = new HastaKayýt()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hastakayýt.StartPosition = FormStartPosition.CenterParent;
            hastakayýt.ShowDialog(this);
        }

        private void ilaçKayýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÝlaçKayýt ilaçkayýt = new ÝlaçKayýt()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            ilaçkayýt.StartPosition = FormStartPosition.CenterParent;
            ilaçkayýt.ShowDialog(this);
        }

        private void muayeneKAyýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKayýt muayeneKayýt = new MuayeneKayýt()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            muayeneKayýt.StartPosition = FormStartPosition.CenterParent;
            muayeneKayýt.ShowDialog(this);
        }

        private void reçeteKayýtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReçeteKayýt reçetekayýt = new ReçeteKayýt()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            reçetekayýt.StartPosition = FormStartPosition.CenterParent;
            reçetekayýt.ShowDialog(this);
        }

        private void hastayaVerilenÝlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastayaVerilenÝlaclar hvi = new HastayaVerilenÝlaclar()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            hvi.StartPosition = FormStartPosition.CenterParent;
            hvi.ShowDialog(this);
        }

        private void ilacýnVerildiðiHastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÝlacinVerildigiHastalar ivh = new ÝlacinVerildigiHastalar()
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

        private void reçeteyeÝlaçKayderToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ilaçlarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlaçlarýListele ilaçL = new IlaçlarýListele()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            ilaçL.StartPosition = FormStartPosition.CenterParent;
            ilaçL.ShowDialog(this);
        }

        private void reçeteListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReçeteListele reçeteL = new ReçeteListele()
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            reçeteL.StartPosition = FormStartPosition.CenterParent;
            reçeteL.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}