using api_pedido.Model.Request;
using api_pedido.Model.Response;

namespace api_pedido.Data.Repositories
{
    public interface IPedidosRepository
    {
        Task<List<PedidosResponse>> PegarTodosPedidos();
        Task<PedidosCompletoResponse> CriarPedido(PedidosRequest pedido);
        Task AtualizarStatusPedido(PedidosStatusPedidoRequest pedido);
    }
}
