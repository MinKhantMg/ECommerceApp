
namespace Domain.Abstraction;

public interface ISoftDelete
{
    DateTime? DeletedOn { get; set; }
    string? DeletedBy { get; set; }
    bool? IsDeleted { get; set; }
}
