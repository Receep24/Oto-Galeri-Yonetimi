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
    public class CustomerUserBusiness : IDatabaseBusiness<CustomerUser>
    {
        public void Add(CustomerUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.CustomerUsers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(CustomerUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.CustomerUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.CustomerUsers.Find(id);
                db.CustomerUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(CustomerUser entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.CustomerUsers.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public CustomerUser Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.CustomerUsers.Find(id);
            }
        }

        public CustomerUser Get(Expression<Func<CustomerUser, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.CustomerUsers.Where(expression).FirstOrDefault();
            }
        }

        public List<CustomerUser> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.CustomerUsers.ToList();
            }
        }

        public List<CustomerUser> GetAll(Expression<Func<CustomerUser, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.CustomerUsers.Where(expression).ToList();
            }
        }
    }
}
