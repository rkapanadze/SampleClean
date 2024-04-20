using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Persistence.Interceptors;

public sealed class UpdateAuditableEntitiesInterceptor : SaveChangesInterceptor
{
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = new CancellationToken())
    {
        var dbContext = eventData.Context;
        if (dbContext is null)
        {
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        var entries = dbContext.ChangeTracker.Entries<IAuditableEntity>();
        foreach (var entityEntry in entries)
        {
            switch (entityEntry.State)
            {
                case EntityState.Added:
                    entityEntry.Property(a => a.CreatedAt).CurrentValue = DateTime.UtcNow.AddHours(4);
                    entityEntry.Property(a => a.IsActive).CurrentValue = true;
                    break;
                case EntityState.Modified:
                    entityEntry.Property(a => a.LastModifiedAt).CurrentValue = DateTime.UtcNow.AddHours(4);
                    break;
            }
        }

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}