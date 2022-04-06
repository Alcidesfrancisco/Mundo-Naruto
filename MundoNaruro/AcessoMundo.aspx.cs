using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoNaruro
{
    public partial class AcessoMundo : System.Web.UI.Page
    {
        UsuarioBean usuario = new UsuarioBean();
        Criptografia cripto = new Criptografia();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void acessarButton_Click(object sender, EventArgs e)
        {
            usuario.Login = loginTextBox.Text;
            usuario.Senha = cripto.criptografa(senhaTextBox.Text);
            usuario = usuarioDAO.LoginUsuario(usuario.Login, usuario.Senha);
            if (usuario.Login == null)
            {
                usuario = null;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('Usuário Não encontrado!!')", true);
                Session["usuario"] = usuario;

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('Seja Bem vindo '" + usuario.Nome + " ao Mundo Naruto!'')", true);
                Session["usuario"] = usuario;
                Response.Redirect("index.aspx");
            }

        }
    }
}