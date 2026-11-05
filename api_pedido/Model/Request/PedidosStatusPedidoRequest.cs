namespace api_pedido.Model.Request
{
    public class PedidosStatusPedidoRequest
    {
        public Guid Id { get; set; }
        public string StatusPedido { get; set; } = null!;
    }
}
