using DataStillCase.Entity.Models;
using System.Linq.Expressions;

namespace DataStillCase.Core.Repository
{
    public interface IRepository<TEntity>
    where TEntity : class, IEntity, new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetBy(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> AddEntityAsync(TEntity entity);

        Task<IEnumerable<TEntity>> AddRangeEntityAsync(IEnumerable<TEntity> entities);

        TEntity UpdateEntity(TEntity entity);

        void RemoveEntity(TEntity entity);

        void RemoveRangeEntity(IEnumerable<TEntity> entities);
    }
}
