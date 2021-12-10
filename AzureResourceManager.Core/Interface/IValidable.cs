namespace AzureResourceManager.Core.Interface
{
    public interface IValidable<T>
    {
        void Validate(T value);
    }
}
