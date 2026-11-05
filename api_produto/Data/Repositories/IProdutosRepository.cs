using api_produto.Model.Entities;
using api_produto.Model.Request;

namespace api_produto.Data.Repositories
{
    public interface IProdutosRepository
    {
        Task<List<ProdutosEntity>> PegarTodosProdutos();
        Task<bool> VerificarQtdEstoque(VerificarQtdEstoqueRequest produto);
    }
}
