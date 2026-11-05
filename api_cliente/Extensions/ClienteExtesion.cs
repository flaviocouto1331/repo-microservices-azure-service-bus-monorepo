using api_cliente.Data.Repositories;
using api_cliente.Services;

namespace api_cliente.Extensions
{
    public static class ClienteExtesion
    {
        public static IServiceCollection AddClienteExtesion(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddTransient<IClienteService, ClienteService>();
            return services;
        }
    }
}
