namespace fn_estoque_queue.Model.Response
{
    public class VerificarQtdEstoqueResponse
    {
        public bool status { get; set; }
        public string message { get; set; } = null!;
        public bool CondicaoProduto { get; set; }
    }
}