using System.ComponentModel.DataAnnotations;

namespace AzureResourceManager.Core
{
    public class Customer : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required, StringLength(4, MinimumLength = 2)]
        public string Code { get; set; }

        public Customer()
        {
        }

        public Customer(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
