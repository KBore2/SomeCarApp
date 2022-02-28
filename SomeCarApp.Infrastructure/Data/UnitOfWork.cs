using SomeCarApp.Domain.SeedWork;

namespace SomeCarApp.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarAppContext _dbContext;

        public UnitOfWork(CarAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
