using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rabbit.library.books.domain.Models;
using rabbit.library.books.domain.ValueObjects;

namespace rabbit.library.books.infraestructure.Persistence.Cofigurations;
public class BookConfiguration : IEntityTypeConfiguration<Book>
{
  public void Configure(EntityTypeBuilder<Book> builder)
  {
    builder.HasKey(x => x.Id);

    builder.Property(x => x.Id)
      .HasConversion
      (
        bookId => bookId.Value,
        value => BookId.Of(value)
      );

    builder.Property(x => x.Title)
      .HasMaxLength(50)
      .IsRequired();

    builder.Property(x => x.Synopsis)
      .HasMaxLength(200)
      .IsRequired();

    builder.HasMany(x => x.AuthorBooks)
      .WithOne(ab => ab.Book)
      .HasForeignKey(ab => ab.BookId)
      .OnDelete(DeleteBehavior.Restrict);
  }
}