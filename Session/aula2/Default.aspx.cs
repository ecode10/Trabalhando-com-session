using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aula2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            //String _nome = txtNome.Text;
            //string _email = txtEmail.Text;
            //string _data = txtDataNascimento.Text;
            //string _senha = txtSenha.Text;

            //Response.Write(_nome + "<br>" + _email + "<Br>" + _data);
            //Response.Write("Formulário enviado com sucesso.");

            AdicionaSessionERedirecionaPagina();
        }

        private void AdicionaSessionERedirecionaPagina()
        {
            //gerar sessao
            Session.Add("Nome", txtNome.Text);
            Session.Add("Email", txtEmail.Text);

            //redirecionar para outra pagina
            Response.Redirect("Pagina2");
        }

       
    }
}