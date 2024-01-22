namespace Teste.WebApi.DataContext
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
