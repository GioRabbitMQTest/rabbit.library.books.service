namespace rabbit.library.books.domain.Abstractions;
public interface IAggregateRoot<T> : IAggregateRoot
{
}

public interface IAggregateRoot
{
  IReadOnlyList<IDomainEvent> DomainEvents { get; }
  IDomainEvent[] CleanDomainEvents();
}