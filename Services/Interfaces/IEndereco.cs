using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Semantix.Services.Interfaces
{
    interface IEndereco
    {
        List<Cliente_Endereco> Get(int id);
        
    }
}
