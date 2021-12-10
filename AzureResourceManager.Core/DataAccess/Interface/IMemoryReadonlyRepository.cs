using AzureResourceManager.Core.Interface;

namespace AzureResourceManager.Core.DataAccess.Interface
{
    public interface IMemoryReadonlyRepository<X> : IReadonlyRepository<X, int> where X : BaseEntity
    {
    }
}
