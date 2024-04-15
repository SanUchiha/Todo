using ListaTareas.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ListaTareas.Repo
{
    public static class InjeccionDependenciaRepo
    {
        public static IServiceCollection AddInjectionRepo(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(ToDoContext).Assembly.FullName;

            /*
            services.AddDbContext<ToDoContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("CadenaConexionBD"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);
            */
            services.AddDbContext<ToDoContext>(
                options => options.UseMySQL(
                    configuration.GetConnectionString("CadenaConexionBD"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
