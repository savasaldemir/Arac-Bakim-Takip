namespace Araç_Bakım_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_aracid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Tarih_Saat = new System.Windows.Forms.Label();
            this.btn_AraclarSayfasi = new System.Windows.Forms.Button();
            this.btn_Yapilan_islemler_kayit = new System.Windows.Forms.Button();
            this.txt_PlakaSorgu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox_Antifriz = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox_PolenFiltre = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox_HavaFiltre = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox_YakitFiltre = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox_YagFiltre = new System.Windows.Forms.CheckBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_antifrizDurumu = new System.Windows.Forms.Label();
            this.lbl_polenFiltreDurumu = new System.Windows.Forms.Label();
            this.lbl_havaFiltreDurumu = new System.Windows.Forms.Label();
            this.lbl_yakitFiltreDurumu = new System.Windows.Forms.Label();
            this.lbl_yagFiltreDurumu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_Viskozite2 = new System.Windows.Forms.ComboBox();
            this.comboViskozite1 = new System.Windows.Forms.ComboBox();
            this.combo_MarkaSec = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_Arac_Bilgileri = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Arac_Bilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_aracid);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_AraclarSayfasi);
            this.panel1.Controls.Add(this.btn_Yapilan_islemler_kayit);
            this.panel1.Controls.Add(this.txt_PlakaSorgu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_aracid
            // 
            this.lbl_aracid.AutoSize = true;
            this.lbl_aracid.Location = new System.Drawing.Point(339, 20);
            this.lbl_aracid.Name = "lbl_aracid";
            this.lbl_aracid.Size = new System.Drawing.Size(41, 13);
            this.lbl_aracid.TabIndex = 6;
            this.lbl_aracid.Text = "label10";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Tarih_Saat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(767, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 100);
            this.panel3.TabIndex = 5;
            // 
            // lbl_Tarih_Saat
            // 
            this.lbl_Tarih_Saat.AutoSize = true;
            this.lbl_Tarih_Saat.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tarih_Saat.Location = new System.Drawing.Point(24, 20);
            this.lbl_Tarih_Saat.Name = "lbl_Tarih_Saat";
            this.lbl_Tarih_Saat.Size = new System.Drawing.Size(0, 16);
            this.lbl_Tarih_Saat.TabIndex = 0;
            // 
            // btn_AraclarSayfasi
            // 
            this.btn_AraclarSayfasi.BackColor = System.Drawing.Color.Silver;
            this.btn_AraclarSayfasi.FlatAppearance.BorderSize = 0;
            this.btn_AraclarSayfasi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AraclarSayfasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AraclarSayfasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AraclarSayfasi.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AraclarSayfasi.Location = new System.Drawing.Point(570, 12);
            this.btn_AraclarSayfasi.Name = "btn_AraclarSayfasi";
            this.btn_AraclarSayfasi.Size = new System.Drawing.Size(128, 71);
            this.btn_AraclarSayfasi.TabIndex = 4;
            this.btn_AraclarSayfasi.Text = "ARAÇLAR\r\nSAYFASINA\r\nGİT";
            this.btn_AraclarSayfasi.UseVisualStyleBackColor = false;
            this.btn_AraclarSayfasi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Yapilan_islemler_kayit
            // 
            this.btn_Yapilan_islemler_kayit.BackColor = System.Drawing.Color.Silver;
            this.btn_Yapilan_islemler_kayit.FlatAppearance.BorderSize = 0;
            this.btn_Yapilan_islemler_kayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Yapilan_islemler_kayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Yapilan_islemler_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yapilan_islemler_kayit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yapilan_islemler_kayit.Location = new System.Drawing.Point(417, 12);
            this.btn_Yapilan_islemler_kayit.Name = "btn_Yapilan_islemler_kayit";
            this.btn_Yapilan_islemler_kayit.Size = new System.Drawing.Size(128, 71);
            this.btn_Yapilan_islemler_kayit.TabIndex = 3;
            this.btn_Yapilan_islemler_kayit.Text = "YAPILAN\r\nİŞLEMLER\r\nKAYIT";
            this.btn_Yapilan_islemler_kayit.UseVisualStyleBackColor = false;
            this.btn_Yapilan_islemler_kayit.Click += new System.EventHandler(this.btn_Yapilan_islemler_kayit_Click);
            // 
            // txt_PlakaSorgu
            // 
            this.txt_PlakaSorgu.BackColor = System.Drawing.Color.Silver;
            this.txt_PlakaSorgu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PlakaSorgu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PlakaSorgu.Location = new System.Drawing.Point(248, 39);
            this.txt_PlakaSorgu.Multiline = true;
            this.txt_PlakaSorgu.Name = "txt_PlakaSorgu";
            this.txt_PlakaSorgu.Size = new System.Drawing.Size(109, 26);
            this.txt_PlakaSorgu.TabIndex = 2;
            this.txt_PlakaSorgu.TextChanged += new System.EventHandler(this.txt_PlakaSorgu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Sorgula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Araç_Bakım_Takip.Properties.Resources.Neşeli_Tamirci_Karakteri;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 417);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox_Antifriz);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox_PolenFiltre);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox_HavaFiltre);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox_YakitFiltre);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox_YagFiltre);
            this.groupBox3.Controls.Add(this.txt_Aciklama);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbl_antifrizDurumu);
            this.groupBox3.Controls.Add(this.lbl_polenFiltreDurumu);
            this.groupBox3.Controls.Add(this.lbl_havaFiltreDurumu);
            this.groupBox3.Controls.Add(this.lbl_yakitFiltreDurumu);
            this.groupBox3.Controls.Add(this.lbl_yagFiltreDurumu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 310);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yapılan İşlemler";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox9.Location = new System.Drawing.Point(259, 153);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(97, 20);
            this.checkBox9.TabIndex = 18;
            this.checkBox9.Text = "Değişmedi";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox_Antifriz
            // 
            this.checkBox_Antifriz.AutoSize = true;
            this.checkBox_Antifriz.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_Antifriz.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_Antifriz.Location = new System.Drawing.Point(172, 153);
            this.checkBox_Antifriz.Name = "checkBox_Antifriz";
            this.checkBox_Antifriz.Size = new System.Drawing.Size(75, 20);
            this.checkBox_Antifriz.TabIndex = 17;
            this.checkBox_Antifriz.Text = "Değişti";
            this.checkBox_Antifriz.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox7.Location = new System.Drawing.Point(259, 129);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(97, 20);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Değişmedi";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox_PolenFiltre
            // 
            this.checkBox_PolenFiltre.AutoSize = true;
            this.checkBox_PolenFiltre.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_PolenFiltre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_PolenFiltre.Location = new System.Drawing.Point(172, 129);
            this.checkBox_PolenFiltre.Name = "checkBox_PolenFiltre";
            this.checkBox_PolenFiltre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_PolenFiltre.TabIndex = 15;
            this.checkBox_PolenFiltre.Text = "Değişti";
            this.checkBox_PolenFiltre.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox5.Location = new System.Drawing.Point(259, 103);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(97, 20);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Değişmedi";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox_HavaFiltre
            // 
            this.checkBox_HavaFiltre.AutoSize = true;
            this.checkBox_HavaFiltre.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_HavaFiltre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_HavaFiltre.Location = new System.Drawing.Point(172, 103);
            this.checkBox_HavaFiltre.Name = "checkBox_HavaFiltre";
            this.checkBox_HavaFiltre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_HavaFiltre.TabIndex = 13;
            this.checkBox_HavaFiltre.Text = "Değişti";
            this.checkBox_HavaFiltre.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox3.Location = new System.Drawing.Point(259, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 20);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Değişmedi";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox_YakitFiltre
            // 
            this.checkBox_YakitFiltre.AutoSize = true;
            this.checkBox_YakitFiltre.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_YakitFiltre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_YakitFiltre.Location = new System.Drawing.Point(172, 78);
            this.checkBox_YakitFiltre.Name = "checkBox_YakitFiltre";
            this.checkBox_YakitFiltre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_YakitFiltre.TabIndex = 11;
            this.checkBox_YakitFiltre.Text = "Değişti";
            this.checkBox_YakitFiltre.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox2.Location = new System.Drawing.Point(259, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 20);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Değişmedi";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox_YagFiltre
            // 
            this.checkBox_YagFiltre.AutoSize = true;
            this.checkBox_YagFiltre.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_YagFiltre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBox_YagFiltre.Location = new System.Drawing.Point(172, 52);
            this.checkBox_YagFiltre.Name = "checkBox_YagFiltre";
            this.checkBox_YagFiltre.Size = new System.Drawing.Size(75, 20);
            this.checkBox_YagFiltre.TabIndex = 9;
            this.checkBox_YagFiltre.Text = "Değişti";
            this.checkBox_YagFiltre.UseVisualStyleBackColor = true;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.BackColor = System.Drawing.Color.Silver;
            this.txt_Aciklama.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.txt_Aciklama.Location = new System.Drawing.Point(14, 214);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(343, 79);
            this.txt_Aciklama.TabIndex = 8;
            this.txt_Aciklama.Text = "Şanzıman Yağ Eklendi. Değişti.\r\nHidrolik Yağı Eklendi. Değişti.\r\n\r\nKM Bilgisi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Açıklama";
            // 
            // lbl_antifrizDurumu
            // 
            this.lbl_antifrizDurumu.AutoSize = true;
            this.lbl_antifrizDurumu.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_antifrizDurumu.Location = new System.Drawing.Point(4, 153);
            this.lbl_antifrizDurumu.Name = "lbl_antifrizDurumu";
            this.lbl_antifrizDurumu.Size = new System.Drawing.Size(132, 16);
            this.lbl_antifrizDurumu.TabIndex = 6;
            this.lbl_antifrizDurumu.Text = "Antifiriz Değişimi";
            // 
            // lbl_polenFiltreDurumu
            // 
            this.lbl_polenFiltreDurumu.AutoSize = true;
            this.lbl_polenFiltreDurumu.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_polenFiltreDurumu.Location = new System.Drawing.Point(34, 129);
            this.lbl_polenFiltreDurumu.Name = "lbl_polenFiltreDurumu";
            this.lbl_polenFiltreDurumu.Size = new System.Drawing.Size(102, 16);
            this.lbl_polenFiltreDurumu.TabIndex = 5;
            this.lbl_polenFiltreDurumu.Text = "Polen Filtresi";
            // 
            // lbl_havaFiltreDurumu
            // 
            this.lbl_havaFiltreDurumu.AutoSize = true;
            this.lbl_havaFiltreDurumu.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_havaFiltreDurumu.Location = new System.Drawing.Point(36, 103);
            this.lbl_havaFiltreDurumu.Name = "lbl_havaFiltreDurumu";
            this.lbl_havaFiltreDurumu.Size = new System.Drawing.Size(100, 16);
            this.lbl_havaFiltreDurumu.TabIndex = 4;
            this.lbl_havaFiltreDurumu.Text = "Hava Filtresi";
            // 
            // lbl_yakitFiltreDurumu
            // 
            this.lbl_yakitFiltreDurumu.AutoSize = true;
            this.lbl_yakitFiltreDurumu.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_yakitFiltreDurumu.Location = new System.Drawing.Point(34, 78);
            this.lbl_yakitFiltreDurumu.Name = "lbl_yakitFiltreDurumu";
            this.lbl_yakitFiltreDurumu.Size = new System.Drawing.Size(102, 16);
            this.lbl_yakitFiltreDurumu.TabIndex = 3;
            this.lbl_yakitFiltreDurumu.Text = "Yakıt Filtresi";
            // 
            // lbl_yagFiltreDurumu
            // 
            this.lbl_yagFiltreDurumu.AutoSize = true;
            this.lbl_yagFiltreDurumu.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbl_yagFiltreDurumu.Location = new System.Drawing.Point(46, 52);
            this.lbl_yagFiltreDurumu.Name = "lbl_yagFiltreDurumu";
            this.lbl_yagFiltreDurumu.Size = new System.Drawing.Size(90, 16);
            this.lbl_yagFiltreDurumu.TabIndex = 2;
            this.lbl_yagFiltreDurumu.Text = "Yağ Filtresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(146, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "DEĞİŞTİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEĞİŞMEDİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_Viskozite2);
            this.groupBox2.Controls.Add(this.comboViskozite1);
            this.groupBox2.Controls.Add(this.combo_MarkaSec);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yağ Bilgileri";
            // 
            // combo_Viskozite2
            // 
            this.combo_Viskozite2.BackColor = System.Drawing.Color.Silver;
            this.combo_Viskozite2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Viskozite2.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.combo_Viskozite2.FormattingEnabled = true;
            this.combo_Viskozite2.Location = new System.Drawing.Point(248, 35);
            this.combo_Viskozite2.Name = "combo_Viskozite2";
            this.combo_Viskozite2.Size = new System.Drawing.Size(109, 24);
            this.combo_Viskozite2.TabIndex = 2;
            this.combo_Viskozite2.Text = "VİSKOZİTE";
            // 
            // comboViskozite1
            // 
            this.comboViskozite1.BackColor = System.Drawing.Color.Silver;
            this.comboViskozite1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboViskozite1.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.comboViskozite1.FormattingEnabled = true;
            this.comboViskozite1.Location = new System.Drawing.Point(130, 35);
            this.comboViskozite1.Name = "comboViskozite1";
            this.comboViskozite1.Size = new System.Drawing.Size(109, 24);
            this.comboViskozite1.TabIndex = 1;
            this.comboViskozite1.Text = "VİSKOZİTE";
            // 
            // combo_MarkaSec
            // 
            this.combo_MarkaSec.BackColor = System.Drawing.Color.Silver;
            this.combo_MarkaSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_MarkaSec.Font = new System.Drawing.Font("Century", 9.25F, System.Drawing.FontStyle.Bold);
            this.combo_MarkaSec.FormattingEnabled = true;
            this.combo_MarkaSec.Location = new System.Drawing.Point(12, 35);
            this.combo_MarkaSec.Name = "combo_MarkaSec";
            this.combo_MarkaSec.Size = new System.Drawing.Size(109, 24);
            this.combo_MarkaSec.TabIndex = 0;
            this.combo_MarkaSec.Text = "MARKA SEÇ";
            this.combo_MarkaSec.SelectedIndexChanged += new System.EventHandler(this.combo_MarkaSec_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid_Arac_Bilgileri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(368, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // dataGrid_Arac_Bilgileri
            // 
            this.dataGrid_Arac_Bilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Arac_Bilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Arac_Bilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_Arac_Bilgileri.Location = new System.Drawing.Point(3, 18);
            this.dataGrid_Arac_Bilgileri.Name = "dataGrid_Arac_Bilgileri";
            this.dataGrid_Arac_Bilgileri.Size = new System.Drawing.Size(539, 396);
            this.dataGrid_Arac_Bilgileri.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(913, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Bakım Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Arac_Bilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_Arac_Bilgileri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Tarih_Saat;
        private System.Windows.Forms.Button btn_AraclarSayfasi;
        private System.Windows.Forms.Button btn_Yapilan_islemler_kayit;
        private System.Windows.Forms.TextBox txt_PlakaSorgu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_Viskozite2;
        private System.Windows.Forms.ComboBox comboViskozite1;
        private System.Windows.Forms.ComboBox combo_MarkaSec;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox_Antifriz;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox_PolenFiltre;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox_HavaFiltre;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox_YakitFiltre;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox_YagFiltre;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_antifrizDurumu;
        private System.Windows.Forms.Label lbl_polenFiltreDurumu;
        private System.Windows.Forms.Label lbl_havaFiltreDurumu;
        private System.Windows.Forms.Label lbl_yakitFiltreDurumu;
        private System.Windows.Forms.Label lbl_yagFiltreDurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_aracid;
    }
}

