using rabbit.library.books.domain.Exceptions;

namespace rabbit.library.books.domain.ValueObjects;
public record AuthorId
{
  public Guid Value { get; }
  private AuthorId(Guid value) => Value = value;
  public static AuthorId Of(Guid value)
  {
    ArgumentNullException.ThrowIfNull(value);
    if (value == Guid.Empty)
      throw new DomainException("Author id cant't be empty");

    return new AuthorId(value);
  }
}