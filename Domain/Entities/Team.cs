using Domain.Primitives;

namespace Domain.Entities;

public class Team : IAuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Comment { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastModifiedAt { get; set; }
}