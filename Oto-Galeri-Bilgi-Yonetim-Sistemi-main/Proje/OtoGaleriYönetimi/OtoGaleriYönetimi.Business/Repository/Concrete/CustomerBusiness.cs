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
    public class CustomerBusiness : IDatabaseBusiness<Customer>
    {
        public void Add(Customer entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Customers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Customer entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Customers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.Customers.Find(id);
                db.Customers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Customer entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Customers.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public Customer Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Customers.Find(id);
            }
        }

        public Customer Get(Expression<Func<Customer, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Customers.Where(expression).FirstOrDefault();
            }
        }

        public List<Customer> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Customers.ToList();
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Customers.Where(expression).ToList();
            }
        }
    }
}
