namespace AzureResourceManager.Core.DataAccess.Repository
{
    public class CustomerRepository : MemoryRepository<Customer>
    {
        public CustomerRepository()
        {
            Insert(new Customer("Espaçolaser", "EL"));
            Insert(new Customer("Belleclub", "BC"));
            Insert(new Customer("Tecfit", "TF"));
            Insert(new Customer("Espaçolaser Colômbia", "EL-CO"));
            Insert(new Customer("Estudioface", "EF"));
            Insert(new Customer("Pronta Pele", "PP"));
            Insert(new Customer("Mais Cabello", "MC"));
            Insert(new Customer("Fill Capilar", "FC"));
        }
    }
}
