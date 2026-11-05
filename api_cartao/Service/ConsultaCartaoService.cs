using api_cartao.Data.Repositories;
using api_cartao.Model.Request;

namespace api_cartao.Service
{
    public class ConsultaCartaoService : IConsultaCartaoService
    {
        private readonly IConsultaCartaoRepository _repository;
        public ConsultaCartaoService(IConsultaCartaoRepository repository) => _repository = repository ?? throw new ArgumentException("Repositório inválido.", nameof(repository));

        public async Task<string> ConsultarCartao(ConsultaCartaoRequest cartao) => await _repository.ConsultarCartao(cartao);
  
    }
}
