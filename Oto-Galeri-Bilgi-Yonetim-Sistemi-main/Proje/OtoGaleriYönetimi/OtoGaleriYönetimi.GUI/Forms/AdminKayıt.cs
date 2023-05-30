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
    public partial class AdminKayıt : Form
    {
        public AdminKayıt()
        {
            InitializeComponent();
        }
        AdminUserBusiness adminUserBusiness = new AdminUserBusiness();
        

        private void btnAdminSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OtoGaleriYönetimiEntities())
                {

                  adminUserBusiness.Add(new AdminUser
                    {

                        FirstName = txtAdminAd.Text,
                        LastName = txtAdminSoyad.Text,
                        UserName = txtAdminKullaniciAdi.Text,
                        Password = txtAdminSifre.Text

                    });
                    db.SaveChanges();
                    MessageBox.Show("Başarılı Bir şekilde Kayıt Oldu");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void AdminKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
