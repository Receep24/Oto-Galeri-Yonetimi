
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class AdminMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMusteriler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMMusteriId = new System.Windows.Forms.TextBox();
            this.txtMArabaId = new System.Windows.Forms.TextBox();
            this.txtMAd = new System.Windows.Forms.TextBox();
            this.txtMSoyad = new System.Windows.Forms.TextBox();
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.txtMFiyat = new System.Windows.Forms.TextBox();
            this.mtxMTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.pboxMusteri = new System.Windows.Forms.PictureBox();
            this.btnMKaydet = new System.Windows.Forms.Button();
            this.btnMSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.MusteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArabaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MusteriId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(21, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ArabaId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(53, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(30, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(22, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(36, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(40, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiyat:";
            // 
            // txtMMusteriId
            // 
            this.txtMMusteriId.Location = new System.Drawing.Point(88, 189);
            this.txtMMusteriId.Name = "txtMMusteriId";
            this.txtMMusteriId.Size = new System.Drawing.Size(152, 22);
            this.txtMMusteriId.TabIndex = 0;
            // 
            // txtMArabaId
            // 
            this.txtMArabaId.Location = new System.Drawing.Point(88, 220);
            this.txtMArabaId.Name = "txtMArabaId";
            this.txtMArabaId.Size = new System.Drawing.Size(152, 22);
            this.txtMArabaId.TabIndex = 1;
            // 
            // txtMAd
            // 
            this.txtMAd.Location = new System.Drawing.Point(88, 255);
            this.txtMAd.Name = "txtMAd";
            this.txtMAd.Size = new System.Drawing.Size(152, 22);
            this.txtMAd.TabIndex = 2;
            // 
            // txtMSoyad
            // 
            this.txtMSoyad.Location = new System.Drawing.Point(88, 291);
            this.txtMSoyad.Name = "txtMSoyad";
            this.txtMSoyad.Size = new System.Drawing.Size(152, 22);
            this.txtMSoyad.TabIndex = 3;
            // 
            // txtMEmail
            // 
            this.txtMEmail.Location = new System.Drawing.Point(88, 367);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.Size = new System.Drawing.Size(152, 22);
            this.txtMEmail.TabIndex = 5;
            // 
            // txtMFiyat
            // 
            this.txtMFiyat.Location = new System.Drawing.Point(88, 404);
            this.txtMFiyat.Name = "txtMFiyat";
            this.txtMFiyat.Size = new System.Drawing.Size(152, 22);
            this.txtMFiyat.TabIndex = 6;
            // 
            // mtxMTelefon
            // 
            this.mtxMTelefon.Location = new System.Drawing.Point(88, 331);
            this.mtxMTelefon.Mask = "(999) 000-0000";
            this.mtxMTelefon.Name = "mtxMTelefon";
            this.mtxMTelefon.Size = new System.Drawing.Size(152, 22);
            this.mtxMTelefon.TabIndex = 4;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusteriId,
            this.ArabaId,
            this.Ad,
            this.Soyad,
            this.Telefon,
            this.Email,
            this.Fiyat});
            this.dgvMusteriler.Location = new System.Drawing.Point(274, 48);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.RowHeadersWidth = 51;
            this.dgvMusteriler.RowTemplate.Height = 24;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(812, 378);
            this.dgvMusteriler.TabIndex = 9;
            this.dgvMusteriler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_RowEnter);
            // 
            // pboxMusteri
            // 
            this.pboxMusteri.Image = ((System.Drawing.Image)(resources.GetObject("pboxMusteri.Image")));
            this.pboxMusteri.Location = new System.Drawing.Point(72, 48);
            this.pboxMusteri.Name = "pboxMusteri";
            this.pboxMusteri.Size = new System.Drawing.Size(154, 106);
            this.pboxMusteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMusteri.TabIndex = 4;
            this.pboxMusteri.TabStop = false;
            // 
            // btnMKaydet
            // 
            this.btnMKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMKaydet.ImageKey = "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png";
            this.btnMKaydet.ImageList = this.ımageList1;
            this.btnMKaydet.Location = new System.Drawing.Point(12, 437);
            this.btnMKaydet.Name = "btnMKaydet";
            this.btnMKaydet.Size = new System.Drawing.Size(102, 44);
            this.btnMKaydet.TabIndex = 7;
            this.btnMKaydet.Text = "Kaydet";
            this.btnMKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMKaydet.UseVisualStyleBackColor = false;
            this.btnMKaydet.Click += new System.EventHandler(this.btnMKaydet_Click);
            // 
            // btnMSil
            // 
            this.btnMSil.BackColor = System.Drawing.Color.Crimson;
            this.btnMSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMSil.ImageKey = "img_247218.png";
            this.btnMSil.ImageList = this.ımageList1;
            this.btnMSil.Location = new System.Drawing.Point(151, 437);
            this.btnMSil.Name = "btnMSil";
            this.btnMSil.Size = new System.Drawing.Size(104, 44);
            this.btnMSil.TabIndex = 8;
            this.btnMSil.Text = "Sil";
            this.btnMSil.UseVisualStyleBackColor = false;
            this.btnMSil.Click += new System.EventHandler(this.btnMSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png");
            this.ımageList1.Images.SetKeyName(1, "kisspng-computer-icons-vector-graphics-image-icon-design-i-flat-delete-icon-bing-" +
        "images-5b7b43bf9584a3.3036558615348049276124.jpg");
            this.ımageList1.Images.SetKeyName(2, "img_247218.png");
            this.ımageList1.Images.SetKeyName(3, "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
        "lipart.jpg");
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
    "lipart.jpg";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(297, 437);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 44);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // MusteriId
            // 
            this.MusteriId.DataPropertyName = "MusteriId";
            this.MusteriId.HeaderText = "Musteri No";
            this.MusteriId.MinimumWidth = 6;
            this.MusteriId.Name = "MusteriId";
            this.MusteriId.Width = 125;
            // 
            // ArabaId
            // 
            this.ArabaId.DataPropertyName = "ArabaId";
            this.ArabaId.HeaderText = "Araba No";
            this.ArabaId.MinimumWidth = 6;
            this.ArabaId.Name = "ArabaId";
            this.ArabaId.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Musteri Adı";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Musteri Soyadı";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon Numarası";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Mail Adresi";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Alınan Ücret";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 125;
            // 
            // AdminMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 493);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnMSil);
            this.Controls.Add(this.btnMKaydet);
            this.Controls.Add(this.pboxMusteri);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.mtxMTelefon);
            this.Controls.Add(this.txtMFiyat);
            this.Controls.Add(this.txtMEmail);
            this.Controls.Add(this.txtMSoyad);
            this.Controls.Add(this.txtMAd);
            this.Controls.Add(this.txtMArabaId);
            this.Controls.Add(this.txtMMusteriId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMusteriler";
            this.Load += new System.EventHandler(this.AdminMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMusteri)).EndInit();
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
        private System.Windows.Forms.TextBox txtMMusteriId;
        private System.Windows.Forms.TextBox txtMArabaId;
        private System.Windows.Forms.TextBox txtMAd;
        private System.Windows.Forms.TextBox txtMSoyad;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.TextBox txtMFiyat;
        private System.Windows.Forms.MaskedTextBox mtxMTelefon;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.PictureBox pboxMusteri;
        private System.Windows.Forms.Button btnMKaydet;
        private System.Windows.Forms.Button btnMSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}