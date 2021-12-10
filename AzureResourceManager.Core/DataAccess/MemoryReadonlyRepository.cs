using AzureResourceManager.Core.DataAccess.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AzureResourceManager.Core.DataAccess
{
    public abstract class MemoryReadonlyRepository<T> : IMemoryReadonlyRepository<T> where T : BaseEntity
    {
        protected List<T> _table { get; set; } = new List<T>();

        public virtual T Get(int id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _table;
        }

        public virtual void Dispose()
        {
            
        }
    }
}
