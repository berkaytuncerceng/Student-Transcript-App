namespace mbys
{
    partial class İlacinVerildigiHastalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_hastalariListele = new System.Windows.Forms.Button();
            this.lbl_reçeteKayıt = new System.Windows.Forms.Label();
            this.txt_barkodNo = new System.Windows.Forms.TextBox();
            this.lbl_barkodNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_hastalariListele);
            this.panel1.Controls.Add(this.lbl_reçeteKayıt);
            this.panel1.Controls.Add(this.txt_barkodNo);
            this.panel1.Controls.Add(this.lbl_barkodNo);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 600);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(710, 309);
            this.dataGridView1.TabIndex = 40;
            // 
            // btn_hastalariListele
            // 
            this.btn_hastalariListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hastalariListele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastalariListele.Location = new System.Drawing.Point(50, 228);
            this.btn_hastalariListele.Name = "btn_hastalariListele";
            this.btn_hastalariListele.Size = new System.Drawing.Size(257, 38);
            this.btn_hastalariListele.TabIndex = 39;
            this.btn_hastalariListele.Text = "İlacı Alan Hastaları Listele";
            this.btn_hastalariListele.UseVisualStyleBackColor = true;
            this.btn_hastalariListele.Click += new System.EventHandler(this.btn_hastalariListele_Click);
            // 
            // lbl_reçeteKayıt
            // 
            this.lbl_reçeteKayıt.AutoSize = true;
            this.lbl_reçeteKayıt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_reçeteKayıt.Location = new System.Drawing.Point(50, 22);
            this.lbl_reçeteKayıt.Name = "lbl_reçeteKayıt";
            this.lbl_reçeteKayıt.Size = new System.Drawing.Size(138, 24);
            this.lbl_reçeteKayıt.TabIndex = 0;
            this.lbl_reçeteKayıt.Text = "Reçete Kayıt";
            // 
            // txt_barkodNo
            // 
            this.txt_barkodNo.Location = new System.Drawing.Point(202, 117);
            this.txt_barkodNo.Name = "txt_barkodNo";
            this.txt_barkodNo.Size = new System.Drawing.Size(232, 27);
            this.txt_barkodNo.TabIndex = 29;
            // 
            // lbl_barkodNo
            // 
            this.lbl_barkodNo.AutoSize = true;
            this.lbl_barkodNo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_barkodNo.Location = new System.Drawing.Point(50, 119);
            this.lbl_barkodNo.Name = "lbl_barkodNo";
            this.lbl_barkodNo.Size = new System.Drawing.Size(142, 22);
            this.lbl_barkodNo.TabIndex = 20;
            this.lbl_barkodNo.Text = "İlaç Barkod No:";
            // 
            // İlacinVerildigiHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.panel1);
            this.Name = "İlacinVerildigiHastalar";
            this.Text = "İlacinVerildigiHastalar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_hastalariListele;
        private Label lbl_reçeteKayıt;
        private TextBox txt_barkodNo;
        private Label lbl_barkodNo;
    }
}