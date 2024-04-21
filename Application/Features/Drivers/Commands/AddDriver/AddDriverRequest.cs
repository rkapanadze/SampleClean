namespace Application.Features.Drivers.Commands.AddDriver;

public class AddDriverRequest
{
    public string Name { get; set; }
    public int DriverNumber { get; set; }
    public string Comment { get; set; }
}