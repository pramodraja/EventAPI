using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAPI.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetEventsAsync();
        Task<TEntity> GetEventAsync(long id);
        void AddEvent(TEntity entity);
        void UpdateEvent(TEntity dbEntity, TEntity entity);
        void DeleteEvent(TEntity entity);
    }
}
