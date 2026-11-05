namespace fn_pagamento_queue.Model.Response
{
    public class ConsultaCartaoResponse
    {
        public bool status { get; set; }
        public string mensagem { get; set; } = null!;
        public string CondicaoCartao { get; set; } = null!;
    }
}
