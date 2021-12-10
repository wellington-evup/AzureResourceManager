namespace AzureResourceManager.Core.Interface
{
    public interface ISingleBase<T>
    {
        T Value { get; }

        void SetValue(T value);
    }
}
