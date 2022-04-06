using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoNaruro
{
    public partial class RecuperarSenha : System.Web.UI.Page
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Email email = new Email();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContinuarButton_Click(object sender, EventArgs e)
        {
            // validate the code 

            string userEnteredCode = captchTextBox.Text;

            ValidateUserCode(userEnteredCode);
        }

        // Email email = new Email();
        private void ValidateUserCode(string userEnteredCode)
        {
            if (Session["Code"].ToString().Equals(userEnteredCode))
            {
                string[] dados = email.verificarEmail(emailTextBox.Text, usuarioTextBox.Text);
                email.enviarEmail(dados[0], "RECUPERAÇÃO DE SENHA", "SEU NOME DE USUÁRIO É '" + dados[1] + "'");
                mensagem.Text = dados[0];
                teste.Text = dados[1];
                Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('mensagem!')", true);

            }
            else
            {
                // clear the session and generate a new code 
                Session["Code"] = null;

                mensagem.Text = "Digite o código Captha corretamente!";
            }
        }
        public void limpar()
        {

        }

        protected void limparButton_Click(object sender, EventArgs e)
        {
            limpar();
        }



    }
}