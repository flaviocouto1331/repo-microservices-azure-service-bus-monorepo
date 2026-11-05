using api_cliente.Model.Entities;
using api_cliente.Model.Request;

namespace api_cliente.Data.Repositories
{
    public interface IClienteRepository
    {
        Task<List<ClienteEntity>> PegarTodosCliente();
        Task<bool> ConfirmarCliente(ConfirmarClienteRequest cliente);
    }
}
