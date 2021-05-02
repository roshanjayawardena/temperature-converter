using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Temprature
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationTemperature(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());            
            return services;
        }
    }
}
