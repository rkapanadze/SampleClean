using Domain.Entities;

namespace Application.Common.Interfaces.Repositories;

public interface IDriversRepository
{
    Task<List<Driver>> GetAllDrivers(CancellationToken cancellationToken);
}