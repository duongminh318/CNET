using Ex1RepositoryUOW.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookApp.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _transaction;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateTransaction()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            if (_transaction == null)
            {
                throw new Exception("");
            }
            await _transaction.CommitAsync();
        }

        public async Task Rollback()
        {
            if (_transaction == null)
            {
                throw new Exception("");
            }
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }

    }
}
