using System.ComponentModel.DataAnnotations;

namespace AzureResourceManager.Core
{
    public class Release : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public Release()
        {
        }

        public Release(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
