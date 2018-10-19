using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Cars.Data
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
		protected readonly DbContext context;
        protected readonly DbSet<TEntity> dbSet;

        public Repository(DbContext context)
        {
            this.context = context ?? throw new ArgumentException(nameof(context)); ;
            this.dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> RetrieveAll()
        {
            return this.dbSet.AsQueryable();
        }

        public TEntity FindById(long id)
        {
            return this.dbSet.Find(id);
        }

        public TEntity Create(TEntity entity)
        {
            this.dbSet.Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            this.dbSet.RemoveRange(entities);
        }
    }
}
