
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class AdminMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenü));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaSatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabaKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışaUygunAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamayaUygunAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.galeriİşlemleriToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.kiralamaİşlemleriToolStripMenuItem,
            this.arabalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // galeriİşlemleriToolStripMenuItem
            // 
            this.galeriİşlemleriToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.galeriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.musteriEkleToolStripMenuItem});
            this.galeriİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.galeriİşlemleriToolStripMenuItem.Name = "galeriİşlemleriToolStripMenuItem";
            this.galeriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(155, 27);
            this.galeriİşlemleriToolStripMenuItem.Text = "Galeri İşlemleri";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçEkleToolStripMenuItem.Image")));
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.araçEkleToolStripMenuItem.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.araçEkleToolStripMenuItem_Click);
            // 
            // musteriEkleToolStripMenuItem
            // 
            this.musteriEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("musteriEkleToolStripMenuItem.Image")));
            this.musteriEkleToolStripMenuItem.Name = "musteriEkleToolStripMenuItem";
            this.musteriEkleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.musteriEkleToolStripMenuItem.Text = "Musteri Ekle";
            this.musteriEkleToolStripMenuItem.Click += new System.EventHandler(this.musteriEkleToolStripMenuItem_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabaSatToolStripMenuItem});
            this.satışİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(148, 27);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // arabaSatToolStripMenuItem
            // 
            this.arabaSatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arabaSatToolStripMenuItem.Image")));
            this.arabaSatToolStripMenuItem.Name = "arabaSatToolStripMenuItem";
            this.arabaSatToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.arabaSatToolStripMenuItem.Text = "Araba Sat";
            this.arabaSatToolStripMenuItem.Click += new System.EventHandler(this.arabaSatToolStripMenuItem_Click);
            // 
            // kiralamaİşlemleriToolStripMenuItem
            // 
            this.kiralamaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabaKiralaToolStripMenuItem});
            this.kiralamaİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralamaİşlemleriToolStripMenuItem.Name = "kiralamaİşlemleriToolStripMenuItem";
            this.kiralamaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(181, 27);
            this.kiralamaİşlemleriToolStripMenuItem.Text = "Kiralama İşlemleri";
            // 
            // arabaKiralaToolStripMenuItem
            // 
            this.arabaKiralaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("arabaKiralaToolStripMenuItem.Image")));
            this.arabaKiralaToolStripMenuItem.Name = "arabaKiralaToolStripMenuItem";
            this.arabaKiralaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.arabaKiralaToolStripMenuItem.Text = "Araba Kirala";
            this.arabaKiralaToolStripMenuItem.Click += new System.EventHandler(this.arabaKiralaToolStripMenuItem_Click);
            // 
            // arabalarToolStripMenuItem
            // 
            this.arabalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışaUygunAraçlarToolStripMenuItem,
            this.kiralamayaUygunAraçlarToolStripMenuItem});
            this.arabalarToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arabalarToolStripMenuItem.Name = "arabalarToolStripMenuItem";
            this.arabalarToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.arabalarToolStripMenuItem.Text = "Arabalar";
            // 
            // satışaUygunAraçlarToolStripMenuItem
            // 
            this.satışaUygunAraçlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satışaUygunAraçlarToolStripMenuItem.Image")));
            this.satışaUygunAraçlarToolStripMenuItem.Name = "satışaUygunAraçlarToolStripMenuItem";
            this.satışaUygunAraçlarToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.satışaUygunAraçlarToolStripMenuItem.Text = "Satışa Uygun Araçlar";
            this.satışaUygunAraçlarToolStripMenuItem.Click += new System.EventHandler(this.satışaUygunAraçlarToolStripMenuItem_Click);
            // 
            // kiralamayaUygunAraçlarToolStripMenuItem
            // 
            this.kiralamayaUygunAraçlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kiralamayaUygunAraçlarToolStripMenuItem.Image")));
            this.kiralamayaUygunAraçlarToolStripMenuItem.Name = "kiralamayaUygunAraçlarToolStripMenuItem";
            this.kiralamayaUygunAraçlarToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.kiralamayaUygunAraçlarToolStripMenuItem.Text = "Kiralamaya Uygun Araçlar";
            this.kiralamayaUygunAraçlarToolStripMenuItem.Click += new System.EventHandler(this.kiralamayaUygunAraçlarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenü";
            this.Load += new System.EventHandler(this.AdminMenü_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaSatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabaKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışaUygunAraçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamayaUygunAraçlarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}