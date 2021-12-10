namespace AzureResourceManager.Core.DataAccess.Repository
{
    public class EnvironmentRepository : MemoryRepository<Environment>
    {
        public EnvironmentRepository()
        {
            Insert(new Environment("DEV"));
            Insert(new Environment("HML"));
            Insert(new Environment("PRD"));
        }
    }
}
