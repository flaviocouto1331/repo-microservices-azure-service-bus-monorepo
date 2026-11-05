using api_pedido.Data.Repositories;
using api_pedido.Services;

namespace api_pedido.Extensions
{
    public static class PedidosExtension
    {
        public static IServiceCollection AddPedidosExtension(this IServiceCollection services) 
        {
            services.AddScoped<IPedidosRepository, PedidosRepository>();
            services.AddTransient<IPedidosService, PedidosService>();
            return services;
        }
    }
}
