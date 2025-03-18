using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using rabbit.framework.messaging.MassTransit;
using System.Reflection;

namespace library.books.application;
public static class DependencyInjection
{
  public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddMediatR(config =>
    {
      config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    });

    services.AddFeatureManagement();

    //ADD RABBIT CONFIG
    services.AddMessageBroker(configuration, Assembly.GetExecutingAssembly());

    return services;
  }
}