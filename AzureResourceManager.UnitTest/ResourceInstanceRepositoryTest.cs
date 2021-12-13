using AzureResourceManager.Core;
using AzureResourceManager.Core.DataAccess.Interface;
using AzureResourceManager.Core.DataAccess.Repository;
using NUnit.Framework;
using System.Linq;

namespace AzureResourceManager.UnitTest
{
    public class ResourceInstanceRepositoryTest
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
            IMemoryReadonlyRepository<Environment> environmentRepository = new EnvironmentRepository();
            IMemoryReadonlyRepository<Customer> customerRepository = new CustomerRepository();
            IMemoryReadonlyRepository<ResourceInstance> resourceInstanceRepository = 
                new ResourceInstanceRepository(resourceRepository, environmentRepository, customerRepository);

            //Act
            var allElosInstances = resourceInstanceRepository.GetAll().Where(x => x.Resource.Id == 5).ToList();
            var allElosDevInstances = resourceInstanceRepository.GetAll().Where(x => x.Resource.Id == 5 && x.Environment != null && x.Environment.Id == 1).ToList();

            //Assert
            Assert.Pass();
        }
    }
}