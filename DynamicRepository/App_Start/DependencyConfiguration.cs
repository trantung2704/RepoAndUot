using DynamicRepository.Models;
using DynamicRepository.Models.Repository;
using DynamicRepository.Models.Repository.Implements;
using DynamicRepository.Models.Repository.Interfaces;
using DynamicRepository.Models.Services.Implements;
using DynamicRepository.Models.Services.Interfaces;
using SimpleInjector;

namespace DynamicRepository
{
    public static class DependencyConfiguration
    {
        public static Container BuildContainer()
        {
            var container = new Container();

            container.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register(typeof(IStudentService), typeof(StudentService));
            container.Register(typeof(IStudentRepository), typeof(StudentRepository));

            //container.Verify();
            return container;
        }
    }
}