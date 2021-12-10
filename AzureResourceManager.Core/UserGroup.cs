using AzureResourceManager.Core.Type;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AzureResourceManager.Core
{
    public class UserGroup : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public Email Email { get; set; }

        [Required]
        public List<User> Users { get; set; } = new List<User>();

        public UserGroup()
        {
        }

        public UserGroup(string name, params User[] users)
        {
            Name = name;
            Users = users.ToList();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
