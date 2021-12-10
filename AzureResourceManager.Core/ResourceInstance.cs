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

        public User Owner { get; private set; }

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

        public void SetOwner(User owner)
        {
            Owner = owner;
        }
    }
}
