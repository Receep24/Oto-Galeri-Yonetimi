
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class KiralanmisArabalar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralanmisArabalar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKiraMusteriId = new System.Windows.Forms.TextBox();
            this.txtKiraAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKiraAradaId = new System.Windows.Forms.TextBox();
            this.txtGünlükFiyat = new System.Windows.Forms.TextBox();
            this.txtKaçGün = new System.Windows.Forms.TextBox();
            this.lblÜcret = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtimeKira = new System.Windows.Forms.DateTimePicker();
            this.btnKiraHesapla = new System.Windows.Forms.Button();
            this.dgvKiralanmisAraba = new System.Windows.Forms.DataGridView();
            this.btnKiralanmisEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKiralıkSil = new System.Windows.Forms.Button();
            this.btnKiralıkGüncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKiraNo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.KiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArabaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GünlükFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KacGün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiralananTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(233, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MusteriId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(241, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ArabaId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(836, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "GünlükFiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(229, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(860, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "KaçGün:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(830, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "ToplamÜcret:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(829, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "KiralanmaTarihi:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(895, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tarih:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtKiraMusteriId
            // 
            this.txtKiraMusteriId.Location = new System.Drawing.Point(317, 110);
            this.txtKiraMusteriId.Name = "txtKiraMusteriId";
            this.txtKiraMusteriId.Size = new System.Drawing.Size(152, 22);
            this.txtKiraMusteriId.TabIndex = 1;
            // 
            // txtKiraAdSoyad
            // 
            this.txtKiraAdSoyad.Location = new System.Drawing.Point(317, 146);
            this.txtKiraAdSoyad.Name = "txtKiraAdSoyad";
            this.txtKiraAdSoyad.Size = new System.Drawing.Size(152, 22);
            this.txtKiraAdSoyad.TabIndex = 2;
            // 
            // txtKiraAradaId
            // 
            this.txtKiraAradaId.Location = new System.Drawing.Point(317, 180);
            this.txtKiraAradaId.Name = "txtKiraAradaId";
            this.txtKiraAradaId.Size = new System.Drawing.Size(152, 22);
            this.txtKiraAradaId.TabIndex = 3;
            // 
            // txtGünlükFiyat
            // 
            this.txtGünlükFiyat.Location = new System.Drawing.Point(929, 70);
            this.txtGünlükFiyat.Name = "txtGünlükFiyat";
            this.txtGünlükFiyat.Size = new System.Drawing.Size(152, 22);
            this.txtGünlükFiyat.TabIndex = 4;
            // 
            // txtKaçGün
            // 
            this.txtKaçGün.Location = new System.Drawing.Point(929, 111);
            this.txtKaçGün.Name = "txtKaçGün";
            this.txtKaçGün.Size = new System.Drawing.Size(152, 22);
            this.txtKaçGün.TabIndex = 5;
            // 
            // lblÜcret
            // 
            this.lblÜcret.AutoSize = true;
            this.lblÜcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜcret.ForeColor = System.Drawing.Color.DarkRed;
            this.lblÜcret.Location = new System.Drawing.Point(929, 146);
            this.lblÜcret.Name = "lblÜcret";
            this.lblÜcret.Size = new System.Drawing.Size(17, 17);
            this.lblÜcret.TabIndex = 0;
            this.lblÜcret.Text = "0";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(946, 234);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(13, 17);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "-";
            this.lblTarih.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtimeKira
            // 
            this.dtimeKira.Location = new System.Drawing.Point(947, 196);
            this.dtimeKira.Name = "dtimeKira";
            this.dtimeKira.Size = new System.Drawing.Size(200, 22);
            this.dtimeKira.TabIndex = 7;
            // 
            // btnKiraHesapla
            // 
            this.btnKiraHesapla.Location = new System.Drawing.Point(1016, 139);
            this.btnKiraHesapla.Name = "btnKiraHesapla";
            this.btnKiraHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnKiraHesapla.TabIndex = 6;
            this.btnKiraHesapla.Text = "Hesapla";
            this.btnKiraHesapla.UseVisualStyleBackColor = true;
            this.btnKiraHesapla.Click += new System.EventHandler(this.btnKiraHesapla_Click);
            // 
            // dgvKiralanmisAraba
            // 
            this.dgvKiralanmisAraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralanmisAraba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KiraNo,
            this.MusteriId,
            this.AdSoyad,
            this.ArabaId,
            this.GünlükFiyat,
            this.KacGün,
            this.ToplamÜcret,
            this.KiralananTarih});
            this.dgvKiralanmisAraba.Location = new System.Drawing.Point(0, 250);
            this.dgvKiralanmisAraba.Name = "dgvKiralanmisAraba";
            this.dgvKiralanmisAraba.RowHeadersWidth = 51;
            this.dgvKiralanmisAraba.RowTemplate.Height = 24;
            this.dgvKiralanmisAraba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiralanmisAraba.Size = new System.Drawing.Size(1219, 242);
            this.dgvKiralanmisAraba.TabIndex = 8;
            this.dgvKiralanmisAraba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiralanmisAraba_CellContentClick);
            this.dgvKiralanmisAraba.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiralanmisAraba_RowEnter);
            // 
            // btnKiralanmisEkle
            // 
            this.btnKiralanmisEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKiralanmisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralanmisEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiralanmisEkle.ImageKey = "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png";
            this.btnKiralanmisEkle.ImageList = this.ımageList1;
            this.btnKiralanmisEkle.Location = new System.Drawing.Point(554, 57);
            this.btnKiralanmisEkle.Name = "btnKiralanmisEkle";
            this.btnKiralanmisEkle.Size = new System.Drawing.Size(196, 40);
            this.btnKiralanmisEkle.TabIndex = 9;
            this.btnKiralanmisEkle.Text = "Kiralık Araba Ekle";
            this.btnKiralanmisEkle.UseVisualStyleBackColor = false;
            this.btnKiralanmisEkle.Click += new System.EventHandler(this.btnKiralanmisEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "img_247218.png");
            this.ımageList1.Images.SetKeyName(1, "istockphoto-580128760-170667a.jpg");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png");
            this.ımageList1.Images.SetKeyName(3, "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
        "lipart.jpg");
            // 
            // btnKiralıkSil
            // 
            this.btnKiralıkSil.BackColor = System.Drawing.Color.Crimson;
            this.btnKiralıkSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralıkSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiralıkSil.ImageKey = "img_247218.png";
            this.btnKiralıkSil.ImageList = this.ımageList1;
            this.btnKiralıkSil.Location = new System.Drawing.Point(554, 105);
            this.btnKiralıkSil.Name = "btnKiralıkSil";
            this.btnKiralıkSil.Size = new System.Drawing.Size(196, 39);
            this.btnKiralıkSil.TabIndex = 10;
            this.btnKiralıkSil.Text = "Arabayı Sil";
            this.btnKiralıkSil.UseVisualStyleBackColor = false;
            this.btnKiralıkSil.Click += new System.EventHandler(this.btnKiralıkSil_Click);
            // 
            // btnKiralıkGüncelle
            // 
            this.btnKiralıkGüncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKiralıkGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralıkGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiralıkGüncelle.ImageKey = "istockphoto-580128760-170667a.jpg";
            this.btnKiralıkGüncelle.ImageList = this.ımageList1;
            this.btnKiralıkGüncelle.Location = new System.Drawing.Point(554, 150);
            this.btnKiralıkGüncelle.Name = "btnKiralıkGüncelle";
            this.btnKiralıkGüncelle.Size = new System.Drawing.Size(196, 37);
            this.btnKiralıkGüncelle.TabIndex = 11;
            this.btnKiralıkGüncelle.Text = "Güncelle";
            this.btnKiralıkGüncelle.UseVisualStyleBackColor = false;
            this.btnKiralıkGüncelle.Click += new System.EventHandler(this.btnKiralıkGüncelle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.BurlyWood;
            this.label10.Location = new System.Drawing.Point(247, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "KiraNo:";
            // 
            // txtKiraNo
            // 
            this.txtKiraNo.Location = new System.Drawing.Point(317, 75);
            this.txtKiraNo.Name = "txtKiraNo";
            this.txtKiraNo.Size = new System.Drawing.Size(152, 22);
            this.txtKiraNo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(498, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "KİRALANMIŞ ARAÇ LİSTESİ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
    "lipart.jpg";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(554, 193);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(196, 35);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // KiraNo
            // 
            this.KiraNo.DataPropertyName = "KiraNo";
            this.KiraNo.HeaderText = "Kiralık No";
            this.KiraNo.MinimumWidth = 6;
            this.KiraNo.Name = "KiraNo";
            this.KiraNo.Width = 125;
            // 
            // MusteriId
            // 
            this.MusteriId.DataPropertyName = "MusteriId";
            this.MusteriId.HeaderText = "Musteri No";
            this.MusteriId.MinimumWidth = 6;
            this.MusteriId.Name = "MusteriId";
            this.MusteriId.Width = 125;
            // 
            // AdSoyad
            // 
            this.AdSoyad.DataPropertyName = "AdSoyad";
            this.AdSoyad.HeaderText = "Ad - Soyad";
            this.AdSoyad.MinimumWidth = 6;
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.Width = 125;
            // 
            // ArabaId
            // 
            this.ArabaId.DataPropertyName = "ArabaId";
            this.ArabaId.HeaderText = "Araba No";
            this.ArabaId.MinimumWidth = 6;
            this.ArabaId.Name = "ArabaId";
            this.ArabaId.Width = 125;
            // 
            // GünlükFiyat
            // 
            this.GünlükFiyat.DataPropertyName = "GünlükFiyat";
            this.GünlükFiyat.HeaderText = "Günlük Ücreti";
            this.GünlükFiyat.MinimumWidth = 6;
            this.GünlükFiyat.Name = "GünlükFiyat";
            this.GünlükFiyat.Width = 125;
            // 
            // KacGün
            // 
            this.KacGün.DataPropertyName = "KacGün";
            this.KacGün.HeaderText = "Gün Sayısı";
            this.KacGün.MinimumWidth = 6;
            this.KacGün.Name = "KacGün";
            this.KacGün.Width = 125;
            // 
            // ToplamÜcret
            // 
            this.ToplamÜcret.DataPropertyName = "ToplamÜcret";
            this.ToplamÜcret.HeaderText = "Alınan Ücret";
            this.ToplamÜcret.MinimumWidth = 6;
            this.ToplamÜcret.Name = "ToplamÜcret";
            this.ToplamÜcret.Width = 125;
            // 
            // KiralananTarih
            // 
            this.KiralananTarih.DataPropertyName = "KiralananTarih";
            this.KiralananTarih.HeaderText = "Kiralama Tarihi";
            this.KiralananTarih.MinimumWidth = 6;
            this.KiralananTarih.Name = "KiralananTarih";
            this.KiralananTarih.Width = 125;
            // 
            // KiralanmisArabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1220, 491);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKiraNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKiralıkGüncelle);
            this.Controls.Add(this.btnKiralıkSil);
            this.Controls.Add(this.btnKiralanmisEkle);
            this.Controls.Add(this.dgvKiralanmisAraba);
            this.Controls.Add(this.btnKiraHesapla);
            this.Controls.Add(this.dtimeKira);
            this.Controls.Add(this.txtKaçGün);
            this.Controls.Add(this.txtGünlükFiyat);
            this.Controls.Add(this.txtKiraAradaId);
            this.Controls.Add(this.txtKiraAdSoyad);
            this.Controls.Add(this.txtKiraMusteriId);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblÜcret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KiralanmisArabalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiralanmisArabalar";
            this.Load += new System.EventHandler(this.KiralanmisArabalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKiraMusteriId;
        private System.Windows.Forms.TextBox txtKiraAdSoyad;
        private System.Windows.Forms.TextBox txtKiraAradaId;
        private System.Windows.Forms.TextBox txtGünlükFiyat;
        private System.Windows.Forms.TextBox txtKaçGün;
        private System.Windows.Forms.Label lblÜcret;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtimeKira;
        private System.Windows.Forms.Button btnKiraHesapla;
        private System.Windows.Forms.DataGridView dgvKiralanmisAraba;
        private System.Windows.Forms.Button btnKiralanmisEkle;
        private System.Windows.Forms.Button btnKiralıkSil;
        private System.Windows.Forms.Button btnKiralıkGüncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKiraNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GünlükFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KacGün;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamÜcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralananTarih;
    }
}