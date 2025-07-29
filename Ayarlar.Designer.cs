namespace Araç_Bakım_Takip
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VT_Yedek = new System.Windows.Forms.Button();
            this.btn_LogKlasoru = new System.Windows.Forms.Button();
            this.btn_TemaRenk = new System.Windows.Forms.Button();
            this.btn_VtBaglanti = new System.Windows.Forms.Button();
            this.btn_LoglariGoster = new System.Windows.Forms.Button();
            this.btn_YagBilgileri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 287);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_YagBilgileri);
            this.groupBox1.Controls.Add(this.btn_VT_Yedek);
            this.groupBox1.Controls.Add(this.btn_LogKlasoru);
            this.groupBox1.Controls.Add(this.btn_TemaRenk);
            this.groupBox1.Controls.Add(this.btn_VtBaglanti);
            this.groupBox1.Controls.Add(this.btn_LoglariGoster);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AYARLAR";
            // 
            // btn_VT_Yedek
            // 
            this.btn_VT_Yedek.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VT_Yedek.Location = new System.Drawing.Point(3, 164);
            this.btn_VT_Yedek.Name = "btn_VT_Yedek";
            this.btn_VT_Yedek.Size = new System.Drawing.Size(194, 56);
            this.btn_VT_Yedek.TabIndex = 5;
            this.btn_VT_Yedek.Text = "Veri Tabanınnı Yedekle";
            this.btn_VT_Yedek.UseVisualStyleBackColor = true;
            // 
            // btn_LogKlasoru
            // 
            this.btn_LogKlasoru.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LogKlasoru.Location = new System.Drawing.Point(3, 127);
            this.btn_LogKlasoru.Name = "btn_LogKlasoru";
            this.btn_LogKlasoru.Size = new System.Drawing.Size(194, 37);
            this.btn_LogKlasoru.TabIndex = 4;
            this.btn_LogKlasoru.Text = "Log Kalsörünü Aç";
            this.btn_LogKlasoru.UseVisualStyleBackColor = true;
            // 
            // btn_TemaRenk
            // 
            this.btn_TemaRenk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TemaRenk.Location = new System.Drawing.Point(3, 90);
            this.btn_TemaRenk.Name = "btn_TemaRenk";
            this.btn_TemaRenk.Size = new System.Drawing.Size(194, 37);
            this.btn_TemaRenk.TabIndex = 3;
            this.btn_TemaRenk.Text = "Tema Ligt/Dark";
            this.btn_TemaRenk.UseVisualStyleBackColor = true;
            // 
            // btn_VtBaglanti
            // 
            this.btn_VtBaglanti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VtBaglanti.Location = new System.Drawing.Point(3, 53);
            this.btn_VtBaglanti.Name = "btn_VtBaglanti";
            this.btn_VtBaglanti.Size = new System.Drawing.Size(194, 37);
            this.btn_VtBaglanti.TabIndex = 2;
            this.btn_VtBaglanti.Text = "Bağlantıyı Test Et";
            this.btn_VtBaglanti.UseVisualStyleBackColor = true;
            // 
            // btn_LoglariGoster
            // 
            this.btn_LoglariGoster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LoglariGoster.Location = new System.Drawing.Point(3, 16);
            this.btn_LoglariGoster.Name = "btn_LoglariGoster";
            this.btn_LoglariGoster.Size = new System.Drawing.Size(194, 37);
            this.btn_LoglariGoster.TabIndex = 1;
            this.btn_LoglariGoster.Text = "Logları Aç";
            this.btn_LoglariGoster.UseVisualStyleBackColor = true;
            this.btn_LoglariGoster.Click += new System.EventHandler(this.btn_LoglariGoster_Click);
            // 
            // btn_YagBilgileri
            // 
            this.btn_YagBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_YagBilgileri.Location = new System.Drawing.Point(3, 220);
            this.btn_YagBilgileri.Name = "btn_YagBilgileri";
            this.btn_YagBilgileri.Size = new System.Drawing.Size(194, 56);
            this.btn_YagBilgileri.TabIndex = 6;
            this.btn_YagBilgileri.Text = "Yağ Bilgileri";
            this.btn_YagBilgileri.UseVisualStyleBackColor = true;
            this.btn_YagBilgileri.Click += new System.EventHandler(this.btn_YagBilgileri_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(335, 287);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_LoglariGoster;
        private System.Windows.Forms.Button btn_TemaRenk;
        private System.Windows.Forms.Button btn_VtBaglanti;
        private System.Windows.Forms.Button btn_VT_Yedek;
        private System.Windows.Forms.Button btn_LogKlasoru;
        private System.Windows.Forms.Button btn_YagBilgileri;
    }
}