using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Teste_Semantix.Integracao.Base;
using Teste_Semantix.Models;

namespace Teste_Semantix.Integracao
{
    public class CepIntegracao
    {

        public async Task<CEP> GetCep(string cep)
        {

            string responseBody = "";
            try
            {
                String url = String.Format("https://viacep.com.br/ws/{0}/json/", cep);
                
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(url).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            response.EnsureSuccessStatusCode();
                            responseBody = await response.Content.ReadAsStringAsync();
                        }
                    }
                }
                var result = JsonConvert.DeserializeObject<CEP>(responseBody);
                return result;
                
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}