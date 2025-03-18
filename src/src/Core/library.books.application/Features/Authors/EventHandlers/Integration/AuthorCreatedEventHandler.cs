using MassTransit;
using rabbit.framework.messaging.Events;

namespace library.books.application.Features.Authors.EventHandlers.Integration;
public class AuthorCreatedEventHandler()
: IConsumer<AuthorEvent>
{
  public async Task Consume(ConsumeContext<AuthorEvent> context)
  {
    var message = context.Message;
  }
}