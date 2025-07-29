namespace Araç_Bakım_Takip
{
    partial class yag_bilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yag_bilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Bilgi = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_Viskozite2 = new System.Windows.Forms.TextBox();
            this.txt_Viskozite1 = new System.Windows.Forms.TextBox();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.lbl_Viskozite2 = new System.Windows.Forms.Label();
            this.lbl_Viskozite1 = new System.Windows.Forms.Label();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Bilgi);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.txt_Viskozite2);
            this.groupBox1.Controls.Add(this.txt_Viskozite1);
            this.groupBox1.Controls.Add(this.txt_marka);
            this.groupBox1.Controls.Add(this.lbl_Viskozite2);
            this.groupBox1.Controls.Add(this.lbl_Viskozite1);
            this.groupBox1.Controls.Add(this.lbl_Marka);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yağ Bilgilerini Güncelle";
            // 
            // lbl_Bilgi
            // 
            this.lbl_Bilgi.AutoSize = true;
            this.lbl_Bilgi.Location = new System.Drawing.Point(12, 219);
            this.lbl_Bilgi.Name = "lbl_Bilgi";
            this.lbl_Bilgi.Size = new System.Drawing.Size(0, 16);
            this.lbl_Bilgi.TabIndex = 8;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(217, 165);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(95, 37);
            this.btn_Sil.TabIndex = 7;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(102, 165);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(95, 37);
            this.btn_Ekle.TabIndex = 6;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_Viskozite2
            // 
            this.txt_Viskozite2.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Viskozite2.Location = new System.Drawing.Point(301, 113);
            this.txt_Viskozite2.Name = "txt_Viskozite2";
            this.txt_Viskozite2.Size = new System.Drawing.Size(100, 22);
            this.txt_Viskozite2.TabIndex = 5;
            // 
            // txt_Viskozite1
            // 
            this.txt_Viskozite1.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Viskozite1.Location = new System.Drawing.Point(166, 113);
            this.txt_Viskozite1.Name = "txt_Viskozite1";
            this.txt_Viskozite1.Size = new System.Drawing.Size(100, 22);
            this.txt_Viskozite1.TabIndex = 4;
            // 
            // txt_marka
            // 
            this.txt_marka.BackColor = System.Drawing.Color.DarkGray;
            this.txt_marka.Location = new System.Drawing.Point(35, 113);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(100, 22);
            this.txt_marka.TabIndex = 3;
            // 
            // lbl_Viskozite2
            // 
            this.lbl_Viskozite2.AutoSize = true;
            this.lbl_Viskozite2.Location = new System.Drawing.Point(298, 64);
            this.lbl_Viskozite2.Name = "lbl_Viskozite2";
            this.lbl_Viskozite2.Size = new System.Drawing.Size(95, 16);
            this.lbl_Viskozite2.TabIndex = 2;
            this.lbl_Viskozite2.Text = "VİSKOZİTE 2";
            // 
            // lbl_Viskozite1
            // 
            this.lbl_Viskozite1.AutoSize = true;
            this.lbl_Viskozite1.Location = new System.Drawing.Point(163, 64);
            this.lbl_Viskozite1.Name = "lbl_Viskozite1";
            this.lbl_Viskozite1.Size = new System.Drawing.Size(116, 16);
            this.lbl_Viskozite1.TabIndex = 1;
            this.lbl_Viskozite1.Text = "VİSKOZİTE 1  W";
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.Location = new System.Drawing.Point(32, 64);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(60, 16);
            this.lbl_Marka.TabIndex = 0;
            this.lbl_Marka.Text = "MARKA";
            // 
            // yag_bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(427, 253);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "yag_bilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yağ Bilgileri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_Viskozite2;
        private System.Windows.Forms.TextBox txt_Viskozite1;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Label lbl_Viskozite2;
        private System.Windows.Forms.Label lbl_Viskozite1;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.Label lbl_Bilgi;
    }
}