using Application.Common.Interfaces.Repositories;
using Dapper;
using Domain.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Context;

namespace Persistence.Repositories;

public class DriversRepository : BaseRepository, IDriversRepository
{
    private readonly IConfiguration _configuration;

    public DriversRepository(AppDbContext context, IConfiguration configuration) : base(context)
    {
        _configuration = configuration;
    }

    public async Task<List<Driver>> GetAllDrivers(CancellationToken cancellationToken)
    {
        return
            await Context.Drivers
                .Where(x => x.IsActive)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
    }

    public async Task<Driver?> GetDriverById(int id, CancellationToken cancellationToken)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        const string sql = @"select * from drivers where Id = @Id";
        await using var connection = new SqliteConnection(connectionString);
        await connection.OpenAsync(cancellationToken);
        var result = await connection.QueryFirstOrDefaultAsync<Driver>(sql, new { Id = id });
        return result;
    }

    public async Task AddDriver(Driver entity, CancellationToken cancellationToken)
    {
        await Context.Drivers.AddAsync(entity, cancellationToken);
    }
}