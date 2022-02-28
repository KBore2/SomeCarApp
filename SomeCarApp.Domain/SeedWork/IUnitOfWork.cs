namespace SomeCarApp.Domain.SeedWork
{

    public interface IUnitOfWork
    {
        Task CommitAsync();
    }


}


