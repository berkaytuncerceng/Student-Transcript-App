namespace mbys
{
    partial class frmReceteIlac
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
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_receteyeIlacKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.txt_ilacBarkodNo = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btn_listele);
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.txt_adet);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_receteyeIlacKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_receteNo);
            this.panel1.Controls.Add(this.txt_ilacBarkodNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 600);
            this.panel1.TabIndex = 25;
            // 
            // btn_listele
            // 
            this.btn_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listele.Location = new System.Drawing.Point(50, 319);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(160, 36);
            this.btn_listele.TabIndex = 45;
            this.btn_listele.Text = "Tümünü Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iptal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iptal.Location = new System.Drawing.Point(361, 247);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(77, 38);
            this.btn_iptal.TabIndex = 44;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(206, 214);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(232, 27);
            this.txt_adet.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(583, 214);
            this.dataGridView1.TabIndex = 42;
            // 
            // btn_receteyeIlacKaydet
            // 
            this.btn_receteyeIlacKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_receteyeIlacKaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_receteyeIlacKaydet.Location = new System.Drawing.Point(206, 247);
            this.btn_receteyeIlacKaydet.Name = "btn_receteyeIlacKaydet";
            this.btn_receteyeIlacKaydet.Size = new System.Drawing.Size(145, 38);
            this.btn_receteyeIlacKaydet.TabIndex = 39;
            this.btn_receteyeIlacKaydet.Text = "İlacı Kaydet.";
            this.btn_receteyeIlacKaydet.UseVisualStyleBackColor = true;
            this.btn_receteyeIlacKaydet.Click += new System.EventHandler(this.btn_receteyeIlacKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçeteye İlaç Kaydet";
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(206, 119);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(232, 27);
            this.txt_receteNo.TabIndex = 30;
            // 
            // txt_ilacBarkodNo
            // 
            this.txt_ilacBarkodNo.Location = new System.Drawing.Point(206, 166);
            this.txt_ilacBarkodNo.Name = "txt_ilacBarkodNo";
            this.txt_ilacBarkodNo.Size = new System.Drawing.Size(232, 27);
            this.txt_ilacBarkodNo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "İlaç Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Reçete No:";
            // 
            // frmReceteIlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 595);
            this.Controls.Add(this.panel1);
            this.Name = "frmReceteIlac";
            this.Text = "frmReceteIlac";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_receteyeIlacKaydet;
        private Label label1;
        private TextBox txt_receteNo;
        private TextBox txt_ilacBarkodNo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_adet;
        private Button btn_iptal;
        private Button btn_listele;
    }
}