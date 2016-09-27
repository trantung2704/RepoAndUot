using System.Collections.Generic;
using System.Linq.Expressions;

namespace DynamicRepository.Models.Services.Interfaces
{
    public interface IEntityService<T> where T: class 
    {
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        IEnumerable<T> FindBy(Expression<System.Func<T, bool>> predicate);

        IEnumerable<T> GetAll();

        void SaveChanges();
    }
}