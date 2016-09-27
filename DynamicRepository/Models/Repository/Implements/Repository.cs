using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using DynamicRepository.Models.Repository.Interfaces;

namespace DynamicRepository.Models.Repository.Implements
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected ApplicationDbContext Entities;
        protected readonly IDbSet<T> Dbset;

        public Repository(ApplicationDbContext context)
        {
            Entities = context;
            Dbset = context.Set<T>();
        }     

        public virtual T Add(T entity)
        {
            return Dbset.Add(entity);            
        }

        public virtual void Update(T entity)
        {
            Dbset.AddOrUpdate(entity);
        }

        public virtual T Remove(T entity)
        {
            return Dbset.Remove(entity);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return Dbset.Where(predicate)
                        .AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return Dbset.AsEnumerable();
        }
    }
}