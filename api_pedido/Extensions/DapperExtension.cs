using api_pedido.Data.Dapper;

namespace api_pedido.Extensions
{
    public static class DapperExtension
    {
        public static IServiceCollection AddDapperExtension(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();
            return services;
        }
    }
}
