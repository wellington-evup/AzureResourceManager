using System;

namespace AzureResourceManager.Core.DataAccess.Repository
{
    public class ResourceRepository : MemoryRepository<Resource>
    {
        public ResourceRepository()
        {
            var cosmos = new Resource("Cosmos DB");
            var redis = new Resource("Redis");
            var cms = new Resource("CMS");
            var serviceBus = new Resource("Service Bus");
            var elos = new Resource("ELOS", new Uri("https://dev.azure.com/evuptec/VOE.IT%20-%20Espaco%20Laser/_git/EVUP%20-%20ELOS"), 
                redis, cosmos, cms, serviceBus);

            var svcEstablishment = new Resource("SVC-ESTABLISHMENT", null,
                cms, redis);
            var svcShortlink = new Resource("SVC-SHORTLINK", null,
                cms);
            var svcScheduler = new Resource("SVC-SCHEDULER", null,
                cms, svcShortlink, svcEstablishment, elos);
            var svcTodoo = new Resource("SVC-TODOO", null,
                svcEstablishment);
            var svcFidelity = new Resource("SVC-FIDELITY", null);
            var svcLead = new Resource("SVC-LEAD", null,
                cms, svcShortlink, svcEstablishment, svcFidelity, svcTodoo);
            var lpFN = new Resource("LEADPAGE FN", null,
                serviceBus, svcEstablishment, svcShortlink, svcScheduler, svcLead);
            var lpUI = new Resource("LEADPAGE UI", null,
                cms, lpFN);

            var svcCustomer = new Resource("SVC-CUSTOMER", null); 
            var ecmFN = new Resource("ECM FN", null,
                serviceBus, svcEstablishment, svcScheduler, svcCustomer);
            var ecmUI = new Resource("ECM UI", null,
                cms, ecmFN, svcCustomer);

            Insert(cosmos);
            Insert(redis);
            Insert(cms);
            Insert(serviceBus);
            Insert(elos);
            Insert(svcEstablishment);
            Insert(svcShortlink);
            Insert(svcScheduler);
            Insert(svcTodoo);
            Insert(svcFidelity);
            Insert(svcLead);
            Insert(lpFN);
            Insert(lpUI);
            Insert(svcCustomer);
            Insert(ecmFN);
            Insert(ecmUI);
        }
    }
}
