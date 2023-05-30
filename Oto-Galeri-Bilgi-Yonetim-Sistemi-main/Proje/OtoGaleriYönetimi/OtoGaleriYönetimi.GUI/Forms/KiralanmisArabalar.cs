using OtoGaleriYönetimi.Business.Repository.Concrete;
using OtoGaleriYönetimi.Entities;
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
    public partial class KiralanmisArabalar : Form
    {
        public KiralanmisArabalar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KiralanmisArabalar_Load(object sender, EventArgs e)
        {
            dgvKiralanmisAraba.DataSource = kiralanmisAraba.GetAll();
        }

        private void btnKiraHesapla_Click(object sender, EventArgs e)
        {
            int a, b, sonuc;
            a = Convert.ToInt16(txtGünlükFiyat.Text);
            b = Convert.ToInt16(txtKaçGün.Text);

            sonuc = a * b;
            lblÜcret.Text = sonuc.ToString();
            lblTarih.Text = dtimeKira.Value.ToString("G");
        }
        KiralanmisArabaBusiness kiralanmisAraba = new KiralanmisArabaBusiness();
        private void btnKiralanmisEkle_Click(object sender, EventArgs e)
        {
            kiralanmisAraba.Add(new KiralanmisAraba
            {
                MusteriId=Convert.ToInt32(txtKiraMusteriId.Text),
                AdSoyad = txtKiraAdSoyad.Text,
                ArabaId=Convert.ToInt32(txtKiraAradaId.Text),
                GünlükFiyat=txtGünlükFiyat.Text,
                KacGün=txtKaçGün.Text,
                ToplamÜcret=lblÜcret.Text,
                KiralananTarih=lblTarih.Text
            });
            dgvKiralanmisAraba.DataSource = kiralanmisAraba.GetAll();

        }

        private void btnKiralıkSil_Click(object sender, EventArgs e)
        {
            kiralanmisAraba.Delete(Convert.ToInt32(txtKiraNo.Text));
            dgvKiralanmisAraba.DataSource = kiralanmisAraba.GetAll();
        }

        private void btnKiralıkGüncelle_Click(object sender, EventArgs e)
        {
            kiralanmisAraba.Edit(new KiralanmisAraba 
            { 
                KiraNo=Convert.ToInt32( txtKiraNo.Text),
                MusteriId=Convert.ToInt32( txtKiraMusteriId.Text),
                AdSoyad = txtKiraAdSoyad.Text,
                ArabaId=Convert.ToInt32(txtKiraAradaId.Text),
                GünlükFiyat=txtGünlükFiyat.Text,
                KacGün=txtKaçGün.Text,
                ToplamÜcret=lblÜcret.Text,
                KiralananTarih=lblTarih.Text
            
            });
            dgvKiralanmisAraba.DataSource = kiralanmisAraba.GetAll();
        }

        private void dgvKiralanmisAraba_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvKiralanmisAraba.Rows[e.RowIndex];
            txtKiraNo.Text = row.Cells["KiraNo"].Value.ToString();
            txtKiraMusteriId.Text = row.Cells["MusteriId"].Value.ToString();
            txtKiraAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
            txtKiraAradaId.Text = row.Cells["ArabaId"].Value.ToString();
            txtGünlükFiyat.Text = row.Cells["GünlükFiyat"].Value.ToString();
            txtKaçGün.Text = row.Cells["KacGün"].Value.ToString();
            lblÜcret.Text = row.Cells["ToplamÜcret"].Value.ToString();
            lblTarih.Text = row.Cells["KiralananTarih"].Value.ToString();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKiraNo.Clear();
            txtKiraAradaId.Clear();
            txtKiraMusteriId.Clear();
            txtKiraAdSoyad.Clear();
            txtKaçGün.Clear();
            txtGünlükFiyat.Clear();
            dgvKiralanmisAraba.ClearSelection();
        }

        private void dgvKiralanmisAraba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
