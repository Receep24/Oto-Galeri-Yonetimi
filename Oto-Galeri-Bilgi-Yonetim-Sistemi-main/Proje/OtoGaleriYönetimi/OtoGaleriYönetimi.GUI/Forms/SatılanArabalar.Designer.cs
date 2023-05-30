
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class SatılanArabalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatılanArabalar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSatilanNo = new System.Windows.Forms.TextBox();
            this.txtSatılanAradaId = new System.Windows.Forms.TextBox();
            this.txtSatilanAlis = new System.Windows.Forms.TextBox();
            this.txtSatilanSatis = new System.Windows.Forms.TextBox();
            this.lblKar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dgvSatilanArabalar = new System.Windows.Forms.DataGridView();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.btnSatılanıSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SatilanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArabaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatilanArabalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(209, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satılan No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(225, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ArabaId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(215, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alis Fiyati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(206, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satis Fiyati:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(252, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kar:";
            // 
            // txtSatilanNo
            // 
            this.txtSatilanNo.Location = new System.Drawing.Point(302, 78);
            this.txtSatilanNo.Name = "txtSatilanNo";
            this.txtSatilanNo.Size = new System.Drawing.Size(167, 22);
            this.txtSatilanNo.TabIndex = 1;
            // 
            // txtSatılanAradaId
            // 
            this.txtSatılanAradaId.Location = new System.Drawing.Point(302, 114);
            this.txtSatılanAradaId.Name = "txtSatılanAradaId";
            this.txtSatılanAradaId.Size = new System.Drawing.Size(167, 22);
            this.txtSatılanAradaId.TabIndex = 1;
            // 
            // txtSatilanAlis
            // 
            this.txtSatilanAlis.Location = new System.Drawing.Point(302, 149);
            this.txtSatilanAlis.Name = "txtSatilanAlis";
            this.txtSatilanAlis.Size = new System.Drawing.Size(167, 22);
            this.txtSatilanAlis.TabIndex = 1;
            // 
            // txtSatilanSatis
            // 
            this.txtSatilanSatis.Location = new System.Drawing.Point(302, 190);
            this.txtSatilanSatis.Name = "txtSatilanSatis";
            this.txtSatilanSatis.Size = new System.Drawing.Size(167, 22);
            this.txtSatilanSatis.TabIndex = 1;
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKar.ForeColor = System.Drawing.Color.Red;
            this.lblKar.Location = new System.Drawing.Point(302, 229);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(17, 17);
            this.lblKar.TabIndex = 2;
            this.lblKar.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(394, 221);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 33);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dgvSatilanArabalar
            // 
            this.dgvSatilanArabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatilanArabalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatilanNo,
            this.ArabaId,
            this.AlisFiyati,
            this.SatisFiyati,
            this.Kar});
            this.dgvSatilanArabalar.Location = new System.Drawing.Point(0, 293);
            this.dgvSatilanArabalar.Name = "dgvSatilanArabalar";
            this.dgvSatilanArabalar.RowHeadersWidth = 51;
            this.dgvSatilanArabalar.RowTemplate.Height = 24;
            this.dgvSatilanArabalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatilanArabalar.Size = new System.Drawing.Size(759, 254);
            this.dgvSatilanArabalar.TabIndex = 4;
            this.dgvSatilanArabalar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatilanArabalar_RowEnter);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSat.ImageKey = "pay-icon-1.jpg";
            this.btnSat.ImageList = this.ımageList1;
            this.btnSat.Location = new System.Drawing.Point(534, 78);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(173, 36);
            this.btnSat.TabIndex = 5;
            this.btnSat.Text = "Arabayı Sat";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBilgiGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilgiGüncelle.ImageKey = "istockphoto-580128760-170667a.jpg";
            this.btnBilgiGüncelle.ImageList = this.ımageList1;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(534, 128);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(173, 36);
            this.btnBilgiGüncelle.TabIndex = 5;
            this.btnBilgiGüncelle.Text = "Bilgileri Güncelle";
            this.btnBilgiGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // btnSatılanıSil
            // 
            this.btnSatılanıSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSatılanıSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatılanıSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatılanıSil.ImageKey = "img_247218.png";
            this.btnSatılanıSil.ImageList = this.ımageList1;
            this.btnSatılanıSil.Location = new System.Drawing.Point(534, 180);
            this.btnSatılanıSil.Name = "btnSatılanıSil";
            this.btnSatılanıSil.Size = new System.Drawing.Size(173, 36);
            this.btnSatılanıSil.TabIndex = 5;
            this.btnSatılanıSil.Text = "Satılanı Sil";
            this.btnSatılanıSil.UseVisualStyleBackColor = false;
            this.btnSatılanıSil.Click += new System.EventHandler(this.btnSatılanıSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "istockphoto-580128760-170667a.jpg");
            this.ımageList1.Images.SetKeyName(1, "img_247218.png");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-material-icon-plus-icon-add-symbol-material-flat-thumbnail.png");
            this.ımageList1.Images.SetKeyName(3, "pay-icon-1.jpg");
            this.ımageList1.Images.SetKeyName(4, "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
        "lipart.jpg");
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.ImageKey = "can-icon-delete-icon-remove-icon-trash-icon-yellow-material-property-symbol-png-c" +
    "lipart.jpg";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(534, 229);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(173, 34);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SatilanNo
            // 
            this.SatilanNo.DataPropertyName = "SatilanNo";
            this.SatilanNo.HeaderText = "Satış No";
            this.SatilanNo.MinimumWidth = 6;
            this.SatilanNo.Name = "SatilanNo";
            this.SatilanNo.Width = 125;
            // 
            // ArabaId
            // 
            this.ArabaId.DataPropertyName = "ArabaId";
            this.ArabaId.HeaderText = "Araba No";
            this.ArabaId.MinimumWidth = 6;
            this.ArabaId.Name = "ArabaId";
            this.ArabaId.Width = 125;
            // 
            // AlisFiyati
            // 
            this.AlisFiyati.DataPropertyName = "AlisFiyati";
            this.AlisFiyati.HeaderText = "Alış Fiyatı";
            this.AlisFiyati.MinimumWidth = 6;
            this.AlisFiyati.Name = "AlisFiyati";
            this.AlisFiyati.Width = 125;
            // 
            // SatisFiyati
            // 
            this.SatisFiyati.DataPropertyName = "SatisFiyati";
            this.SatisFiyati.HeaderText = "Satış Fiyatı";
            this.SatisFiyati.MinimumWidth = 6;
            this.SatisFiyati.Name = "SatisFiyati";
            this.SatisFiyati.Width = 125;
            // 
            // Kar
            // 
            this.Kar.DataPropertyName = "Kar";
            this.Kar.HeaderText = "Kazanılan Para";
            this.Kar.MinimumWidth = 6;
            this.Kar.Name = "Kar";
            this.Kar.Width = 125;
            // 
            // SatılanArabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 547);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatılanıSil);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.dgvSatilanArabalar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblKar);
            this.Controls.Add(this.txtSatilanSatis);
            this.Controls.Add(this.txtSatilanAlis);
            this.Controls.Add(this.txtSatılanAradaId);
            this.Controls.Add(this.txtSatilanNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SatılanArabalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatılanArabalar";
            this.Load += new System.EventHandler(this.SatılanArabalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatilanArabalar)).EndInit();
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
        private System.Windows.Forms.TextBox txtSatilanNo;
        private System.Windows.Forms.TextBox txtSatılanAradaId;
        private System.Windows.Forms.TextBox txtSatilanAlis;
        private System.Windows.Forms.TextBox txtSatilanSatis;
        private System.Windows.Forms.Label lblKar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dgvSatilanArabalar;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.Button btnSatılanıSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatilanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kar;
    }
}