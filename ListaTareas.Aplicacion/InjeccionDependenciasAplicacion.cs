using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ListaTareas.Aplicacion
{
    public static class InjeccionDependenciasAplicacion
    {
        public static IServiceCollection AddInjectionAplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ITareaAplicacion, TareaAplicacion>();

            return services;
        }
    }
}
