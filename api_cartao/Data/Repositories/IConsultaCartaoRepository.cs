using api_cartao.Model.Request;

namespace api_cartao.Data.Repositories
{
    public interface IConsultaCartaoRepository
    {
        Task<string> ConsultarCartao(ConsultaCartaoRequest cartao);
    }
}
