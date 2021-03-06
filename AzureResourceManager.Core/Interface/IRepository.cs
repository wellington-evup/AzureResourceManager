namespace AzureResourceManager.Core.Interface
{
    public interface IRepository<X, Y> : IReadonlyRepository<X, Y>
    {
        void Insert(X model);
        void Update(X model);
        void Delete(Y id);
    }
}
