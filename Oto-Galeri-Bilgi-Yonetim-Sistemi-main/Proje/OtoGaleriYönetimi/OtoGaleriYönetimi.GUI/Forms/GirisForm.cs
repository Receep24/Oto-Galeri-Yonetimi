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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
       

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            using (var db = new  OtoGaleriYönetimiEntities())
            {
                var user = db.AdminUsers.Where(u => u.UserName == txtAdminKullanıcı.Text && u.Password == txtAdminSifre.Text).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Giriş Başarılı. Admin Menüsüne Yönlendiriliyorsunuz");
                    AdminMenü adminMenü = new AdminMenü();
                    this.Hide();
                    adminMenü.Show();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }

            }
            }

        private void btnAdminKayıt_Click(object sender, EventArgs e)
        {
            AdminKayıt adminKayıt = new AdminKayıt();
            adminKayıt.Show();
        }

        private void btnCusGiris_Click(object sender, EventArgs e)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var user = db.CustomerUsers.Where(u => u.UserName == txtCusKullanıcı.Text && u.Password == txtCusSifre.Text).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Giriş Başarılı. Müşteri Menüsüne Yönlendiriliyorsunuz");
                    MusteriMenü musteriMenü = new MusteriMenü();
                    this.Hide();
                    musteriMenü.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }
            }
        }

        private void btnCusKayıt_Click(object sender, EventArgs e)
        {
            MusteriKayıt musteriKayıt = new MusteriKayıt();
            musteriKayıt.Show();
        }
    }
    }

