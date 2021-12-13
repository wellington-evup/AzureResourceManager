using AzureResourceManager.Core;
using AzureResourceManager.Core.DataAccess.Interface;
using AzureResourceManager.Core.DataAccess.Repository;
using AzureResourceManager.Core.Extension;
using NUnit.Framework;

namespace AzureResourceManager.UnitTest
{
    public class ProductRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            IMemoryReadonlyRepository<Resource> resourceRepository = new ResourceRepository();
            IMemoryReadonlyRepository<Product> productRepository = new ProductRepository(resourceRepository);

            //Act
            var product = productRepository.Get(2);
            var allResources = product.GetAllResources();

            //Assert
            Assert.Pass();
        }
    }
}