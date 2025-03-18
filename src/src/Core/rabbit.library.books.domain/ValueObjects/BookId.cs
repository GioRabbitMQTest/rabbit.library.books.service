using rabbit.library.books.domain.Exceptions;

namespace rabbit.library.books.domain.ValueObjects;
public record BookId
{
  public Guid Value { get; }
  private BookId(Guid value) => Value = value;

  public static BookId Of(Guid value)
  {
    ArgumentNullException.ThrowIfNull(value);
    if (value == Guid.Empty)
      throw new DomainException("BookId can´t be empty");

    return new BookId(value);
  }
}