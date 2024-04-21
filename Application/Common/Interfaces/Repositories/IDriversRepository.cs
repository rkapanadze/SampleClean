using Domain.Entities;

namespace Application.Common.Interfaces.Repositories;

public interface IDriversRepository
{
    Task<List<Driver>> GetAllDrivers(CancellationToken cancellationToken);
    Task AddDriver(Driver entity, CancellationToken cancellationToken);
    Task<Driver?> GetDriverById(int id, CancellationToken cancellationToken);
}