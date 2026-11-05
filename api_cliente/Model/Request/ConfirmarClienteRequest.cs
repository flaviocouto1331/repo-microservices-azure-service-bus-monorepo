namespace api_cliente.Model.Request
{
    public class ConfirmarClienteRequest
    {
        public Guid IdCliente { get; set; }
        public string CartaoCliente { get; set; } = null!;
    }
}
