using rabbit.library.books.domain.Abstractions;
using rabbit.library.books.domain.ValueObjects;

namespace rabbit.library.books.domain.Models;
public class Author : Entity<AuthorId>
{
  private readonly List<AuthorBook> _authorBooks = new();
  public IReadOnlyList<AuthorBook> AuthorBooks => _authorBooks.AsReadOnly();
  public AuthorName AuthorName { get; set; } = default!;
  public AuthorPhoneNumber AuthorPhoneNumber { get; set; } = default!;
  public string Email { get; set; }
  public bool IsActive { get; set; }

  public static Author Create(AuthorId authorId, AuthorName authorName, AuthorPhoneNumber authorPhoneNumber, string email, bool isActive)
    => new()
        {
          Id = authorId,
          AuthorName = authorName,
          AuthorPhoneNumber = authorPhoneNumber,
          Email = email,
          IsActive = isActive
        };
}