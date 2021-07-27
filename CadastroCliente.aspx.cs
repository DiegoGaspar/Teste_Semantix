using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Teste_Semantix.Integracao;
using Teste_Semantix.Models;

namespace Teste_Semantix
{
    public partial class Contact : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }     

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var modeloCep = new CepIntegracao().GetCep(CampoDeCep.Text);
            TextBox4.Text = modeloCep.Result.logradouro;
            TextBox5.Text = modeloCep.Result.bairro;
            TextBox6.Text = modeloCep.Result.localidade;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var cliente = new Models.Cliente();
            var telefone = new Models.Cliente_Telefone();
            var endereco = new Models.Cliente_Endereco();
            cliente.Nome = TextBox1.Text;
            telefone.NumeroTelefone = int.Parse(TextBox2.Text);
            endereco.cep = int.Parse(CampoDeCep.Text);

            bool cadastrado = DAO.CadastroCliente.CadastrarCliente(cliente, endereco,telefone);
            if (cadastrado)
            {
                ltMensagem.Text = cliente.Nome + " foi cadastrado(a) com sucesso!";  
            }
            else
            {
                ltMensagem.Text = "Ocorreu um erro ao tentar cadastrar";
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private IQueryable<Cliente> GetBaseDeDados()
        {
            String sql = "SELECT checkitem.Id "
                        + "     ,checkitem.IdChecklist "
                        + "     ,checkitem.IdCriterio "
                        + "     ,checklist.Ano as AnoChecklist "
                        + "     ,checklist.Mes as MesChecklist "
                        + "     ,criterios.Id  as CriterioId "
                        + "     ,checklist.Unidade  as Unidade "
                        + "     ,criterios.Valor  as CriterioValor"
                        + "     ,requisitos.Id as RequisitoId "
                        + "     ,diretriz.Descricao as DescricaoDiretriz "
                        + "     ,diretriz.Id as DiretrizId "
                        + "FROM "
                        + "     Checklist_Item checkitem "
                        + "JOIN Checklist checklist ON checkitem.IdChecklist = checklist.Id "
                        + "JOIN Diretrizes_Req_Criterios criterios ON checkitem.IdCriterio = criterios.Id "
                        + "JOIN Diretrizes_Requisitos requisitos ON criterios.IdRequisito = requisitos.Id "
                        + "JOIN Diretrizes  diretriz ON requisitos.IdDiretriz = diretriz.Id ";


            DataSet dataset = SelectSQL(sql);

            List<Cliente> checklistitemList = new List<Cliente>();

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                Cliente cliente = new Cliente();

                cliente.Nome = row.Field<string>("Nome");

                checklistitemList.Add(cliente);
            }

            return checklistitemList.AsQueryable();
        }

        private DataSet SelectSQL(string sql)
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            System.Data.DataSet dataset = new System.Data.DataSet();

            adapter.Fill(dataset);
            return dataset;
        }

        private string GetConnectionString()
        {
            string conString = "Data Source=DIEGO-DEV;Initial Catalog=TesteSemantix;Integrated Security=True";
            return conString;
        }
    }
}