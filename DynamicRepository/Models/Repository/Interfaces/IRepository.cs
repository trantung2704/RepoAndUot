using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DynamicRepository.Models.Repository.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        T Add(T entity);

        void Update(T entity);

        T Remove(T entity);

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAll();
    }
}