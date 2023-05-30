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
    public class KiralanmisArabaBusiness : IDatabaseBusiness<KiralanmisAraba>
    {
        public void Add(KiralanmisAraba entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralanmisArabas.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(KiralanmisAraba entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralanmisArabas.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.KiralanmisArabas.Find(id);
                db.KiralanmisArabas.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(KiralanmisAraba entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.KiralanmisArabas.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public KiralanmisAraba Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralanmisArabas.Find(id);
            }
        }

        public KiralanmisAraba Get(Expression<Func<KiralanmisAraba, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralanmisArabas.Where(expression).FirstOrDefault();
            }
        }

        public List<KiralanmisAraba> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralanmisArabas.ToList();
            }
        }

        public List<KiralanmisAraba> GetAll(Expression<Func<KiralanmisAraba, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.KiralanmisArabas.Where(expression).ToList();
            }
        }
    }
}
