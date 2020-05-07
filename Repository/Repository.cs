using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MyCollection
{
    public class Repository<T> : IDisposable where T : class
    {
        protected CollectionContext _context;
        protected DbSet<T> _dbSet;
        public Repository(CollectionContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }


    }
}