using AzureResourceManager.Core.DataAccess.Interface;
using System;

namespace AzureResourceManager.Core.DataAccess.Repository
{
    public class ResourceInstanceRepository : MemoryRepository<ResourceInstance>
    {
        private readonly IMemoryReadonlyRepository<Resource> _resourceRepository;
        private readonly IMemoryReadonlyRepository<Environment> _environmentRepository;
        private readonly IMemoryReadonlyRepository<Customer> _customerRepository;

        public ResourceInstanceRepository(IMemoryReadonlyRepository<Resource> resourceRepository,
            IMemoryReadonlyRepository<Environment> environmentRepository,
            IMemoryReadonlyRepository<Customer> customerRepository)
        {
            _resourceRepository = resourceRepository;
            _environmentRepository = environmentRepository;
            _customerRepository = customerRepository;

            var cosmos = _resourceRepository.Get(1);
            var rRedis = _resourceRepository.Get(2);
            var cms = _resourceRepository.Get(3);
            var serviceBus = _resourceRepository.Get(4);
            var elos = _resourceRepository.Get(5);

            //var svcEstablishment = _resourceRepository.Get(6);
            //var svcShortlink = _resourceRepository.Get(7);
            //var svcScheduler = _resourceRepository.Get(8);
            //var svcTodoo = _resourceRepository.Get(9);
            //var svcFidelity = _resourceRepository.Get(10);
            //var svcLead = _resourceRepository.Get(11);
            //var lpFN = _resourceRepository.Get(12);
            //var lpUI = _resourceRepository.Get(13);

            var dev = _environmentRepository.Get(1);
            var hml = _environmentRepository.Get(2);
            var prd = _environmentRepository.Get(3);

            var el = _customerRepository.Get(1);
            var bc = _customerRepository.Get(2);
            var tf = _customerRepository.Get(3);
            var el_co = _customerRepository.Get(4);
            var ef = _customerRepository.Get(5);
            var pp = _customerRepository.Get(6);
            var mc = _customerRepository.Get(7);
            var fc = _customerRepository.Get(8);

            var redis = new ResourceInstance(rRedis, null);

            var cosmos_dev = new ResourceInstance(cosmos, null, dev);
            var cms_dev = new ResourceInstance(cms, null, dev);
            var serviceBus_dev = new ResourceInstance(serviceBus, null, dev);

            var elos_dev_el = new ResourceInstance(elos, null, dev, el);
            var elos_dev_bc = new ResourceInstance(elos, null, dev, bc);
            var elos_dev_tf = new ResourceInstance(elos, null, dev, tf);
            var elos_dev_el_co = new ResourceInstance(elos, null, dev, el_co);
            
            var elos_hml_el = new ResourceInstance(elos, null, hml, el);
            var elos_hml_bc = new ResourceInstance(elos, null, hml, bc);
            var elos_hml_tf = new ResourceInstance(elos, null, hml, tf);
            var elos_hml_el_co = new ResourceInstance(elos, null, hml, el_co);
            var elos_hml_ef = new ResourceInstance(elos, null, hml, ef);
            var elos_hml_pp = new ResourceInstance(elos, null, hml, pp);
            var elos_hml_mc = new ResourceInstance(elos, null, hml, mc);
            var elos_hml_fc = new ResourceInstance(elos, null, hml, fc);

            var elos_prd_el = new ResourceInstance(elos, null, prd, el);
            var elos_prd_bc = new ResourceInstance(elos, null, prd, bc);
            var elos_prd_tf = new ResourceInstance(elos, null, prd, tf);
            var elos_prd_el_co = new ResourceInstance(elos, null, prd, el_co);
            var elos_prd_ef = new ResourceInstance(elos, null, prd, ef);
            var elos_prd_pp = new ResourceInstance(elos, null, prd, pp);
            var elos_prd_mc = new ResourceInstance(elos, null, prd, mc);
            var elos_prd_fc = new ResourceInstance(elos, null, prd, fc);

            Insert(redis);
            Insert(cosmos_dev);
            Insert(cms_dev);
            Insert(serviceBus_dev);
            Insert(elos_dev_el);
            Insert(elos_dev_bc);
            Insert(elos_dev_tf);
            Insert(elos_dev_el_co);
            Insert(elos_hml_el);
            Insert(elos_hml_bc);
            Insert(elos_hml_tf);
            Insert(elos_hml_el_co);
            Insert(elos_hml_ef);
            Insert(elos_hml_pp);
            Insert(elos_hml_mc);
            Insert(elos_hml_fc);
            Insert(elos_prd_el);
            Insert(elos_prd_bc);
            Insert(elos_prd_tf);
            Insert(elos_prd_el_co);
            Insert(elos_prd_ef);
            Insert(elos_prd_pp);
            Insert(elos_prd_mc);
            Insert(elos_prd_fc);
        }
    }
}
