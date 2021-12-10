using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AzureResourceManager.Core
{
    public class Resource : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public Uri RepositoryUrl { get; set; }

        public List<Resource> Dependencies { get; set; } = new List<Resource>();

        public Resource()
        {
        }

        public Resource(string name)
        {
            Name = name;
        }

        public Resource(string name, Uri repositoryUrl, params Resource[] dependencies) : this(name)
        {
            RepositoryUrl = repositoryUrl;
            Dependencies = dependencies.ToList();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
