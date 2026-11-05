using api_cartao.Model.Request;

namespace api_cartao.Service
{
    public interface IConsultaCartaoService
    {
        Task<string> ConsultarCartao(ConsultaCartaoRequest cartao);
    }
}
