using api_cliente.Data.Dapper;

namespace api_cliente.Extensions
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
