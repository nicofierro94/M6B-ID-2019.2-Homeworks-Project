using System;
using Microsoft.EntityFrameworkCore;
using Homeworks.Domain;
using Homeworks.DataAccess.Interface;
using System.Collections.Generic;

namespace Homeworks.DataAccess
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected DbContext Context { get; set; }
        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }
        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public abstract IEnumerable<T> GetAll();
        public abstract T Get(Guid id);
        public void save()
        {
            Context.SaveChanges();
        }
    }
}
