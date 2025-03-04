
namespace Domain.Abstraction;

internal interface IEntity<TId>
{
    TId Id { get; set; }
}
