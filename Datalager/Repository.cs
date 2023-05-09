using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Datalager
{

    public class Repository<T> //operations only needed for this version of CarPool's use cases implemented
       where T : class
    {
        internal KlädKontext context;
        internal DbSet<T> dbSet;

        public Repository(KlädKontext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }


        public void Add(T entity)
        {
            dbSet.Add(entity);
        }


        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return dbSet.Where(predicate);
        }


        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }

        public T FirstOrDefault(Func<T, bool> predicate, params Expression<Func<T, object>>[] includes)
        {
            var query = dbSet.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.FirstOrDefault(predicate);
        }

        public bool Remove(T entity)
        {
            return table.Remove(entity);
        }

        public bool IsEmpty()
        {
            return table.Count == 0;
        }

        internal Repository()
        {
            if (table == null)
            {
                table = new List<T>();
            }
        }

        private static IList<T> table;

    }
}