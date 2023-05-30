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
    public partial class MusteriKayıt : Form
    {
        public MusteriKayıt()
        {
            InitializeComponent();
        }
        CustomerUserBusiness customerUserBusiness = new CustomerUserBusiness();
        private void btnCusKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OtoGaleriYönetimiEntities())
                {

                    customerUserBusiness.Add(new CustomerUser
                    {

                        FirstName = txtCusAd.Text,
                        LastName = txtCusSoyad.Text,
                        UserName = txtCusKullaniciAdi.Text,
                        Password = txtCusSifre.Text

                    });
                    db.SaveChanges();
                    MessageBox.Show("Başarılı Bir şekilde Kaıyt Oldu");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }
    }
}
