using System.Collections.Generic;
using DynamicRepository.Models.Repository;
using DynamicRepository.Models.Repository.Implements;
using DynamicRepository.Models.Repository.Interfaces;

namespace DynamicRepository.Models
{
    public class StudentRepository : Repository<Student>, IStudentRepository 
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Student> FindByname(string name)
        {
            return FindBy(i => i.FirstName.Contains(name));
        }
    }

    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> FindByname(string name);
    }
}