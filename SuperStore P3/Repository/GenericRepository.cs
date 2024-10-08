﻿using Data;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly SuperStoreContext _context;

        public GenericRepository(SuperStoreContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }


        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        void IGenericRepository<T>.AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        
        void IGenericRepository<T>.Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
