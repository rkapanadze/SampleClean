using MediatR;

namespace Application.Features.Drivers.Commands.AddDriver;

public record AddDriverCommand(AddDriverRequest request) : IRequest<bool>;