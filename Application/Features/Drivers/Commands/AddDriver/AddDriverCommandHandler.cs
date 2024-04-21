using System.Diagnostics.CodeAnalysis;
using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Drivers.Commands.AddDriver;

public class AddDriverCommandHandler : IRequestHandler<AddDriverCommand, bool>
{
    private IDriversRepository _driversRepository;
    private IUnitOfWork _unitOfWork;

    public AddDriverCommandHandler(IDriversRepository driversRepository, IUnitOfWork unitOfWork)
    {
        _driversRepository = driversRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(AddDriverCommand request, CancellationToken cancellationToken)
    {
        var entity = new Driver()
        {
            Name = request.request.Name,
            Comment = request.request.Comment,
            DriverNumber = request.request.DriverNumber,
            IsActive = true
        };
        await _driversRepository.AddDriver(entity, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}