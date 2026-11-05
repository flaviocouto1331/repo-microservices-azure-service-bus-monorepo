using api_cliente.Data.Repositories;
using api_cliente.Model.Entities;
using api_cliente.Model.Request;
using api_cliente.Model.Response;

namespace api_cliente.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        public ClienteService(IClienteRepository repository) => _repository = repository ?? throw new ArgumentException("Repository inválido.", nameof(repository));

        public Task<bool> ConfirmarCliente(ConfirmarClienteRequest cliente) => _repository.ConfirmarCliente(cliente);
        
        public async Task<List<ClienteResponse>> PegarTodosCliente()
        {
            List<ClienteEntity> cliente = await _repository.PegarTodosCliente();
            if (cliente.Count == 0) throw new Exception("Nenhum cliente encontrado.");
            List<ClienteResponse> clienteResponse = cliente.Select(o => new ClienteResponse
            {
                Id = o.Id,
                Nome = o.Nome,
                Cartao = o.Cartao
            }).ToList();           
            return [.. clienteResponse];
        }
    }
}
