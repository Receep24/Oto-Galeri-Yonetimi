using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriYönetimi.GUI.Forms
{
    public partial class MusteriMenü : Form
    {
        public MusteriMenü()
        {
            InitializeComponent();
        }

        private void satılığaUygunAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void kiralamayaUygunAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış Yapmak İstediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            Application.Exit();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            this.Hide();
            girisForm.Show();
        }

        private void satılıkArabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriSatilikAraclar musteriSatilikAraclar = new MusteriSatilikAraclar();
            musteriSatilikAraclar.Show();
        }

        private void kiralıkArabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriKiralikAraclar musteriKiralikAraclar = new MusteriKiralikAraclar();
            musteriKiralikAraclar.Show();
        }
    }
}
