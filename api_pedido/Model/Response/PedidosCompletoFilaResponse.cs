using api_pedido.Model.Request;

namespace api_pedido.Model.Response
{
    public class PedidosCompletoFilaResponse
    {
        public required PedidosFilaRequest PedidosFilaRequest { get; set; }
        public required PedidosResponse PedidosResponse { get; set; }
    }
}
