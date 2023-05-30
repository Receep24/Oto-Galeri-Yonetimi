
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class ArabaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArabaKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArabaId = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtVites = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.pboxAracKayıt = new System.Windows.Forms.PictureBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dgvAracKayıtListele = new System.Windows.Forms.DataGridView();
            this.ArabaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AracResmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAracGüncelle = new System.Windows.Forms.Button();
            this.btnAracTemizle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAracKayıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracKayıtListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(263, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArabaId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(263, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(263, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(263, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Plaka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(573, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vites:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(573, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(536, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kayıt Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(862, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Arac Resmi:";
            // 
            // txtArabaId
            // 
            this.txtArabaId.Location = new System.Drawing.Point(328, 65);
            this.txtArabaId.Name = "txtArabaId";
            this.txtArabaId.Size = new System.Drawing.Size(149, 22);
            this.txtArabaId.TabIndex = 0;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(328, 95);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(149, 22);
            this.txtMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(328, 125);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(149, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(328, 156);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(149, 22);
            this.txtPlaka.TabIndex = 3;
            // 
            // txtVites
            // 
            this.txtVites.Location = new System.Drawing.Point(625, 67);
            this.txtVites.Name = "txtVites";
            this.txtVites.Size = new System.Drawing.Size(149, 22);
            this.txtVites.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(625, 97);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(149, 22);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(955, 176);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(149, 22);
            this.txtResim.TabIndex = 10;
            // 
            // pboxAracKayıt
            // 
            this.pboxAracKayıt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxAracKayıt.Location = new System.Drawing.Point(963, 34);
            this.pboxAracKayıt.Name = "pboxAracKayıt";
            this.pboxAracKayıt.Size = new System.Drawing.Size(141, 114);
            this.pboxAracKayıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAracKayıt.TabIndex = 2;
            this.pboxAracKayıt.TabStop = false;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(1111, 176);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(61, 24);
            this.btnSec.TabIndex = 9;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Location = new System.Drawing.Point(625, 128);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimeTarih.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(570, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tarih :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(622, 153);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(13, 17);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Text = "-";
            // 
            // dgvAracKayıtListele
            // 
            this.dgvAracKayıtListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracKayıtListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArabaId,
            this.Marka,
            this.Model,
            this.Plaka,
            this.Vites,
            this.Fiyat,
            this.KayitTarihi,
            this.AracResmi});
            this.dgvAracKayıtListele.Location = new System.Drawing.Point(2, 323);
            this.dgvAracKayıtListele.Name = "dgvAracKayıtListele";
            this.dgvAracKayıtListele.RowHeadersWidth = 51;
            this.dgvAracKayıtListele.RowTemplate.Height = 24;
            this.dgvAracKayıtListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAracKayıtListele.Size = new System.Drawing.Size(1195, 250);
            this.dgvAracKayıtListele.TabIndex = 6;
            this.dgvAracKayıtListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAracKayıtListele_CellClick);
            this.dgvAracKayıtListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAracKayıtListele_CellContentClick);
            // 
            // ArabaId
            // 
            this.ArabaId.DataPropertyName = "ArabaId";
            this.ArabaId.HeaderText = "ArabaNo";
            this.ArabaId.MinimumWidth = 6;
            this.ArabaId.Name = "ArabaId";
            this.ArabaId.Width = 125;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Arac Markası";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Aracın Modeli";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // Plaka
            // 
            this.Plaka.DataPropertyName = "Plaka";
            this.Plaka.HeaderText = "Arac Plakası";
            this.Plaka.MinimumWidth = 6;
            this.Plaka.Name = "Plaka";
            this.Plaka.Width = 125;
            // 
            // Vites
            // 
            this.Vites.DataPropertyName = "Vites";
            this.Vites.HeaderText = "Vites Tipi";
            this.Vites.MinimumWidth = 6;
            this.Vites.Name = "Vites";
            this.Vites.Width = 125;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Alınan Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 125;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "Kayıt Tarihi";
            this.KayitTarihi.MinimumWidth = 6;
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.Width = 125;
            // 
            // AracResmi
            // 
            this.AracResmi.DataPropertyName = "AracResmi";
            this.AracResmi.HeaderText = "Arac Resmi";
            this.AracResmi.MinimumWidth = 6;
            this.AracResmi.Name = "AracResmi";
            this.AracResmi.Width = 125;
            // 
            // btnAracGüncelle
            // 
            this.btnAracGüncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAracGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracGüncelle.ImageKey = "istockphoto-580128760-170667a.jpg";
            this.btnAracGüncelle.ImageList = this.ımageList1;
            this.btnAracGüncelle.Location = new System.Drawing.Point(518, 238);
            this.btnAracGüncelle.Name = "btnAracGüncelle";
            this.btnAracGüncelle.Size = new System.Drawing.Size(149, 38);
            this.btnAracGüncelle.TabIndex = 12;
            this.btnAracGüncelle.Text = "Arac Güncelle";
            this.btnAracGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAracGüncelle.UseVisualStyleBackColor = false;
            this.btnAracGüncelle.Click += new System.EventHandler(this.btnAracGüncelle_Click);
            // 
            // btnAracTemizle
            // 
            this.btnAracTemizle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAracTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracTemizle.ImageKey = "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
    "lipart.jpg";
            this.btnAracTemizle.ImageList = this.ımageList1;
            this.btnAracTemizle.Location = new System.Drawing.Point(811, 238);
            this.btnAracTemizle.Name = "btnAracTemizle";
            this.btnAracTemizle.Size = new System.Drawing.Size(135, 38);
            this.btnAracTemizle.TabIndex = 14;
            this.btnAracTemizle.Text = "Temizle";
            this.btnAracTemizle.UseVisualStyleBackColor = false;
            this.btnAracTemizle.Click += new System.EventHandler(this.btnAracTemizle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.Color.Crimson;
            this.btnAracSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracSil.ImageKey = "img_247218.png";
            this.btnAracSil.ImageList = this.ımageList1;
            this.btnAracSil.Location = new System.Drawing.Point(673, 238);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(132, 38);
            this.btnAracSil.TabIndex = 13;
            this.btnAracSil.Text = "Arac Sil";
            this.btnAracSil.UseVisualStyleBackColor = false;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(832, 127);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(97, 23);
            this.btnTarih.TabIndex = 7;
            this.btnTarih.Text = "Tarih Göster";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAracEkle.ImageKey = "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png";
            this.btnAracEkle.ImageList = this.ımageList1;
            this.btnAracEkle.Location = new System.Drawing.Point(372, 238);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(140, 38);
            this.btnAracEkle.TabIndex = 11;
            this.btnAracEkle.Text = "Arac Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png");
            this.ımageList1.Images.SetKeyName(1, "istockphoto-580128760-170667a.jpg");
            this.ımageList1.Images.SetKeyName(2, "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
        "lipart.jpg");
            this.ımageList1.Images.SetKeyName(3, "img_247218.png");
            // 
            // ArabaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracTemizle);
            this.Controls.Add(this.btnAracGüncelle);
            this.Controls.Add(this.dgvAracKayıtListele);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimeTarih);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.pboxAracKayıt);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtVites);
            this.Controls.Add(this.txtArabaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArabaKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArabaKayıt";
            this.Load += new System.EventHandler(this.ArabaKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAracKayıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracKayıtListele)).EndInit();
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
        private System.Windows.Forms.TextBox txtArabaId;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtVites;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.PictureBox pboxAracKayıt;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DataGridView dgvAracKayıtListele;
        private System.Windows.Forms.Button btnAracGüncelle;
        private System.Windows.Forms.Button btnAracTemizle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AracResmi;
        private System.Windows.Forms.ImageList ımageList1;
    }
}