using System.Collections.Generic;
using DynamicRepository.Models.Services.Interfaces;

namespace DynamicRepository.Models.Services.Implements
{
    public class  StudentService : EntityService<Student>, IStudentService
    {
        private readonly IUnitOfWork<Student> _unitOfWork;

        public StudentService(IUnitOfWork<Student> unitOfWork) : base(unitOfWork, unitOfWork.StudentRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Student> FindByName(string name)
        {
            return _unitOfWork.StudentRepository.FindByname(name);
        }
    }
}