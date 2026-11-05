using api_pedido.Model.Request;

namespace api_pedido.Messaging
{
    public interface IServiceBus
    {
        Task EnviarMensagemFilaAzureServiceBus(PedidosFilaRequest pedido, string filaNome);
    }
}
