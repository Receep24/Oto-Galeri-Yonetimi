
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class MusteriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKayıt));
            this.btnCusKayıt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCusSifre = new System.Windows.Forms.TextBox();
            this.txtCusKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtCusSoyad = new System.Windows.Forms.TextBox();
            this.txtCusAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCusKayıt
            // 
            this.btnCusKayıt.BackColor = System.Drawing.Color.Teal;
            this.btnCusKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCusKayıt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusKayıt.ImageKey = "kisspng-floppy-disk-scalable-vector-graphics-computer-icon-5c0f3566b07633.5678515" +
    "315445005827228.jpg";
            this.btnCusKayıt.ImageList = this.ımageList1;
            this.btnCusKayıt.Location = new System.Drawing.Point(415, 371);
            this.btnCusKayıt.Name = "btnCusKayıt";
            this.btnCusKayıt.Size = new System.Drawing.Size(115, 45);
            this.btnCusKayıt.TabIndex = 4;
            this.btnCusKayıt.Text = "Kayıt";
            this.btnCusKayıt.UseVisualStyleBackColor = false;
            this.btnCusKayıt.Click += new System.EventHandler(this.btnCusKayıt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // txtCusSifre
            // 
            this.txtCusSifre.Location = new System.Drawing.Point(402, 317);
            this.txtCusSifre.Name = "txtCusSifre";
            this.txtCusSifre.PasswordChar = '*';
            this.txtCusSifre.Size = new System.Drawing.Size(158, 22);
            this.txtCusSifre.TabIndex = 3;
            // 
            // txtCusKullaniciAdi
            // 
            this.txtCusKullaniciAdi.Location = new System.Drawing.Point(402, 269);
            this.txtCusKullaniciAdi.Name = "txtCusKullaniciAdi";
            this.txtCusKullaniciAdi.Size = new System.Drawing.Size(158, 22);
            this.txtCusKullaniciAdi.TabIndex = 2;
            // 
            // txtCusSoyad
            // 
            this.txtCusSoyad.Location = new System.Drawing.Point(402, 221);
            this.txtCusSoyad.Name = "txtCusSoyad";
            this.txtCusSoyad.Size = new System.Drawing.Size(158, 22);
            this.txtCusSoyad.TabIndex = 1;
            // 
            // txtCusAd
            // 
            this.txtCusAd.Location = new System.Drawing.Point(402, 181);
            this.txtCusAd.Name = "txtCusAd";
            this.txtCusAd.Size = new System.Drawing.Size(158, 22);
            this.txtCusAd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ad:";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kisspng-floppy-disk-scalable-vector-graphics-computer-icon-5c0f3566b07633.5678515" +
        "315445005827228.jpg");
            // 
            // MusteriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnCusKayıt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCusSifre);
            this.Controls.Add(this.txtCusKullaniciAdi);
            this.Controls.Add(this.txtCusSoyad);
            this.Controls.Add(this.txtCusAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "MusteriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriKayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCusKayıt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCusSifre;
        private System.Windows.Forms.TextBox txtCusKullaniciAdi;
        private System.Windows.Forms.TextBox txtCusSoyad;
        private System.Windows.Forms.TextBox txtCusAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}