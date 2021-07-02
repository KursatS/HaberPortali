using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali_H5190062
{
    public class GenericRepository<C> where C : class, new()
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();

        public List<C> List()
        {
            return db.Set<C>().ToList();
        }

        public C GetById(int id)
        {
            return db.Set<C>().Find(id);
        }

        public void Add(C p)
        {
            db.Set<C>().Add(p);
            db.SaveChanges();
        }

        public void Delete(C p)
        {
            db.Set<C>().Remove(p);
            db.SaveChanges();
        }

        public void Update(C p)
        {
            db.SaveChanges();
        }

        public C Find(Expression<Func<C, bool>> kosul)
        {
            return db.Set<C>().FirstOrDefault(kosul);
        }
    }
}
