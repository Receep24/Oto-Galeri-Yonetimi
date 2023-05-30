using OtoGaleriYönetimi.Business.Repository.Concrete;
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
    public partial class MusteriKiralikAraclar : Form
    {
        public MusteriKiralikAraclar()
        {
            InitializeComponent();
        }
        KiralikAraclarBusiness kiralikAraclarBusiness = new KiralikAraclarBusiness();

        private void btnKiralikuygunSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pboxKiralikUygun.ImageLocation = openFileDialog1.FileName;
            txtKiralikUResim.Text = openFileDialog1.FileName;
        }

        private void dgvKiralikuygun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvKiralikuygun.SelectedCells[0].RowIndex;
            txtKiralikNo.Text = dgvKiralikuygun.Rows[secilen].Cells[0].Value.ToString();
            txtKiralikUArabaId.Text = dgvKiralikuygun.Rows[secilen].Cells[1].Value.ToString();
            txtKiralikUMarka.Text = dgvKiralikuygun.Rows[secilen].Cells[2].Value.ToString();
            txtKiralikUModel.Text = dgvKiralikuygun.Rows[secilen].Cells[3].Value.ToString();
            txtKiralikUFiyat.Text = dgvKiralikuygun.Rows[secilen].Cells[4].Value.ToString();
            txtKiralikUResim.Text = dgvKiralikuygun.Rows[secilen].Cells[5].Value.ToString();


            txtKiralikUResim.Text = dgvKiralikuygun.Rows[secilen].Cells[5].Value.ToString();
            pboxKiralikUygun.ImageLocation = dgvKiralikuygun.Rows[secilen].Cells[5].Value.ToString();
        }

        private void MusteriKiralikAraclar_Load(object sender, EventArgs e)
        {
            dgvKiralikuygun.DataSource = kiralikAraclarBusiness.GetAll();
        }
    }
}
