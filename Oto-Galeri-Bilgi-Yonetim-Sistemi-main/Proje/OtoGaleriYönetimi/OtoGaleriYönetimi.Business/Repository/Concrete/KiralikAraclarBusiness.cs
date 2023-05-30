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
    public class KiralikAraclarBusiness : IDatabaseBusiness<KiralikAraclar>
    {
        public void Add(KiralikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralikAraclars.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(KiralikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.KiralikAraclars.Find(id);
                db.KiralikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(KiralikAraclar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralikAraclars.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public KiralikAraclar Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralikAraclars.Find(id);
            }
        }

        public KiralikAraclar Get(Expression<Func<KiralikAraclar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralikAraclars.Where(expression).FirstOrDefault();
            }
        }

        public List<KiralikAraclar> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralikAraclars.ToList();
            }
        }

        public List<KiralikAraclar> GetAll(Expression<Func<KiralikAraclar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralikAraclars.Where(expression).ToList();
            }
        }
    }
}
