using Application.Features.Drivers.Queries.GetAllDrivers;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings;

public class DriversMapping : Profile
{
    public DriversMapping()
    {
        CreateMap<Driver, GetAllDriversQueryResponse>().ReverseMap();
    }
}