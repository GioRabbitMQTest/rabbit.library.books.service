using library.books.application.Data;
using Microsoft.EntityFrameworkCore;
using rabbit.library.books.domain.Models;

namespace rabbit.library.books.infraestructure.Persistence;
public class AppDbContext : DbContext, IAppDbContext
{
  public DbSet<Author> Authors { get; set; }
  public DbSet<Book> Books { get; set; }
  public DbSet<AuthorBook> AuthorBooks { get; set; }

  public AppDbContext(DbContextOptions options) : base(options)
  {
    
  }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
  }
}