namespace AzureResourceManager.Core.Interface
{
    public interface ITranslator<X, Y>
    {
        Y Translate(X value);
        X Translate(Y value);
    }
}
