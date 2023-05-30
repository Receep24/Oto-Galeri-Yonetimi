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
    public partial class AdminMenü : Form
    {
        public AdminMenü()
        {
            InitializeComponent();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArabaKayıt arabaKayıt = new ArabaKayıt();
       
            arabaKayıt.Show();
        }

        private void arabaSatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatılanArabalar satılanArabalar = new SatılanArabalar();
            satılanArabalar.Show();
        }

        private void arabaKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralanmisArabalar kiralananArabalar = new KiralanmisArabalar();
            kiralananArabalar.Show();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMusteriler adminMusteriler = new AdminMusteriler();
            adminMusteriler.Show();
        }

        private void satışaUygunAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatilikUygunAraclar satilikUygunAraclar = new SatilikUygunAraclar();
            satilikUygunAraclar.Show();
        }

        private void kiralamayaUygunAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralikUygunAraclar kiralikUygunAraclar = new KiralikUygunAraclar();
            kiralikUygunAraclar.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AdminMenü_Load(object sender, EventArgs e)
        {

        }
    }
}
