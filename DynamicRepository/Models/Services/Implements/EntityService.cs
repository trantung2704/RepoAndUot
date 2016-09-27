using System.Collections.Generic;
using System.Linq.Expressions;
using DynamicRepository.Models.Repository.Interfaces;
using DynamicRepository.Models.Services.Interfaces;

namespace DynamicRepository.Models.Services.Implements
{
    public abstract class EntityService<T> : IEntityService<T> where T: class
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork<T> _unitOfWork;

        public EntityService(IUnitOfWork<T> unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;           
        }

        public virtual void Add(T entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _repository.Update(entity);
        }

        public virtual void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<T> FindBy(Expression<System.Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();          
        }
    }
}