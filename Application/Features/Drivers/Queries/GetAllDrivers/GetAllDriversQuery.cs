using Domain.Entities;
using MediatR;

namespace Application.Features.Drivers.Queries.GetAllDrivers;

public record GetAllDriversQuery() : IRequest<List<GetAllDriversQueryResponse>>;
