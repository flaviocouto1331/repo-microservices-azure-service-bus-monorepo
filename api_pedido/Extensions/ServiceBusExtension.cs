using api_pedido.Messaging;

namespace api_pedido.Extensions
{
    public static class ServiceBusExtension
    {
        public static IServiceCollection AddServiceBusExtension(this IServiceCollection services)
        {
            services.AddScoped<IServiceBus, ServiceBus>();
            return services;
        }
    }
}
