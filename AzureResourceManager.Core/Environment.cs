using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AzureResourceManager.Core
{
    public class Environment : BaseEntity
    {
        [Required, StringLength(3, MinimumLength = 3)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        public Environment()
        {
        }

        public Environment(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
