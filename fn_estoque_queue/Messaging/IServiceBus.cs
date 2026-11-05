using fn_estoque_queue.Model.Request;

namespace fn_estoque_queue.Messaging
{
    public interface IServiceBus
    {
        Task EnviarMensagemFilaAzureServiceBus(PedidosFilaRequest pedido, string filaNome);
    }
}
