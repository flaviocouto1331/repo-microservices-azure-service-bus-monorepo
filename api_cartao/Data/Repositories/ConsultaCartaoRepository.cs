using api_cartao.Data.Dapper;
using api_cartao.Model.Request;
using Dapper;
using System.Text;

namespace api_cartao.Data.Repositories
{
    public class ConsultaCartaoRepository : IConsultaCartaoRepository
    {
        private readonly DapperContext _dapper;
        public ConsultaCartaoRepository(DapperContext dapper) => _dapper = dapper ?? throw new ArgumentException("Dapper inválido.", nameof(dapper));
        
        public async Task<string> ConsultarCartao(ConsultaCartaoRequest cartao)
        {
            StringBuilder query = new();
            query.Append(" select CartaoStatus from ConsultaCartao where Cartao = @Cartao");
            using var _ctx = _dapper.DapperConnecion();
            string condicao = await _ctx.ExecuteScalarAsync<string>(
                query.ToString(),
                cartao
                ) ?? "REPROVADO";
            return condicao;
        }
    }
}
