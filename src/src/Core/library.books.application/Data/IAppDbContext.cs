using Microsoft.EntityFrameworkCore;
using rabbit.library.books.domain.Models;

namespace library.books.application.Data;
public interface IAppDbContext
{
  DbSet<Author> Authors { get; set; }
  DbSet<Book> Books { get; set; }
  DbSet<AuthorBook> AuthorBooks { get; set; }
  Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}