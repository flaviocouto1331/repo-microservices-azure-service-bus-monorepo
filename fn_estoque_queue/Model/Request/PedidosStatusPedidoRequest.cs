namespace fn_estoque_queue.Model.Request
{
    public class PedidosStatusPedidoRequest
    {
        public Guid Id { get; set; }
        public string StatusPedido { get; set; } = null!;
    }
}
