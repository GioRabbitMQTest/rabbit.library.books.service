using library.books.application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rabbit.library.books.infraestructure.Persistence;

namespace rabbit.library.books.infraestructure;
public static class DependencyInjection
{
  public static IServiceCollection AddInfraestructureService
  (
    this IServiceCollection services,
    IConfiguration configuration
  )
  {
    services.AddDbContext<AppDbContext>(options =>
    {
      options.UseSqlServer(configuration.GetConnectionString("Database"));
    });

    services.AddScoped<IAppDbContext, AppDbContext>();

    return services;
  }
}