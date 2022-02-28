using Microsoft.EntityFrameworkCore;
using SomeCarApp.Domain.SeedWork;
using System.Linq.Expressions;

namespace SomeCarApp.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IAsyncRepository<TEntity> where TEntity : BaseEntity
    { 

        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(CarAppContext dbContext)
        {
            _dbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            return await Task.FromResult(true);
        }


        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }


        public async Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            return await Task.FromResult(entity);
        }
    }
}
