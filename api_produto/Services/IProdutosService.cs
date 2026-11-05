using api_produto.Model.Request;
using api_produto.Model.Response;

namespace api_produto.Services
{
    public interface IProdutosService
    {
        Task<List<ProdutosResponse>> PegarTodosProdutos();
        Task<bool> VerificarQtdEstoque(VerificarQtdEstoqueRequest produto);
    }
}
