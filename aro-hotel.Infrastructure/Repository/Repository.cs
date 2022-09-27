using System.Linq.Expressions;
using aro_hotel.Domain.Context;
using aro_hotel.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace aro_hotel.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        internal readonly HotelContext _context;
        public readonly DbSet<T> _entities;

        public Repository(HotelContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = context.Set<T>();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> expression) => await _entities.FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> expression) => await _entities.Where(expression).ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync() => await _entities.ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _entities.SingleOrDefaultAsync(s => s.Id == id);

        public async Task Add(T entity) => await _entities.AddAsync(entity);

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate) => await _context.Set<T>().FirstOrDefaultAsync(predicate);

        public DbSet<T> Entity()
        {
            return _entities;
        }
    }
}

