using System;
using System.Collections.Generic;
using System.Text;

namespace AzureResourceManager.Core.Interface
{
    public interface IReadonlyRepository<X, Y> : IDisposable
    {
        X Get(Y id);
        IEnumerable<X> GetAll();
    }
}
