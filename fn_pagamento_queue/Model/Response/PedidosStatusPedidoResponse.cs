namespace fn_pagamento_queue.Model.Response
{
    public class PedidosStatusPedidoResponse
    {
        public bool status { get; set; }
        public string message { get; set; } = null!;
        public Guid Id { get; set; }
    }
}
