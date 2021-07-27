using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Teste_Semantix.Nucleo.Abstratos;

namespace Teste_Semantix.Models
{
    public class TelefoneCliente: ObjetoBase
    {
        public int NumeroTelefone { get; set; }
        public int ClienteId { get; set; }
    }
}