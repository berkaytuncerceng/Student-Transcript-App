namespace mbys
{
    partial class HastayaVerilenİlaclar
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
            this.btn_ilacListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TCKN = new System.Windows.Forms.TextBox();
            this.lbl_receteNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_ilacListele);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_TCKN);
            this.panel1.Controls.Add(this.lbl_receteNo);
            this.panel1.Location = new System.Drawing.Point(-5, -81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 612);
            this.panel1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(710, 309);
            this.dataGridView1.TabIndex = 40;
            // 
            // btn_ilacListele
            // 
            this.btn_ilacListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ilacListele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ilacListele.Location = new System.Drawing.Point(50, 241);
            this.btn_ilacListele.Name = "btn_ilacListele";
            this.btn_ilacListele.Size = new System.Drawing.Size(257, 38);
            this.btn_ilacListele.TabIndex = 39;
            this.btn_ilacListele.Text = "Hastanın İlaçlarını Listele.";
            this.btn_ilacListele.UseVisualStyleBackColor = true;
            this.btn_ilacListele.Click += new System.EventHandler(this.btn_ilacListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Kayıt";
            // 
            // txt_TCKN
            // 
            this.txt_TCKN.Location = new System.Drawing.Point(202, 117);
            this.txt_TCKN.Name = "txt_TCKN";
            this.txt_TCKN.Size = new System.Drawing.Size(232, 27);
            this.txt_TCKN.TabIndex = 29;
            // 
            // lbl_receteNo
            // 
            this.lbl_receteNo.AutoSize = true;
            this.lbl_receteNo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_receteNo.Location = new System.Drawing.Point(50, 119);
            this.lbl_receteNo.Name = "lbl_receteNo";
            this.lbl_receteNo.Size = new System.Drawing.Size(123, 22);
            this.lbl_receteNo.TabIndex = 20;
            this.lbl_receteNo.Text = "Hasta TCKN:";
            // 
            // HastayaVerilenİlaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.panel1);
            this.Name = "HastayaVerilenİlaclar";
            this.Text = "HastayaVerilenİlaclar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_ilacListele;
        private Label label1;
        private TextBox txt_TCKN;
        private Label lbl_receteNo;
    }
}