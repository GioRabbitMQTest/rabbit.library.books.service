using rabbit.library.books.domain.ValueObjects;

namespace rabbit.library.books.domain.Models;
public class AuthorBook
{
  public Author Author { get; set; }
  public AuthorId AuthorId { get; set; } = default!;

  public Book Book { get; set; }
  public BookId BookId { get; set; } = default!;
}