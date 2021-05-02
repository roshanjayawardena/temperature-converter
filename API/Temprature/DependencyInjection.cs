using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Temprature.Behaviours;

namespace Temprature
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationTemperature(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            return services;
        }
    }
}
