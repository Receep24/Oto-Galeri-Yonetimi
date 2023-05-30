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
    public class SatilikAraclarBusiness : IDatabaseBusiness<SatilikAraclar>
    {
        public void Add(SatilikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilikAraclars.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(SatilikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.SatilikAraclars.Find(id);
                db.SatilikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(SatilikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public SatilikAraclar Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilikAraclars.Find(id);
            }
        }

        public SatilikAraclar Get(Expression<Func<SatilikAraclar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilikAraclars.Where(expression).FirstOrDefault();
            }
        }

        public List<SatilikAraclar> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilikAraclars.ToList();
            }
        }

        public List<SatilikAraclar> GetAll(Expression<Func<SatilikAraclar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilikAraclars.Where(expression).ToList();
            }
        }
    }
}
