using DynamicRepository.Models.Repository.Interfaces;

namespace DynamicRepository.Models
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T: class
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;           
            StudentRepository = new StudentRepository(context);
        }        

        public IStudentRepository StudentRepository { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    public interface IUnitOfWork<T>
    {
        IStudentRepository StudentRepository { get;}

        void SaveChanges();
    }
}