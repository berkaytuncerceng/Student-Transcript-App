namespace mbys
{
    partial class İlaçKayıt
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
            this.txt_barkodNo = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ilacKaydet = new System.Windows.Forms.Button();
            this.lbl_ilaçKayıt = new System.Windows.Forms.Label();
            this.txt_ilaçTipi = new System.Windows.Forms.TextBox();
            this.txt_ilacAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txt_barkodNo);
            this.panel1.Controls.Add(this.btn_listele);
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_ilacKaydet);
            this.panel1.Controls.Add(this.lbl_ilaçKayıt);
            this.panel1.Controls.Add(this.txt_ilaçTipi);
            this.panel1.Controls.Add(this.txt_ilacAdi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 656);
            this.panel1.TabIndex = 23;
            // 
            // txt_barkodNo
            // 
            this.txt_barkodNo.Location = new System.Drawing.Point(179, 100);
            this.txt_barkodNo.Name = "txt_barkodNo";
            this.txt_barkodNo.Size = new System.Drawing.Size(254, 27);
            this.txt_barkodNo.TabIndex = 45;
            // 
            // btn_listele
            // 
            this.btn_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listele.Location = new System.Drawing.Point(51, 336);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(160, 36);
            this.btn_listele.TabIndex = 44;
            this.btn_listele.Text = "Tümünü Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iptal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iptal.Location = new System.Drawing.Point(343, 228);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(90, 38);
            this.btn_iptal.TabIndex = 43;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(742, 252);
            this.dataGridView1.TabIndex = 40;
            // 
            // btn_ilacKaydet
            // 
            this.btn_ilacKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ilacKaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ilacKaydet.Location = new System.Drawing.Point(179, 228);
            this.btn_ilacKaydet.Name = "btn_ilacKaydet";
            this.btn_ilacKaydet.Size = new System.Drawing.Size(158, 38);
            this.btn_ilacKaydet.TabIndex = 39;
            this.btn_ilacKaydet.Text = "İlacı Kaydet";
            this.btn_ilacKaydet.UseVisualStyleBackColor = true;
            this.btn_ilacKaydet.Click += new System.EventHandler(this.btn_ilacKaydet_Click);
            // 
            // lbl_ilaçKayıt
            // 
            this.lbl_ilaçKayıt.AutoSize = true;
            this.lbl_ilaçKayıt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ilaçKayıt.Location = new System.Drawing.Point(50, 22);
            this.lbl_ilaçKayıt.Name = "lbl_ilaçKayıt";
            this.lbl_ilaçKayıt.Size = new System.Drawing.Size(107, 24);
            this.lbl_ilaçKayıt.TabIndex = 0;
            this.lbl_ilaçKayıt.Text = "İlaç Kayıt";
            // 
            // txt_ilaçTipi
            // 
            this.txt_ilaçTipi.Location = new System.Drawing.Point(179, 195);
            this.txt_ilaçTipi.Name = "txt_ilaçTipi";
            this.txt_ilaçTipi.Size = new System.Drawing.Size(254, 27);
            this.txt_ilaçTipi.TabIndex = 31;
            // 
            // txt_ilacAdi
            // 
            this.txt_ilacAdi.Location = new System.Drawing.Point(179, 147);
            this.txt_ilacAdi.Name = "txt_ilacAdi";
            this.txt_ilacAdi.Size = new System.Drawing.Size(254, 27);
            this.txt_ilacAdi.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "İlaç Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "İlaç Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barkod No:";
            // 
            // İlaçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 652);
            this.Controls.Add(this.panel1);
            this.Name = "İlaçKayıt";
            this.Text = "İlaçKayıt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_ilaçKayıt;
        private TextBox txt_ilaçTipi;
        private TextBox txt_ilacAdi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_ilacKaydet;
        private DataGridView dataGridView1;
        private Button btn_iptal;
        private Button btn_listele;
        private TextBox txt_barkodNo;
    }
}