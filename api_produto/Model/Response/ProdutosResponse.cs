using System.Text.Json.Serialization;

namespace api_produto.Model.Response
{
    public class ProdutosResponse
    {
        [JsonPropertyOrder(1)]
        public Guid Id { get; set; }
        [JsonPropertyOrder(2)]      
        public string NomeProduto { get; set; } = null!;
        [JsonPropertyOrder(3)]
        public decimal ValorProduto { get; set; }
        [JsonPropertyOrder(4)]
        public int EstoqueProduto { get; set; }
    }
}
