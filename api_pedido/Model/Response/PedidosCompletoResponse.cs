using System.Text.Json.Serialization;

namespace api_pedido.Model.Response
{
    public class PedidosCompletoResponse : PedidosResponse
    {
        [JsonPropertyOrder(2)]
        public bool StatusCadastro { get; set; }
        [JsonPropertyOrder(4)]
        public Guid IdCliente { get; set; }
        [JsonPropertyOrder(6)]
        public string CartaoCliente { get; set; } = null!;
        [JsonPropertyOrder(7)]
        public Guid IdProduto { get; set; }
    }
}
