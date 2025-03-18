using rabbit.library.books.domain.Abstractions;
using rabbit.library.books.domain.ValueObjects;

namespace rabbit.library.books.domain.Models;
public class Book : AggregateRoot<BookId>
{
  public string Title { get; set; }
  public string Synopsis { get; set; }
  private List<AuthorBook> _authorBook = new();
  public IReadOnlyList<AuthorBook> AuthorBooks => _authorBook.AsReadOnly();
}