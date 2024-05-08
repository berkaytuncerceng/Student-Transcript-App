namespace mbys
{
    partial class ReçeteKayıt
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
            this.btnİlacEkleYonlendir = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_ReceteTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_hastaKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.txt_tckn = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.btnİlacEkleYonlendir);
            this.panel1.Controls.Add(this.btn_listele);
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dtp_ReceteTarih);
            this.panel1.Controls.Add(this.btn_hastaKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_receteNo);
            this.panel1.Controls.Add(this.txt_tckn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 685);
            this.panel1.TabIndex = 24;
            // 
            // btnİlacEkleYonlendir
            // 
            this.btnİlacEkleYonlendir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnİlacEkleYonlendir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnİlacEkleYonlendir.Location = new System.Drawing.Point(206, 288);
            this.btnİlacEkleYonlendir.Name = "btnİlacEkleYonlendir";
            this.btnİlacEkleYonlendir.Size = new System.Drawing.Size(242, 36);
            this.btnİlacEkleYonlendir.TabIndex = 45;
            this.btnİlacEkleYonlendir.Text = "Reçeteye İlaç Ekle";
            this.btnİlacEkleYonlendir.UseVisualStyleBackColor = true;
            this.btnİlacEkleYonlendir.Visible = false;
            this.btnİlacEkleYonlendir.Click += new System.EventHandler(this.btnİlacEkleYonlendir_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listele.Location = new System.Drawing.Point(50, 398);
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
            this.btn_iptal.Location = new System.Drawing.Point(358, 250);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(90, 32);
            this.btn_iptal.TabIndex = 43;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(634, 235);
            this.dataGridView1.TabIndex = 42;
            // 
            // dtp_ReceteTarih
            // 
            this.dtp_ReceteTarih.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ReceteTarih.Location = new System.Drawing.Point(206, 215);
            this.dtp_ReceteTarih.Name = "dtp_ReceteTarih";
            this.dtp_ReceteTarih.Size = new System.Drawing.Size(242, 27);
            this.dtp_ReceteTarih.TabIndex = 40;
            // 
            // btn_hastaKaydet
            // 
            this.btn_hastaKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hastaKaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaKaydet.Location = new System.Drawing.Point(206, 250);
            this.btn_hastaKaydet.Name = "btn_hastaKaydet";
            this.btn_hastaKaydet.Size = new System.Drawing.Size(146, 32);
            this.btn_hastaKaydet.TabIndex = 39;
            this.btn_hastaKaydet.Text = "Reçete Oluştur";
            this.btn_hastaKaydet.UseVisualStyleBackColor = true;
            this.btn_hastaKaydet.Click += new System.EventHandler(this.btn_hastaKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Kayıt";
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(206, 169);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(242, 27);
            this.txt_receteNo.TabIndex = 30;
            // 
            // txt_tckn
            // 
            this.txt_tckn.Location = new System.Drawing.Point(206, 117);
            this.txt_tckn.Name = "txt_tckn";
            this.txt_tckn.Size = new System.Drawing.Size(242, 27);
            this.txt_tckn.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Reçete No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hasta TCKN:";
            // 
            // ReçeteKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 687);
            this.Controls.Add(this.panel1);
            this.Name = "ReçeteKayıt";
            this.Text = "ReçeteKayıt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtp_ReceteTarih;
        private Button btn_hastaKaydet;
        private Label label1;
        private TextBox txt_receteNo;
        private TextBox txt_tckn;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_iptal;
        private Button btn_listele;
        private Button btnİlacEkleYonlendir;
    }
}