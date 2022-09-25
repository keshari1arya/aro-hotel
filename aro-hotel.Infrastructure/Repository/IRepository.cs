using System;
using System.Linq.Expressions;
using aro_hotel.Domain.Model;

namespace aro_hotel.Infrastructure.Repository
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> FindAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task Add(T entity);
        Task SaveChangesAsync();
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);
    }
}

