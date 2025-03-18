using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rabbit.library.books.domain.Models;

namespace rabbit.library.books.infraestructure.Persistence.Cofigurations;
public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
{
  public void Configure(EntityTypeBuilder<AuthorBook> builder)
  {
    builder.HasKey(ab => new { ab.AuthorId, ab.BookId });

    builder.HasOne(x => x.Author)
      .WithMany(x => x.AuthorBooks)
      .HasForeignKey(ab => ab.AuthorId);

    builder.HasOne(x => x.Book)
      .WithMany(x => x.AuthorBooks)
      .HasForeignKey(ab => ab.BookId);
  }
}