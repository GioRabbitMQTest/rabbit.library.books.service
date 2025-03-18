using System.Text.RegularExpressions;

namespace rabbit.library.books.domain.ValueObjects;
public partial record AuthorPhoneNumber
{
  private const int DefaultLength = 8;
  private const string Pattern = @"^(?:-*\d-*){8}$";

  public string Value { get; set; }
  public AuthorPhoneNumber(string value) => Value = value;

  public static AuthorPhoneNumber? Of(string value)
  {
    if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLength)
      return null;

    return new AuthorPhoneNumber(value);
  }

  [GeneratedRegex(Pattern)]
  private static partial Regex PhoneNumberRegex();
}