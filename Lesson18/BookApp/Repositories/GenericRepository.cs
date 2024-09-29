using System.Linq.Expressions;
using Ex1GenericRepositoryUOW.Entities;
using Ex1RepositoryUOW.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> items = _context.Set<TEntity>();
            if (includeProperties != null)
            {
                foreach (var property in includeProperties)
                {
                    items = items.Include(property);
                }
            }

            if (predicate != null)
            {
                items = items.Where(predicate);
            }

            return items;
        }

        public async Task<TEntity?> FindById(TKey id, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var item = await FindAll(null, includeProperties).FirstOrDefaultAsync(s => s.Id.Equals(id));
            return item;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
