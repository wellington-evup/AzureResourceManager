using AzureResourceManager.Core.Interface;

namespace AzureResourceManager.Core.DataAccess.Interface
{
    public interface IMemoryRepository<X> : IRepository<X, int> where X : BaseEntity
    {
    }
}
