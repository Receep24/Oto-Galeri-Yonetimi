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
    public partial class SatılanArabalar : Form
    {
        public SatılanArabalar()
        {
            InitializeComponent();
        }
        SatilanArabalarBusiness satilanArabalarBusiness = new SatilanArabalarBusiness();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int a, b, kar;
            a = Convert.ToInt32(txtSatilanAlis.Text);
            b = Convert.ToInt32(txtSatilanSatis.Text);
            kar = b - a;
            lblKar.Text = kar.ToString();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            satilanArabalarBusiness.Add(new SatilanArabalar
            {
                ArabaId =Convert.ToInt32(txtSatılanAradaId.Text),
                AlisFiyati=txtSatilanAlis.Text,
                SatisFiyati=txtSatilanSatis.Text,
                Kar=lblKar.Text
            });
            dgvSatilanArabalar.DataSource = satilanArabalarBusiness.GetAll();
        }

        private void SatılanArabalar_Load(object sender, EventArgs e)
        {
            dgvSatilanArabalar.DataSource = satilanArabalarBusiness.GetAll();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            satilanArabalarBusiness.Edit(new SatilanArabalar
            {
                SatilanNo=Convert.ToInt32(txtSatilanNo.Text),
                ArabaId =Convert.ToInt32( txtSatılanAradaId.Text),
                AlisFiyati=txtSatilanAlis.Text,
                SatisFiyati=txtSatilanSatis.Text,
                Kar=lblKar.Text
            });
            dgvSatilanArabalar.DataSource = satilanArabalarBusiness.GetAll();
        }

        private void btnSatılanıSil_Click(object sender, EventArgs e)
        {
            satilanArabalarBusiness.Delete(Convert.ToInt32(txtSatilanNo.Text));
            dgvSatilanArabalar.DataSource = satilanArabalarBusiness.GetAll();
        }

        private void dgvSatilanArabalar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvSatilanArabalar.Rows[e.RowIndex];
            txtSatilanNo.Text = row.Cells["SatilanNo"].Value.ToString();
            txtSatılanAradaId.Text = row.Cells["ArabaId"].Value.ToString();
            txtSatilanAlis.Text = row.Cells["AlisFiyati"].Value.ToString();
            txtSatilanSatis.Text = row.Cells["SatisFiyati"].Value.ToString();
            lblKar.Text = row.Cells["Kar"].Value.ToString();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSatilanNo.Clear();
            txtSatilanSatis.Clear();
            txtSatilanAlis.Clear();
            txtSatılanAradaId.Clear();
            dgvSatilanArabalar.ClearSelection();

        }
    }
}
