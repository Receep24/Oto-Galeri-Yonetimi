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
    public class SatilanArabalarBusiness : IDatabaseBusiness<SatilanArabalar>
    {
        public void Add(SatilanArabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilanArabalars.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(SatilanArabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilanArabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.SatilanArabalars.Find(id);
                db.SatilanArabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(SatilanArabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.SatilanArabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public SatilanArabalar Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilanArabalars.Find(id);
            }
        }

        public SatilanArabalar Get(Expression<Func<SatilanArabalar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilanArabalars.Where(expression).FirstOrDefault();
            }
        }

        public List<SatilanArabalar> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilanArabalars.ToList();
            }
        }

        public List<SatilanArabalar> GetAll(Expression<Func<SatilanArabalar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.SatilanArabalars.Where(expression).ToList();
            }
        }
    }
}
