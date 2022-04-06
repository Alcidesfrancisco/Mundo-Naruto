using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MundoNaruro.util;
using MundoNaruro.Conexao;
using System.Data.SqlClient;
using MundoNaruro.bean;
using System.Collections;

namespace MundoNaruro
{
    public partial class Master : System.Web.UI.MasterPage
    {
        Email email = new Email();
        UsuarioBean usuario = new UsuarioBean();
        Criptografia cripto = new Criptografia();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioBean sessao = (UsuarioBean)Session["usuario"];
            if (sessao == null)
            {
                acessarPanel.Visible = true;
                logadoPanel.Visible = false;

            }
            else
            {
                acessarPanel.Visible = false;
                logadoPanel.Visible = true;
                logadoLabel.Text = sessao.Login;
            }
           
            if ((DateTime.Now.Day % 7 == 12) && (DateTime.Now.Hour == 12))
            {
                List<NewsLetterBean> emails = emailsNewsLetter();
                foreach (NewsLetterBean item in emails)
                {
                    email.enviarEmail(item.Email, "NewsLetter MundoNaruto", "Bom dia '" + item.Usuario + "', Confira nossas novidades no seu site preferido para fãs de Naruto!!");
                }


            }
        }

        public void index()
        {

        }
        public List<NewsLetterBean> emailsNewsLetter()
        {
            string recuperarSql = "SELECT email, login FROM usuario WHERE (newsLetter = 1)";
            Conectar conectar = new Conectar();
            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand recuperar = new SqlCommand(recuperarSql, conexao);
            NewsLetter news = new NewsLetter();
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            NewsLetterBean nl = new NewsLetterBean();
            List<NewsLetterBean> emailList = new List<NewsLetterBean>();

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(recuperarSql, conexao);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nl.Usuario = reader[0].ToString();
                        nl.Email = reader[1].ToString();

                        emailList.Add(nl);

                    }
                }

                reader.Close();
                reader.Dispose();
                comando.Dispose();
                conexao.Close();
                conexao.Dispose();
                return emailList;

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
       
        protected void loginButton_Click(object sender, EventArgs e)
        {
            usuario.Login = loginMasterTextBox.Text;
            usuario.Senha = cripto.criptografa(senhaMasterTextBox.Text);
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

        protected void sairLinkButton_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("index.aspx");
        }

    }
}