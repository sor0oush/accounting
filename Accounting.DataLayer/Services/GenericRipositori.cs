using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
   public class GenericRipositori<TEntiti> where TEntiti : class
    {
        private Accounting_DBEntities _db;
        private DbSet<TEntiti> _dbSet;
        public GenericRipositori(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntiti>();
        }
        public virtual IEnumerable<TEntiti> Get(Expression<Func<TEntiti, bool>> where = null)
        {
            IQueryable<TEntiti> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }
        public virtual TEntiti GetById(object Id)
        {
            return _dbSet.Find(Id);
        }


        public virtual void Insert(TEntiti entity)
        {
            _dbSet.Add(entity);
        }


        public virtual void Update(TEntiti entity)
        {
            //if (_db.Entry(entity).State == EntityState.Detached)
            //{
            //    _dbSet.Attach(entity);
            //}
       
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntiti entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
    public class test
    {

    }
}
