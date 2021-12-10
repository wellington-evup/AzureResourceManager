using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AzureResourceManager.Core
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public Resource InterfaceResource { get; set; }

        [Required]
        public List<Resource> Resources { get; set; } = new List<Resource>();

        public Product()
        {
        }

        public Product(string name, Resource interfaceResource, params Resource[] resources)
        {
            Name = name;
            InterfaceResource = interfaceResource;
            Resources = resources.ToList();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
