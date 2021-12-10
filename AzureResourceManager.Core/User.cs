using AzureResourceManager.Core.Type;
using System.ComponentModel.DataAnnotations;

namespace AzureResourceManager.Core
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Email Email { get; set; }

        public User()
        {
        }

        public User(string name, Email email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
