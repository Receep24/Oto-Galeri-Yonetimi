
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class MusteriMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriMenü));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılığaUygunAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılıkArabalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamayaUygunAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkArabalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.satılığaUygunAraçlarToolStripMenuItem,
            this.kiralamayaUygunAraçlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem,
            this.geriToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.geriToolStripMenuItem.Text = "Geri ";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // satılığaUygunAraçlarToolStripMenuItem
            // 
            this.satılığaUygunAraçlarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.satılığaUygunAraçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satılıkArabalarToolStripMenuItem});
            this.satılığaUygunAraçlarToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satılığaUygunAraçlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.satılığaUygunAraçlarToolStripMenuItem.Name = "satılığaUygunAraçlarToolStripMenuItem";
            this.satılığaUygunAraçlarToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.satılığaUygunAraçlarToolStripMenuItem.Text = "Satılığa Uygun Araçlar";
            this.satılığaUygunAraçlarToolStripMenuItem.Click += new System.EventHandler(this.satılığaUygunAraçlarToolStripMenuItem_Click);
            // 
            // satılıkArabalarToolStripMenuItem
            // 
            this.satılıkArabalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satılıkArabalarToolStripMenuItem.Image")));
            this.satılıkArabalarToolStripMenuItem.Name = "satılıkArabalarToolStripMenuItem";
            this.satılıkArabalarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.satılıkArabalarToolStripMenuItem.Text = "Satılık Arabalar";
            this.satılıkArabalarToolStripMenuItem.Click += new System.EventHandler(this.satılıkArabalarToolStripMenuItem_Click);
            // 
            // kiralamayaUygunAraçlarToolStripMenuItem
            // 
            this.kiralamayaUygunAraçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiralıkArabalarToolStripMenuItem});
            this.kiralamayaUygunAraçlarToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kiralamayaUygunAraçlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kiralamayaUygunAraçlarToolStripMenuItem.Name = "kiralamayaUygunAraçlarToolStripMenuItem";
            this.kiralamayaUygunAraçlarToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.kiralamayaUygunAraçlarToolStripMenuItem.Text = "Kiralamaya Uygun Araçlar";
            this.kiralamayaUygunAraçlarToolStripMenuItem.Click += new System.EventHandler(this.kiralamayaUygunAraçlarToolStripMenuItem_Click);
            // 
            // kiralıkArabalarToolStripMenuItem
            // 
            this.kiralıkArabalarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kiralıkArabalarToolStripMenuItem.Image")));
            this.kiralıkArabalarToolStripMenuItem.Name = "kiralıkArabalarToolStripMenuItem";
            this.kiralıkArabalarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kiralıkArabalarToolStripMenuItem.Text = "Kiralık Arabalar";
            this.kiralıkArabalarToolStripMenuItem.Click += new System.EventHandler(this.kiralıkArabalarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MusteriMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusteriMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriMenü";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılığaUygunAraçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamayaUygunAraçlarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem satılıkArabalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralıkArabalarToolStripMenuItem;
    }
}