using api_cartao.Data.Repositories;
using api_cartao.Service;

namespace api_cartao.Extensions
{
    public static class ConsultaCartaoExtension
    {
        public static IServiceCollection AddConsultaCartaoExtension(this IServiceCollection services) 
        {
            services.AddScoped<IConsultaCartaoRepository, ConsultaCartaoRepository>();
            services.AddTransient<IConsultaCartaoService, ConsultaCartaoService>();
            return services;
        }
    }
}
