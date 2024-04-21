using Application.Common.Interfaces.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.Drivers.Queries.GetAllDrivers;

public class GetAllDriversQueryHandler : IRequestHandler<GetAllDriversQuery, List<GetAllDriversQueryResponse>>
{
    private IMapper _mapper;
    private IDriversRepository _driversRepository;

    public GetAllDriversQueryHandler(IMapper mapper, IDriversRepository driversRepository)
    {
        _mapper = mapper;
        _driversRepository = driversRepository;
    }

    public async Task<List<GetAllDriversQueryResponse>> Handle(GetAllDriversQuery request, CancellationToken cancellationToken)
    {
        var result = await _driversRepository.GetAllDrivers(cancellationToken);
        var mappedResult = _mapper.Map<List<GetAllDriversQueryResponse>>(result);
        return mappedResult;
    }
}