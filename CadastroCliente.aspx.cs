using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Teste_Semantix.Integracao;

namespace Teste_Semantix
{
    public partial class Contact : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }     

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SQL

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var modeloCep = new CepIntegracao().GetCep(CampoDeCep.Text);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }
    }
}