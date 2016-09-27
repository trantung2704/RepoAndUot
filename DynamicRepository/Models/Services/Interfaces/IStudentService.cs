using System.Collections.Generic;

namespace DynamicRepository.Models.Services.Interfaces
{
    public interface IStudentService : IEntityService<Student> 
    {
        IEnumerable<Student> FindByName(string name);
    }
}