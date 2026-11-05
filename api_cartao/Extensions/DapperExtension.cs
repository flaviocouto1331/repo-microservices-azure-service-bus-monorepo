using api_cartao.Data.Dapper;

namespace api_cartao.Extensions
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
