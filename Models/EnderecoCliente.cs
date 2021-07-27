using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste_Semantix.Nucleo.Abstratos;

namespace Teste_Semantix.Models
{
    public class EnderecoCliente: ObjetoBase
    {
        public int ClienteId { get; set; }
        public int Cep { get; set; }
        public string Logadouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
    }
}