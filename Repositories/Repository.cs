using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using OtelRezervasyonDevEx.Entity;

namespace OtelRezervasyonDevEx.Repositories
{
    public class Repository<T> where T:class,new()
    {
        private DbOtelDevExEntities db = new DbOtelDevExEntities();

        public List<T> GelAll()
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetListByID(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().Where(filter).ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>>where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }


    }
}
