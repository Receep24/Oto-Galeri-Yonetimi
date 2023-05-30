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
    public partial class AdminMusteriler : Form
    {
        public AdminMusteriler()
        {
            InitializeComponent();
        }
        CustomerBusiness customerBusiness = new CustomerBusiness();
        private void btnMKaydet_Click(object sender, EventArgs e)
        {
            customerBusiness.Add(new Customer
            {
                ArabaId=Convert.ToInt32(txtMArabaId.Text),
                Ad=txtMAd.Text,
                Soyad=txtMSoyad.Text,
                Telefon=mtxMTelefon.Text,
                Email=txtMEmail.Text,
                Fiyat=txtMFiyat.Text
            });
            dgvMusteriler.DataSource = customerBusiness.GetAll();
        }

        private void btnMSil_Click(object sender, EventArgs e)
        {
            customerBusiness.Delete(Convert.ToInt32(txtMMusteriId.Text));
            dgvMusteriler.DataSource = customerBusiness.GetAll();
        }

        private void AdminMusteriler_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = customerBusiness.GetAll();
        }

        private void dgvMusteriler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMusteriler.Rows[e.RowIndex];
            txtMAd.Text = row.Cells["Ad"].Value.ToString();
            txtMArabaId.Text = row.Cells["ArabaId"].Value.ToString();
            txtMEmail.Text = row.Cells["Email"].Value.ToString();
            txtMFiyat.Text = row.Cells["Fiyat"].Value.ToString();
            txtMMusteriId.Text = row.Cells["MusteriId"].Value.ToString();
            txtMSoyad.Text = row.Cells["Soyad"].Value.ToString();
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMAd.Clear();
            txtMArabaId.Clear();
            txtMEmail.Clear();
            txtMFiyat.Clear();
            txtMMusteriId.Clear();
            txtMSoyad.Clear();
            dgvMusteriler.ClearSelection();

        }
    }
}
