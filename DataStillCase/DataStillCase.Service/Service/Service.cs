using DataStillCase.Core.Repository;
using DataStillCase.Core.Service;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Entity.Models;
using System.Linq.Expressions;

namespace DataStillCase.Service.Service
{
    public class Service<TEntity> : IService<TEntity>
        where TEntity : class, IEntity, new()
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;

        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetBy(Expression<Func<TEntity, bool>> filter)
        {
            return await _repository.GetBy(filter);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _repository.SingleOrDefaultAsync(filter);
        }

        public async Task<TEntity> AddEntityAsync(TEntity entity)
        {
            await _repository.AddEntityAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeEntityAsync(IEnumerable<TEntity> entities)
        {
            var addRangeEntityAsync = entities as TEntity[] ?? entities.ToArray();
            await _repository.AddRangeEntityAsync(addRangeEntityAsync);
            await _unitOfWork.CommitAsync();
            return addRangeEntityAsync;
        }

        public TEntity UpdateEntity(TEntity entity)
        {
            _repository.UpdateEntity(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public void RemoveEntity(TEntity entity)
        {
            _repository.RemoveEntity(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRangeEntity(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRangeEntity(entities);
            _unitOfWork.Commit();
        }
    }
}
