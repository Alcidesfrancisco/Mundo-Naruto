using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MundoNaruro
{
    public partial class Cadastro : System.Web.UI.Page
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Email email = new Email();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {

            string userEnteredCode = captchTextBox.Text;
            ValidateUserCode(userEnteredCode);

        }


        private void ValidateUserCode(string userEnteredCode)
        {
            if (Session["Code"].ToString().Equals(userEnteredCode))
            {
                if (0 == string.Compare(senhaTextBox.Text, confirmaSenhaTextBox.Text))
                {
                    UsuarioBean usuario = new UsuarioBean();
                    Criptografia cripto = new Criptografia();

                    usuario.DataNascimento = new DateTime(1982, 09, 03);
                    usuario.Email = emailTextBox.Text;
                    usuario.Login = loginTextBox.Text;
                    usuario.Nome = nomeTextBox.Text;
                    usuario.Senha = cripto.criptografa(senhaTextBox.Text);
                    if (newsCheckBox.Checked)
                    {
                        usuario.NewsLetter = 1;
                    }
                    else
                    {
                        usuario.NewsLetter = 0;
                    }
                    mensagem.Text = usuarioDAO.inserirUsuario(usuario);
                    if (mensagem.Text.Equals("Usuário Cadastrado com Sucesso!"))
                    {
                        string newsLetter = email.enviarEmail(emailTextBox.Text, " NewsLetter Mundo Naruto", "Apartir de agora vc receberá semanlmente nossa NewsLetter com as principais Novidades do Mundo Naruto!!");
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "OK", "alert('" + usuario.Email + "')", true);
                    }
                    limpar();
                }
                else
                {
                    mensagem.Text = "As Senhas Não Conferem! Digite as Senhas Novamente";
                }

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
            emailTextBox.Text = "";
            loginTextBox.Text = "";
            nomeTextBox.Text = "";
            senhaTextBox.Text = "";
            senhaTextBox.Text = "";
        }

        protected void limparButton_Click(object sender, EventArgs e)
        {
            limpar();
        }



    }
}