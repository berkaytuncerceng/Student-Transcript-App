namespace mbys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneKAyıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteyeİlaçKayderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastayaVerilenİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilacınVerildiğiHastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneDefteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtlarToolStripMenuItem
            // 
            this.kayıtlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.ilaçKayıtToolStripMenuItem,
            this.muayeneKAyıtToolStripMenuItem,
            this.reçeteKayıtToolStripMenuItem,
            this.reçeteyeİlaçKayderToolStripMenuItem});
            this.kayıtlarToolStripMenuItem.Name = "kayıtlarToolStripMenuItem";
            this.kayıtlarToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.kayıtlarToolStripMenuItem.Text = "Kaydet";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kaydet";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // ilaçKayıtToolStripMenuItem
            // 
            this.ilaçKayıtToolStripMenuItem.Name = "ilaçKayıtToolStripMenuItem";
            this.ilaçKayıtToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.ilaçKayıtToolStripMenuItem.Text = "İlaç Kaydet";
            this.ilaçKayıtToolStripMenuItem.Click += new System.EventHandler(this.ilaçKayıtToolStripMenuItem_Click);
            // 
            // muayeneKAyıtToolStripMenuItem
            // 
            this.muayeneKAyıtToolStripMenuItem.Name = "muayeneKAyıtToolStripMenuItem";
            this.muayeneKAyıtToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.muayeneKAyıtToolStripMenuItem.Text = "Muayene Kaydet";
            this.muayeneKAyıtToolStripMenuItem.Click += new System.EventHandler(this.muayeneKAyıtToolStripMenuItem_Click);
            // 
            // reçeteKayıtToolStripMenuItem
            // 
            this.reçeteKayıtToolStripMenuItem.Name = "reçeteKayıtToolStripMenuItem";
            this.reçeteKayıtToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.reçeteKayıtToolStripMenuItem.Text = "Reçete Kaydet";
            this.reçeteKayıtToolStripMenuItem.Click += new System.EventHandler(this.reçeteKayıtToolStripMenuItem_Click);
            // 
            // reçeteyeİlaçKayderToolStripMenuItem
            // 
            this.reçeteyeİlaçKayderToolStripMenuItem.Name = "reçeteyeİlaçKayderToolStripMenuItem";
            this.reçeteyeİlaçKayderToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.reçeteyeİlaçKayderToolStripMenuItem.Text = "Reçeteye İlaç Kaydet";
            this.reçeteyeİlaçKayderToolStripMenuItem.Click += new System.EventHandler(this.reçeteyeİlaçKayderToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastayaVerilenİlaçlarToolStripMenuItem,
            this.ilacınVerildiğiHastalarToolStripMenuItem,
            this.muayeneDefteriToolStripMenuItem,
            this.hastalarListesiToolStripMenuItem,
            this.ilaçlarListesiToolStripMenuItem,
            this.reçeteListesiToolStripMenuItem});
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.listeleToolStripMenuItem.Text = "Listele";
            // 
            // hastayaVerilenİlaçlarToolStripMenuItem
            // 
            this.hastayaVerilenİlaçlarToolStripMenuItem.Name = "hastayaVerilenİlaçlarToolStripMenuItem";
            this.hastayaVerilenİlaçlarToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.hastayaVerilenİlaçlarToolStripMenuItem.Text = "Hastaya Verilen İlaçlar";
            this.hastayaVerilenİlaçlarToolStripMenuItem.Click += new System.EventHandler(this.hastayaVerilenİlaçlarToolStripMenuItem_Click);
            // 
            // ilacınVerildiğiHastalarToolStripMenuItem
            // 
            this.ilacınVerildiğiHastalarToolStripMenuItem.Name = "ilacınVerildiğiHastalarToolStripMenuItem";
            this.ilacınVerildiğiHastalarToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.ilacınVerildiğiHastalarToolStripMenuItem.Text = "İlacın Verildiği Hastalar";
            this.ilacınVerildiğiHastalarToolStripMenuItem.Click += new System.EventHandler(this.ilacınVerildiğiHastalarToolStripMenuItem_Click);
            // 
            // muayeneDefteriToolStripMenuItem
            // 
            this.muayeneDefteriToolStripMenuItem.Name = "muayeneDefteriToolStripMenuItem";
            this.muayeneDefteriToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.muayeneDefteriToolStripMenuItem.Text = "Muayene Defteri";
            this.muayeneDefteriToolStripMenuItem.Click += new System.EventHandler(this.muayeneDefteriToolStripMenuItem_Click);
            // 
            // hastalarListesiToolStripMenuItem
            // 
            this.hastalarListesiToolStripMenuItem.Name = "hastalarListesiToolStripMenuItem";
            this.hastalarListesiToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.hastalarListesiToolStripMenuItem.Text = "Hastalar Listesi";
            this.hastalarListesiToolStripMenuItem.Click += new System.EventHandler(this.hastalarListesiToolStripMenuItem_Click);
            // 
            // ilaçlarListesiToolStripMenuItem
            // 
            this.ilaçlarListesiToolStripMenuItem.Name = "ilaçlarListesiToolStripMenuItem";
            this.ilaçlarListesiToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.ilaçlarListesiToolStripMenuItem.Text = "İlaçlar Listesi";
            this.ilaçlarListesiToolStripMenuItem.Click += new System.EventHandler(this.ilaçlarListesiToolStripMenuItem_Click);
            // 
            // reçeteListesiToolStripMenuItem
            // 
            this.reçeteListesiToolStripMenuItem.Name = "reçeteListesiToolStripMenuItem";
            this.reçeteListesiToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.reçeteListesiToolStripMenuItem.Text = "Reçete Listesi";
            this.reçeteListesiToolStripMenuItem.Click += new System.EventHandler(this.reçeteListesiToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(0, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(913, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "MUAYENE BİLGİ YÖNETİM SİSTEMİNE HOŞ GELDİNİZ!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(913, 468);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kayıtlarToolStripMenuItem;
        private ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private ToolStripMenuItem ilaçKayıtToolStripMenuItem;
        private ToolStripMenuItem muayeneKAyıtToolStripMenuItem;
        private ToolStripMenuItem reçeteKayıtToolStripMenuItem;
        private ToolStripMenuItem listeleToolStripMenuItem;
        private ToolStripMenuItem hastayaVerilenİlaçlarToolStripMenuItem;
        private ToolStripMenuItem ilacınVerildiğiHastalarToolStripMenuItem;
        private ToolStripMenuItem muayeneDefteriToolStripMenuItem;
        private ToolStripMenuItem reçeteyeİlaçKayderToolStripMenuItem;
        private ToolStripMenuItem hastalarListesiToolStripMenuItem;
        private ToolStripMenuItem ilaçlarListesiToolStripMenuItem;
        private ToolStripMenuItem reçeteListesiToolStripMenuItem;
        private TextBox textBox1;
    }
}