
namespace rabbit.library.books.domain.Abstractions;
public class AggregateRoot<Tid> : Entity<Tid>, IAggregateRoot
{
  public readonly List<IDomainEvent> _domainEvents = new();
  public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

  public void AddDomainEvent(IDomainEvent domainEvent)
  {
    _domainEvents.Add(domainEvent);
  }

  public IDomainEvent[] CleanDomainEvents()
  {
    IDomainEvent[] dequeuedEvents = _domainEvents.ToArray();
    _domainEvents.Clear();
    return dequeuedEvents;
  }
}