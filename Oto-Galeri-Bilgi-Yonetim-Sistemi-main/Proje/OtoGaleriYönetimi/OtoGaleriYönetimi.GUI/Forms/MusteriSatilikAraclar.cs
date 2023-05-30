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
    public partial class MusteriSatilikAraclar : Form
    {
        public MusteriSatilikAraclar()
        {
            InitializeComponent();
        }
        SatilikAraclarBusiness satilikAraclarBusiness = new SatilikAraclarBusiness();

        private void btnSatilikSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pboxSatilikAraba.ImageLocation = openFileDialog1.FileName;
            txtSatisaUygunResim.Text = openFileDialog1.FileName;
        }

        private void MusteriSatilikAraclar_Load(object sender, EventArgs e)
        {
            dgvSatilikUygun.DataSource = satilikAraclarBusiness.GetAll();
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
    }
}
