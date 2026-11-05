using api_pedido.Data.Repositories;
using api_pedido.Model.Request;
using api_pedido.Model.Response;

namespace api_pedido.Services
{
    public class PedidosService : IPedidosService
    {
        private IPedidosRepository _repository;
        public PedidosService(IPedidosRepository repository) => _repository = repository ?? throw new ArgumentNullException("Repositório inválido.", nameof(repository));

        public Task AtualizarStatusPedido(PedidosStatusPedidoRequest pedido) => _repository.AtualizarStatusPedido(pedido);

        public async Task<PedidosCompletoFilaResponse> CriarPedido(PedidosRequest pedido)
        {
            var pedidoCompletoResponse = await _repository.CriarPedido(pedido);
            
            var pedidoFilaRequest = new PedidosFilaRequest()
            {
                Id = pedidoCompletoResponse.Id,
                IdCliente = pedidoCompletoResponse.IdCliente,
                CartaoCliente = pedidoCompletoResponse.CartaoCliente,
                IdProduto = pedidoCompletoResponse.IdProduto
            };

            var pedidoResponse = new PedidosResponse()
            {
                Id = pedidoCompletoResponse.Id,
                DataCadastro = pedidoCompletoResponse.DataCadastro,
                NomeCliente = pedidoCompletoResponse.NomeCliente,
                NomeProduto = pedidoCompletoResponse.NomeProduto,
                StatusPedido = pedidoCompletoResponse.StatusPedido
            };

            var pedidoCompletoFilaResponse = new PedidosCompletoFilaResponse()
            {
                PedidosFilaRequest = pedidoFilaRequest,
                PedidosResponse = pedidoResponse
            };

            return pedidoCompletoFilaResponse;
        }

        public async Task<List<PedidosResponse>> PegarTodosPedidos() => await _repository.PegarTodosPedidos();  
    }
}
