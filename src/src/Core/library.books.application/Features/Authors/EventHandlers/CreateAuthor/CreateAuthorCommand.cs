using library.books.application.Dtos;
using rabbit.framework.CQRS;
using rabbit.framework.messaging.Events;

namespace library.books.application.Features.Authors.EventHandlers.CreateAuthor;
public record CreateAuthorCommand(AuthorEvent AuthorEvent)
: ICommand<bool>;