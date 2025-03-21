using library.books.application.Data;
using library.books.application.Dtos;
using library.books.application.Features.Authors.EventHandlers.CreateAuthor;
using MassTransit;
using MediatR;
using rabbit.framework.messaging.Events;
using rabbit.library.books.domain.Models;

namespace library.books.application.Features.Authors.EventHandlers.Integration;
public class AuthorCreatedEventHandler(ISender sender)
: IConsumer<AuthorEvent>
{
  public async Task Consume(ConsumeContext<AuthorEvent> context)
  {
    CreateAuthorCommand command = new(context.Message); 
    await sender.Send(command);
  }
}