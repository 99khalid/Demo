using Demo.Applicatoin.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositres
{
    public class Basereposatry<T> : IUserinterface<T> where T : class
    {
        protected readonly DemoDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public Basereposatry(DemoDbContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<T> AddAsync(T entity)
        {
            ;

            _context.Set<T>().Add(entity);
             _unitOfWork.Commit();
            return entity;
        }
       

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.Entry(entity).State = EntityState.Modified;
            _unitOfWork.Commit();
            return entity;
        }

        public async Task<T> RemoveAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _context.Set<T>().Remove(entity);
            _unitOfWork.Commit();
            return entity;
        }
    }
}
