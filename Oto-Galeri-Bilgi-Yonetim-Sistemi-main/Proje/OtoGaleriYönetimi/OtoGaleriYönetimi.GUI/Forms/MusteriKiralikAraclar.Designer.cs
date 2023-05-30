
namespace OtoGaleriYönetimi.GUI.Forms
{
    partial class MusteriKiralikAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKiralikAraclar));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvKiralikuygun = new System.Windows.Forms.DataGridView();
            this.txtKiralikUResim = new System.Windows.Forms.TextBox();
            this.txtKiralikUFiyat = new System.Windows.Forms.TextBox();
            this.txtKiralikUModel = new System.Windows.Forms.TextBox();
            this.txtKiralikUMarka = new System.Windows.Forms.TextBox();
            this.txtKiralikUArabaId = new System.Windows.Forms.TextBox();
            this.txtKiralikNo = new System.Windows.Forms.TextBox();
            this.pboxKiralikUygun = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KiralikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArabaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GünlükFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AracResim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralikuygun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKiralikUygun)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvKiralikuygun
            // 
            this.dgvKiralikuygun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralikuygun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KiralikNo,
            this.ArabaId,
            this.Marka,
            this.Model,
            this.GünlükFiyat,
            this.AracResim});
            this.dgvKiralikuygun.Location = new System.Drawing.Point(413, 29);
            this.dgvKiralikuygun.Name = "dgvKiralikuygun";
            this.dgvKiralikuygun.RowHeadersWidth = 51;
            this.dgvKiralikuygun.RowTemplate.Height = 24;
            this.dgvKiralikuygun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiralikuygun.Size = new System.Drawing.Size(812, 456);
            this.dgvKiralikuygun.TabIndex = 23;
            this.dgvKiralikuygun.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiralikuygun_CellClick);
            // 
            // txtKiralikUResim
            // 
            this.txtKiralikUResim.Location = new System.Drawing.Point(130, 219);
            this.txtKiralikUResim.Name = "txtKiralikUResim";
            this.txtKiralikUResim.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikUResim.TabIndex = 17;
            // 
            // txtKiralikUFiyat
            // 
            this.txtKiralikUFiyat.Location = new System.Drawing.Point(130, 184);
            this.txtKiralikUFiyat.Name = "txtKiralikUFiyat";
            this.txtKiralikUFiyat.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikUFiyat.TabIndex = 13;
            // 
            // txtKiralikUModel
            // 
            this.txtKiralikUModel.Location = new System.Drawing.Point(130, 143);
            this.txtKiralikUModel.Name = "txtKiralikUModel";
            this.txtKiralikUModel.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikUModel.TabIndex = 14;
            // 
            // txtKiralikUMarka
            // 
            this.txtKiralikUMarka.Location = new System.Drawing.Point(130, 105);
            this.txtKiralikUMarka.Name = "txtKiralikUMarka";
            this.txtKiralikUMarka.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikUMarka.TabIndex = 18;
            // 
            // txtKiralikUArabaId
            // 
            this.txtKiralikUArabaId.Location = new System.Drawing.Point(130, 67);
            this.txtKiralikUArabaId.Name = "txtKiralikUArabaId";
            this.txtKiralikUArabaId.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikUArabaId.TabIndex = 15;
            // 
            // txtKiralikNo
            // 
            this.txtKiralikNo.Location = new System.Drawing.Point(130, 29);
            this.txtKiralikNo.Name = "txtKiralikNo";
            this.txtKiralikNo.Size = new System.Drawing.Size(146, 22);
            this.txtKiralikNo.TabIndex = 16;
            // 
            // pboxKiralikUygun
            // 
            this.pboxKiralikUygun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxKiralikUygun.Location = new System.Drawing.Point(59, 271);
            this.pboxKiralikUygun.Name = "pboxKiralikUygun";
            this.pboxKiralikUygun.Size = new System.Drawing.Size(256, 170);
            this.pboxKiralikUygun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxKiralikUygun.TabIndex = 12;
            this.pboxKiralikUygun.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(48, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "AracResim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "GünlükFiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(74, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(73, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ArabaId:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "KiralikNo:";
            // 
            // KiralikNo
            // 
            this.KiralikNo.DataPropertyName = "KiralikNo";
            this.KiralikNo.HeaderText = "Kira Numarası";
            this.KiralikNo.MinimumWidth = 6;
            this.KiralikNo.Name = "KiralikNo";
            this.KiralikNo.Width = 125;
            // 
            // ArabaId
            // 
            this.ArabaId.DataPropertyName = "ArabaId";
            this.ArabaId.HeaderText = "Araba No";
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
            this.Model.HeaderText = "Arac Modeli";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // GünlükFiyat
            // 
            this.GünlükFiyat.DataPropertyName = "GünlükFiyat";
            this.GünlükFiyat.HeaderText = "Günlük Ücret";
            this.GünlükFiyat.MinimumWidth = 6;
            this.GünlükFiyat.Name = "GünlükFiyat";
            this.GünlükFiyat.Width = 125;
            // 
            // AracResim
            // 
            this.AracResim.DataPropertyName = "AracResim";
            this.AracResim.HeaderText = "Arac Resmi";
            this.AracResim.MinimumWidth = 6;
            this.AracResim.Name = "AracResim";
            this.AracResim.Width = 125;
            // 
            // MusteriKiralikAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 541);
            this.Controls.Add(this.dgvKiralikuygun);
            this.Controls.Add(this.txtKiralikUResim);
            this.Controls.Add(this.txtKiralikUFiyat);
            this.Controls.Add(this.txtKiralikUModel);
            this.Controls.Add(this.txtKiralikUMarka);
            this.Controls.Add(this.txtKiralikUArabaId);
            this.Controls.Add(this.txtKiralikNo);
            this.Controls.Add(this.pboxKiralikUygun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriKiralikAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriKiralikAraclar";
            this.Load += new System.EventHandler(this.MusteriKiralikAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralikuygun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKiralikUygun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvKiralikuygun;
        private System.Windows.Forms.TextBox txtKiralikUResim;
        private System.Windows.Forms.TextBox txtKiralikUFiyat;
        private System.Windows.Forms.TextBox txtKiralikUModel;
        private System.Windows.Forms.TextBox txtKiralikUMarka;
        private System.Windows.Forms.TextBox txtKiralikUArabaId;
        private System.Windows.Forms.TextBox txtKiralikNo;
        private System.Windows.Forms.PictureBox pboxKiralikUygun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArabaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn GünlükFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AracResim;
    }
}