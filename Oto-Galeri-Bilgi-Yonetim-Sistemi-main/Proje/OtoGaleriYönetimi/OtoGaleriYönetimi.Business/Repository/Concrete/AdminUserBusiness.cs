using OtoGaleriYönetimi.Business.Repository.Abstract;
using OtoGaleriYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriYönetimi.Business.Repository.Concrete
{
    public class AdminUserBusiness : IDatabaseBusiness<AdminUser>
    {
        public void Add(AdminUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.AdminUsers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(AdminUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.AdminUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.AdminUsers.Find(id);
                db.AdminUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(AdminUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.AdminUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public AdminUser Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.AdminUsers.Find(id);
            }
        }

        public AdminUser Get(Expression<Func<AdminUser, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.AdminUsers.Where(expression).FirstOrDefault();
            }
        }

        public List<AdminUser> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.AdminUsers.ToList();
            }
        }

        public List<AdminUser> GetAll(Expression<Func<AdminUser, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.AdminUsers.Where(expression).ToList();
            }
        }
    }
}
