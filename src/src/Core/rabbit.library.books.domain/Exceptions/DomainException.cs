namespace rabbit.library.books.domain.Exceptions;
public class DomainException : Exception
{
  public DomainException(string message) : base($"Domain exception {message}")
  {
    
  }
}