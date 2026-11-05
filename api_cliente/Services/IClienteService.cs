using api_cliente.Model.Request;
using api_cliente.Model.Response;

namespace api_cliente.Services
{
    public interface IClienteService
    {
        Task<List<ClienteResponse>> PegarTodosCliente();
        Task<bool> ConfirmarCliente(ConfirmarClienteRequest cliente);
    }
}
