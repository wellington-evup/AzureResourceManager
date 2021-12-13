using System.ComponentModel.DataAnnotations;

namespace AzureResourceManager.Core
{
    public class Release : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public User Owner { get; private set; }

        public Release()
        {
        }

        public Release(string name, User owner)
        {
            Name = name;
            Owner = owner;
        }

        public override string ToString()
        {
            return Name;
        }

        public void SetOwner(User owner)
        {
            Owner = owner;
        }
    }
}
