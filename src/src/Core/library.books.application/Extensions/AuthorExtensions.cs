using library.books.application.Dtos;
using rabbit.library.books.domain.Models;

namespace library.books.application.Extensions;
public static class AuthorExtensions
{
  public static AuthorDto ToAuthorDto(this Author author)
  {
    return DtoFromAuthor(author);
  }

  private static AuthorDto DtoFromAuthor(Author author)
  {
    return new()
    {

    };
  }
}