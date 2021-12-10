using AzureResourceManager.Core.DataAccess.Interface;

namespace AzureResourceManager.Core.DataAccess.Repository
{
    public class ProductRepository : MemoryRepository<Product>
    {
        private readonly IMemoryReadonlyRepository<Resource> _resourceRepository; 

        public ProductRepository(IMemoryReadonlyRepository<Resource> resourceRepository)
        {
            _resourceRepository = resourceRepository;

            var elos = _resourceRepository.Get(5);

            var lpFN = _resourceRepository.Get(12);
            var lpUI = _resourceRepository.Get(13);

            var pElos = new Product("Elos", elos);
            var pLP = new Product("Landing Page", lpUI, lpFN);

            Insert(pElos);
            Insert(pLP);
        }
    }
}
