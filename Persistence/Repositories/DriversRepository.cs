using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories;

public class DriversRepository : BaseRepository, IDriversRepository
{
    public DriversRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Driver>> GetAllDrivers(CancellationToken cancellationToken)
    {
        return
            await Context.Drivers
                .Where(x => x.IsActive)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
    }
}