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
    public partial class ArabaKayıt : Form
    {
        public ArabaKayıt()
        {
            InitializeComponent();
        }
        ArabalarBusiness arabalarBusiness = new ArabalarBusiness();

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pboxAracKayıt.ImageLocation = openFileDialog1.FileName;
            txtResim.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            lblTarih.Text = dateTimeTarih.Value.ToString("G");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            arabalarBusiness.Add(new Arabalar
            {
                Marka=txtMarka.Text,
                Model=txtModel.Text,
                Plaka=txtPlaka.Text,
                Vites=txtVites.Text,
                Fiyat=txtFiyat.Text,
                KayitTarihi=lblTarih.Text,
                AracResmi=txtResim.Text
            });
            dgvAracKayıtListele.DataSource = arabalarBusiness.GetAll();
        }

        private void ArabaKayıt_Load(object sender, EventArgs e)
        {
            dgvAracKayıtListele.DataSource = arabalarBusiness.GetAll();
        }

        private void dgvAracKayıtListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAracKayıtListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvAracKayıtListele.SelectedCells[0].RowIndex;
            txtArabaId.Text = dgvAracKayıtListele.Rows[secilen].Cells[0].Value.ToString();
            txtMarka.Text = dgvAracKayıtListele.Rows[secilen].Cells[1].Value.ToString();
            txtModel.Text = dgvAracKayıtListele.Rows[secilen].Cells[2].Value.ToString();
            txtPlaka.Text = dgvAracKayıtListele.Rows[secilen].Cells[3].Value.ToString();
            txtVites.Text = dgvAracKayıtListele.Rows[secilen].Cells[4].Value.ToString();
            txtFiyat.Text = dgvAracKayıtListele.Rows[secilen].Cells[5].Value.ToString();
            lblTarih.Text = dgvAracKayıtListele.Rows[secilen].Cells[6].Value.ToString();
            txtResim.Text = dgvAracKayıtListele.Rows[secilen].Cells[7].Value.ToString();

            txtResim.Text = dgvAracKayıtListele.Rows[secilen].Cells[7].Value.ToString();
            pboxAracKayıt.ImageLocation = dgvAracKayıtListele.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnAracGüncelle_Click(object sender, EventArgs e)
        {
            arabalarBusiness.Edit(new Arabalar
            {
                ArabaId=Convert.ToInt32 (txtArabaId.Text),
                Marka=txtMarka.Text,
                Model=txtModel.Text,
                Plaka=txtPlaka.Text,
                Vites=txtVites.Text,
                Fiyat=txtFiyat.Text,
                KayitTarihi=lblTarih.Text,
                AracResmi=txtResim.Text
                
            });
            dgvAracKayıtListele.DataSource = arabalarBusiness.GetAll();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            arabalarBusiness.Delete(Convert.ToInt32(txtArabaId.Text));
            dgvAracKayıtListele.DataSource = arabalarBusiness.GetAll();

        }

        private void btnAracTemizle_Click(object sender, EventArgs e)
        {
            txtArabaId.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtVites.Clear();
            txtFiyat.Clear();
            txtResim.Clear();
            dgvAracKayıtListele.ClearSelection();
           

        }
    }
}
