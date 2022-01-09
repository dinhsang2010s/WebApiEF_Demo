using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPIDemo.Interfaces
{
    public interface IRepository<TEntity> 
        where TEntity: class, IEntity
    {
        Task<IEnumerable<TEntity>> GetListAsync(string filter);
        Task<TEntity> GetAsync(Guid entityId);
        Task InsertAsync(TEntity entity);
        Task DeleteAsync(Guid entityId);
        Task UpdateAsync(TEntity entity);
        Task SaveAsync();
    }
}
