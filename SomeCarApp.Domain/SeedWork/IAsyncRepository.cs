using System.Linq.Expressions;

namespace SomeCarApp.Domain.SeedWork
{
    public interface IAsyncRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(TEntity entity);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);

        Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression);

        Task<List<TEntity>> ListAsync();
    }
}
