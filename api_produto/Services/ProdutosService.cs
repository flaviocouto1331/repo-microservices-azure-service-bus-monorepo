using api_produto.Data.Repositories;
using api_produto.Model.Request;
using api_produto.Model.Response;

namespace api_produto.Services
{
    public class ProdutosService : IProdutosService
    {
        private readonly IProdutosRepository _repository;
        public ProdutosService(IProdutosRepository repository) => _repository = repository ?? throw new ArgumentException("Repositório inválido.", nameof(repository));

        public async Task<List<ProdutosResponse>> PegarTodosProdutos()
        {
            var produtos = await _repository.PegarTodosProdutos();
            if (produtos.Count == 0) return [];
            var produtosResponse = produtos.Select(o => new ProdutosResponse
            {
                Id = o.Id,
                NomeProduto = o.NomeProduto,
                ValorProduto = o.ValorProduto,
                EstoqueProduto = o.EstoqueProduto
            }).ToList();
            return produtosResponse;
        }

        public Task<bool> VerificarQtdEstoque(VerificarQtdEstoqueRequest produto) => _repository.VerificarQtdEstoque(produto);        
    }
}
