
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class AdminKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminKayıt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminSave = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAdminSoyad = new System.Windows.Forms.TextBox();
            this.txtAdminAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminSave
            // 
            this.btnAdminSave.BackColor = System.Drawing.Color.Teal;
            this.btnAdminSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminSave.ImageKey = "kisspng-floppy-disk-scalable-vector-graphics-computer-icon-5c0f3566b07633.5678515" +
    "315445005827228.jpg";
            this.btnAdminSave.ImageList = this.ımageList1;
            this.btnAdminSave.Location = new System.Drawing.Point(408, 369);
            this.btnAdminSave.Name = "btnAdminSave";
            this.btnAdminSave.Size = new System.Drawing.Size(97, 45);
            this.btnAdminSave.TabIndex = 4;
            this.btnAdminSave.Text = "Kaydet";
            this.btnAdminSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminSave.UseVisualStyleBackColor = false;
            this.btnAdminSave.Click += new System.EventHandler(this.btnAdminSave_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kisspng-floppy-disk-scalable-vector-graphics-computer-icon-5c0f3566b07633.5678515" +
        "315445005827228.jpg");
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(389, 318);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(158, 22);
            this.txtAdminSifre.TabIndex = 3;
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(389, 270);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(158, 22);
            this.txtAdminKullaniciAdi.TabIndex = 2;
            // 
            // txtAdminSoyad
            // 
            this.txtAdminSoyad.Location = new System.Drawing.Point(389, 222);
            this.txtAdminSoyad.Name = "txtAdminSoyad";
            this.txtAdminSoyad.Size = new System.Drawing.Size(158, 22);
            this.txtAdminSoyad.TabIndex = 1;
            // 
            // txtAdminAd
            // 
            this.txtAdminAd.Location = new System.Drawing.Point(389, 182);
            this.txtAdminAd.Name = "txtAdminAd";
            this.txtAdminAd.Size = new System.Drawing.Size(158, 22);
            this.txtAdminAd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ad:";
            // 
            // AdminKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdminSave);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.txtAdminKullaniciAdi);
            this.Controls.Add(this.txtAdminSoyad);
            this.Controls.Add(this.txtAdminAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AdminKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminKayıt";
            this.Load += new System.EventHandler(this.AdminKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminSave;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.TextBox txtAdminSoyad;
        private System.Windows.Forms.TextBox txtAdminAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}