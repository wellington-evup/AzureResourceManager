namespace AzureResourceManager.Core.Exceptions
{
    public class BusyResourceInstanceException : BusinessRuleException
    {
        public BusyResourceInstanceException()
        {
        }

        public BusyResourceInstanceException(string message) : base(message)
        {
        }
    }
}
