using System.Collections.Generic;
using System.Linq;

namespace AzureResourceManager.Core.Extension
{
    public static class ProductExtension
    {
        public static List<Resource> GetAllResources(this Product product)
        {
            var ret = new List<Resource>();
            var primaryDependencies = product.Resources.Append(product.InterfaceResource).ToList();
            foreach (var item in primaryDependencies)
            {
                ret.AddRange(GetAllResources(item));
                ret.Add(item);
            }
            return ret.Distinct().ToList();
        }

        private static List<Resource> GetAllResources(this Resource resource)
        {
            var ret = new List<Resource>();
            foreach (var item in resource.Dependencies)
            {
                ret.AddRange(GetAllResources(item));
                ret.Add(item);
            }
            return ret;
        }
    }
}
