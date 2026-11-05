using api_produto.Data.Repositories;
using api_produto.Services;

namespace api_produto.Extensions
{
    public static class ProdutosExtension
    {
        public static IServiceCollection AddProdutosExtension(this IServiceCollection services) 
        {
            services.AddScoped<IProdutosRepository, ProdutosRepository>();
            services.AddTransient<IProdutosService, ProdutosService>();
            return services;
        }
    }
}
