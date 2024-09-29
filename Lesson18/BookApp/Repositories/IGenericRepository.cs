using System.Linq.Expressions;
using Ex1GenericRepositoryUOW.Entities;
using Ex1RepositoryUOW.Entities;

namespace BookApp.Repositories
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null,
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<TEntity?> FindById(TKey id, params Expression<Func<TEntity,
            object>>[] includeProperties);

        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
