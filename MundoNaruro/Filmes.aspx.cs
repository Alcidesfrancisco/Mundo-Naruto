using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoNaruro
{
    public partial class Filmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioBean sessao = (UsuarioBean)Session["usuario"];
            if (sessao == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('Você deve fazer o login para ter acesso os nossos Downloads exclusivos!')", true);
                Response.Redirect("AcessoMundo.aspx");

            }
        }
    }
}