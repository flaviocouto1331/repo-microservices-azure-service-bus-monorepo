using api_pedido.Model.Entities;
using api_pedido.Model.Request;
using api_pedido.Model.Response;

namespace api_pedido.Services
{
    public interface IPedidosService
    {
        Task<List<PedidosResponse>> PegarTodosPedidos();
        Task<PedidosCompletoFilaResponse> CriarPedido(PedidosRequest pedido);
        Task AtualizarStatusPedido(PedidosStatusPedidoRequest pedido);
    }
}
