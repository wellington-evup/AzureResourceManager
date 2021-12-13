using AzureResourceManager.Core.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace AzureResourceManager.Core
{
    public class ResourceInstance : BaseEntity
    {
        [Required]
        public Resource Resource { get; set; }
        
        [Required]
        public Uri Url { get; set; }

        public Environment Environment { get; set; }

        public Customer Customer { get; set; }

        public Release Release { get; set; }

        public string Name { get { return string.Format("{0} {1} {2}", Resource.Name, Environment?.Name, Customer?.Name); } }

        public ResourceInstance()
        {
        }

        public ResourceInstance(Resource resource, Uri url)
        {
            Resource = resource;
            Url = url;
        }

        public ResourceInstance(Resource resource, Uri url, Environment environment) : this(resource, url)
        {
            Environment = environment;
        }

        public ResourceInstance(Resource resource, Uri url, Customer customer) : this(resource, url)
        {
            Customer = customer;
        }

        public ResourceInstance(Resource resource, Uri url, Environment environment, Customer customer) : this(resource, url)
        {
            Environment = environment;
            Customer = customer;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SetRelease(Release release)
        {
            if (Release != null && release != null)
            {
                throw new BusyResourceInstanceException($"Resource instance '{Name}' is busy. Send a message for {Release.Owner.Name} to set it free.");
            }
            Release = release;
        }
    }
}
