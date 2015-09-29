using BackendGeneral.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AngularEducationBackend
{
    class AngularEducationDbSet<T> : ITable<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public AngularEducationDbSet(DbContext dbContext, DbSet<T> dbSet)
        {
            _dbSet = dbSet;
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        //TODO: Huh?
        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
