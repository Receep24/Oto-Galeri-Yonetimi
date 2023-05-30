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
    public class ArabalarBusiness : IDatabaseBusiness<Arabalar>
    {
        public void Add(Arabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Arabalars.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Arabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Arabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                var entity = db.Arabalars.Find(id);
                db.Arabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Arabalar entity)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                db.Arabalars.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public Arabalar Get(int id)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Arabalars.Find(id);
            }
        }

        public Arabalar Get(Expression<Func<Arabalar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Arabalars.Where(expression).FirstOrDefault();
            }
        }

        public List<Arabalar> GetAll()
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Arabalars.ToList();
            }
        }

        public List<Arabalar> GetAll(Expression<Func<Arabalar, bool>> expression)
        {
            using (var db = new OtoGaleriYönetimiEntities())
            {
                return db.Arabalars.Where(expression).ToList();
            }
        }
    }
}
