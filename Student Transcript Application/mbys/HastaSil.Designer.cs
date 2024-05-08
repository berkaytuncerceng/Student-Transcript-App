namespace mbys
{
    partial class HastaSil
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
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_hastaSil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tckn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_iptal);
            this.panel1.Controls.Add(this.btn_hastaSil);
            this.panel1.Controls.Add(this.btn_listele);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_tckn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 640);
            this.panel1.TabIndex = 22;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iptal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iptal.Location = new System.Drawing.Point(369, 141);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(90, 36);
            this.btn_iptal.TabIndex = 45;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_hastaSil
            // 
            this.btn_hastaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hastaSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hastaSil.Location = new System.Drawing.Point(197, 141);
            this.btn_hastaSil.Name = "btn_hastaSil";
            this.btn_hastaSil.Size = new System.Drawing.Size(160, 36);
            this.btn_hastaSil.TabIndex = 44;
            this.btn_hastaSil.Text = "Hastayı Sil";
            this.btn_hastaSil.UseVisualStyleBackColor = true;
            this.btn_hastaSil.Click += new System.EventHandler(this.btn_hastaSil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_listele.Location = new System.Drawing.Point(51, 298);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(160, 36);
            this.btn_listele.TabIndex = 43;
            this.btn_listele.Text = "Tümünü Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(671, 252);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Sil";
            // 
            // txt_tckn
            // 
            this.txt_tckn.Location = new System.Drawing.Point(197, 108);
            this.txt_tckn.Name = "txt_tckn";
            this.txt_tckn.Size = new System.Drawing.Size(262, 27);
            this.txt_tckn.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // HastaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 621);
            this.Controls.Add(this.panel1);
            this.Name = "HastaSil";
            this.Text = "HastaSil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_listele;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_tckn;
        private Label label2;
        private Button btn_iptal;
        private Button btn_hastaSil;
    }
}