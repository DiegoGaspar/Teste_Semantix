//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste_Semantix.Models
{
    using System;
    using System.Collections.Generic;
    using Teste_Semantix.Models.Abstratos;

    public class Cliente_Telefone : ObjetoBase
    {
        public int NumeroTelefone { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
