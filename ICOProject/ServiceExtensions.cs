using ICOBusinessLayer.Contract;
using ICOBusinessLayer.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICOProject
{
  public static class ServiceExtensions
  {
    public static IServiceCollection RegisterServices(
        this IServiceCollection services)
    {
      services.AddTransient<IExchangeService, ExchangeService>();
      // Add all other services here.
      return services;
    }
  }
}
