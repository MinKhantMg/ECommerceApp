
namespace Domain.Abstraction;

internal class GuidBaseEntity: BaseEntity<string>
{
    public GuidBaseEntity() : base()
    {
        Id = Guid.NewGuid().ToString().ToUpper();
    }
}
