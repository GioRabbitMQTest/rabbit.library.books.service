using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rabbit.library.books.domain.Models;
using rabbit.library.books.domain.ValueObjects;

namespace rabbit.library.books.infraestructure.Persistence.Cofigurations;
public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
  public void Configure(EntityTypeBuilder<Author> builder)
  {
    builder.HasKey(x => x.Id);

    builder.Property(x => x.Id)
      .HasConversion
      (
        authorId => authorId.Value,
        dbId => AuthorId.Of(dbId)
      );

    builder.Property(x => x.AuthorPhoneNumber)
      .HasConversion
      (
        p => p.Value,
        value => AuthorPhoneNumber.Of(value)!
      )
      .HasMaxLength(9);

    builder.HasMany(p => p.AuthorBooks)
      .WithOne(ab => ab.Author)
      .HasForeignKey(ab => ab.AuthorId)
      .OnDelete(DeleteBehavior.Cascade);

    builder.ComplexProperty
      (
        x => x.AuthorName,
        name =>
        {
          name.Property(n => n.FirstName)
          .HasMaxLength(50)
          .IsRequired();

          name.Property(n => n.LastName)
          .HasMaxLength(50)
          .IsRequired();
        }
      );
  }
}