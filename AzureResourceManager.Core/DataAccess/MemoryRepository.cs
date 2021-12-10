using AzureResourceManager.Core.DataAccess.Interface;
using System.Linq;

namespace AzureResourceManager.Core.DataAccess
{
    public abstract class MemoryRepository<T> : MemoryReadonlyRepository<T>, IMemoryRepository<T> where T : BaseEntity
    {
        public void Insert(T entity)
        {
            var nextId = _table.Any() ? _table.Max(x => x.Id) + 1 : 1;
            entity.Id = nextId;
            _table.Add(entity);
        }

        public void Update(T entity)
        {
            var index = _table.FindIndex(x => x.Id == entity.Id);
            _table[index] = entity;
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            _table.Remove(entity);
        }
    }
}
