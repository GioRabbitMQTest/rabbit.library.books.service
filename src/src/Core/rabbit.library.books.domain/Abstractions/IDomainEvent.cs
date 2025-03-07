using MediatR;

namespace rabbit.library.books.domain.Abstractions;
public interface IDomainEvent : INotification
{
  Guid EventId => Guid.NewGuid();
  public DateTime OcurredOn => DateTime.Now;
  public string EventType => GetType().AssemblyQualifiedName;
}