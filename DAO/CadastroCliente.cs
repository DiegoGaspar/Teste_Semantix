using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste_Semantix.DAO
{
    public class CadastroCliente
    {      
       public static bool CadastrarCliente(Models.Cliente cliente, Models.Cliente_Endereco endereco, 
            Models.Cliente_Telefone telefone) 
        {
            try
            {
                using (var conexao = new Models.TesteSemantixEntidades())
                {
                    conexao.Cliente.Add(cliente);
                    conexao.SaveChanges();
                    if (cliente.Id>0)
                    {
                        endereco.ClienteId = cliente.Id;
                        telefone.ClienteId = cliente.Id;

                        conexao.Cliente_Telefone.Add(telefone);
                        conexao.SaveChanges();
                        conexao.Cliente_Endereco.Add(endereco);
                        conexao.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            
        }
	}       
}