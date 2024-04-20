using Application.Common.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Persistence.Context;

namespace Persistence.Repositories;

public sealed class UnitOfWork : BaseRepository, IUnitOfWork
{
    private IDbContextTransaction _transaction;

    public UnitOfWork(AppDbContext context) : base(context)
    {
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await Context.SaveChangesAsync(cancellationToken);
    }


    public async Task BeginTransactionAsync()
    {
        _transaction = await Context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if (_transaction != null)
        {
            await _transaction.CommitAsync();
        }
    }

    public async Task RollbackTransactionAsync()
    {
        if (_transaction != null)
        {
            await _transaction.RollbackAsync();
        }
    }

    public void Dispose()
    {
        if (_transaction != null)
        {
            _transaction.Dispose();
        }
    }
}