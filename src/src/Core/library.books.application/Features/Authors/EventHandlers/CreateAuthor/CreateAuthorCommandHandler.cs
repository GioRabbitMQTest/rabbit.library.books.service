using library.books.application.Data;
using library.books.application.Dtos;
using rabbit.framework.CQRS;
using rabbit.framework.messaging.Events;
using rabbit.library.books.domain.Models;
using rabbit.library.books.domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.books.application.Features.Authors.EventHandlers.CreateAuthor;
public class CreateAuthorCommandHandler(IAppDbContext appDbContext)
: ICommandHandler<CreateAuthorCommand, bool>
{
  public async Task<bool> Handle(CreateAuthorCommand command, CancellationToken cancellationToken)
  {
    var author = CreateNewAuthor(command.AuthorEvent);
    appDbContext.Authors.Add(author);
    await appDbContext.SaveChangesAsync(cancellationToken);
    return true;
  }

  private Author CreateNewAuthor(AuthorEvent author)
  {
    AuthorName _authorName = AuthorName.Of(author.FirtName, author.LastName)!;
    AuthorPhoneNumber _authorPhone = AuthorPhoneNumber.Of(author.PhoneNumber)!;
    AuthorId _authorId = AuthorId.Of(author.Id);

    return new Author
    {
      Id = _authorId,
      AuthorName = _authorName,
      AuthorPhoneNumber = _authorPhone,
      Email = author.Email,
      IsActive = author.IsActive
    };
  }
}