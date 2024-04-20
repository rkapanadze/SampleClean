namespace Domain.Primitives;

public interface IAuditableEntity
{
    bool IsActive { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime LastModifiedAt { get; set; }
}