using AngularProjesiCommon.Data_Contracts;
using AngularProjesiData.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularProjesiData.Implementation
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {

        private readonly AngularProjesiDbContext _db;
        internal DbSet<T> dbSet; //DbSet:Herhangi bir veritabanındaki tablonun kodlama tarafındaki entity Framework ten tanımlanacağı ifade 

        public Repository(AngularProjesiDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> Include<T1>(System.Linq.Expressions.Expression<Func<T, T1>> selector)
        {
            IQueryable<T> query = dbSet;
            return query;
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
