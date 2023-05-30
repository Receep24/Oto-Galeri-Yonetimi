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
    public partial class SatilikUygunAraclar : Form
    {
        public SatilikUygunAraclar()
        {
            InitializeComponent();
        }
        SatilikAraclarBusiness satilikAraclar = new SatilikAraclarBusiness();

        private void SatilikUygunAraclar_Load(object sender, EventArgs e)
        {
            dgvSatilikUygun.DataSource = satilikAraclar.GetAll();
        }

        private void btnSatilikSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pboxSatilikAraba.ImageLocation = openFileDialog1.FileName;
            txtSatisaUygunResim.Text = openFileDialog1.FileName;
        }

        private void btnSatisUygunEkle_Click(object sender, EventArgs e)
        {
            satilikAraclar.Add(new SatilikAraclar
            {
                ArabaId=Convert.ToInt32(txtSatilikUArabaId.Text),
                Marka=txtSatilikUMarka.Text,
                Model=txtSatilikUModel.Text,
                Plaka=txtSatilikUPlaka.Text,
                Vites=txtSatilikUvites.Text,
                Km=txtSatilikUkm.Text,
                Fiyat=txtSatilikUFiyat.Text,
                AracResim=txtSatisaUygunResim.Text
            });
            dgvSatilikUygun.DataSource = satilikAraclar.GetAll();
        }

        private void btnSatisUygunGüncl_Click(object sender, EventArgs e)
        {
            satilikAraclar.Edit(new SatilikAraclar
            {
                SatilikNo=Convert.ToInt32(txtSatilikNo.Text),
                ArabaId = Convert.ToInt32(txtSatilikUArabaId.Text),
                Marka = txtSatilikUMarka.Text,
                Model = txtSatilikUModel.Text,
                Plaka = txtSatilikUPlaka.Text,
                Vites = txtSatilikUvites.Text,
                Km = txtSatilikUkm.Text,
                Fiyat = txtSatilikUFiyat.Text,
                AracResim = txtSatisaUygunResim.Text

            });
            dgvSatilikUygun.DataSource = satilikAraclar.GetAll();
        }

        private void btnSatisUygunSil_Click(object sender, EventArgs e)
        {
            satilikAraclar.Delete(Convert.ToInt32(txtSatilikNo.Text));
            dgvSatilikUygun.DataSource = satilikAraclar.GetAll();
        }

        private void dgvSatilikUygun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvSatilikUygun.SelectedCells[0].RowIndex;
            txtSatilikNo.Text = dgvSatilikUygun.Rows[secilen].Cells[0].Value.ToString();
            txtSatilikUArabaId.Text = dgvSatilikUygun.Rows[secilen].Cells[1].Value.ToString();
            txtSatilikUMarka.Text = dgvSatilikUygun.Rows[secilen].Cells[2].Value.ToString();
            txtSatilikUPlaka.Text = dgvSatilikUygun.Rows[secilen].Cells[3].Value.ToString();
            txtSatilikUModel.Text = dgvSatilikUygun.Rows[secilen].Cells[4].Value.ToString();
            txtSatilikUvites.Text = dgvSatilikUygun.Rows[secilen].Cells[5].Value.ToString();
            txtSatilikUkm.Text = dgvSatilikUygun.Rows[secilen].Cells[6].Value.ToString();
            txtSatilikUFiyat.Text = dgvSatilikUygun.Rows[secilen].Cells[7].Value.ToString();
            txtSatisaUygunResim.Text = dgvSatilikUygun.Rows[secilen].Cells[8].Value.ToString();

            txtSatisaUygunResim.Text = dgvSatilikUygun.Rows[secilen].Cells[8].Value.ToString();
            pboxSatilikAraba.ImageLocation = dgvSatilikUygun.Rows[secilen].Cells[8].Value.ToString();
        }

        private void btnTemizzle_Click(object sender, EventArgs e)
        {
            txtSatilikNo.Clear();
            txtSatilikUArabaId.Clear();
            txtSatilikUFiyat.Clear();
            txtSatilikUkm.Clear();
            txtSatilikUMarka.Clear();
            txtSatilikUModel.Clear();
            txtSatilikUPlaka.Clear();
            txtSatilikUvites.Clear();
            txtSatisaUygunResim.Clear();
            dgvSatilikUygun.ClearSelection();
        }
    }
}
