using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Datalager.IRepository;

namespace Datalager.Repository
{

    public class Repository<T> : IRepository<T> where T : class , new()
    {
        internal KlädKontext context;
        internal DbSet<T> dbSet;

        public Repository(KlädKontext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        // Create Read Update Delete (CRUD)

        // Create
        public virtual T Add(T entity) { dbSet.Add(entity); return entity; }
        public virtual IEnumerable<T> AddRange(IEnumerable<T> entities) { dbSet.AddRange(entities); return entities; }

        // Read
        public virtual T Find(int id) => dbSet.Find(id);
        public virtual T FirstOrDefault(Func<T, bool> predicate) => dbSet.FirstOrDefault(predicate);
        public virtual IEnumerable<T> Find(Func<T, bool> predicate) => dbSet.Where(predicate);
        public virtual IEnumerable<T> GetAll() => dbSet;
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null!,
                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null!,
                                          params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = dbSet;
            foreach (var include in includes) { query = query.Include(include); }
            query = filter != null ? query.Where(filter) : query;
            query = orderBy != null ? orderBy(query) : query;
            return query.ToList();
        }

        public virtual IEnumerable<T> Query(Func<IQueryable<T>, IQueryable<T>> query) => query(dbSet);

        // Update
        public virtual void Update(T entity) => dbSet.Update(entity);
        public virtual T Update(T oldEntity, T newEntity)
        {
            context.Entry(oldEntity).CurrentValues.SetValues(newEntity);
            dbSet.Update(oldEntity);
            return oldEntity;
        }
        public virtual void UpdateRange(IEnumerable<T> entities) => dbSet.UpdateRange(entities);

        // Delete
        public virtual void Delete(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
                context.Entry(entity).State = EntityState.Deleted;
        }
        public virtual T Delete(T entity) { dbSet.Remove(entity); return entity; }
        public virtual void DeleteRange(IEnumerable<T> entities) => dbSet.RemoveRange(entities);

    }
}