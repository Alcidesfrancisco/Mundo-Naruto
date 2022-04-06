using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data.SqlClient;
using MundoNaruro.Conexao;

namespace MundoNaruro
{
    public class Email
    {
        public string enviarEmail(string destino, string assunto, string mensagem)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("projetomundonaruto@gmail.com");
                mail.To.Add(destino);
                mail.Subject = assunto;
                mail.Body = mensagem;
                mail.IsBodyHtml = true;
                 

                smtp.Credentials = new System.Net.NetworkCredential("projetomundonaruto@gmail.com", "mundonaruto2012");
                //smtp.Port = 465;
                smtp.EnableSsl = true;
                smtp.Port = 25;

                // smtp.SmtpServer = "your mail server name goes here";
                smtp.Send(mail);

                return "Mensagem Enviada para o email:'" + destino + "', Verifique a sua caixa de entrada!";

            }
            catch (Exception exc)
            {
                return exc.Message;
            }

        }
        public string[] verificarEmail(string emailReq, string loginReg)
        {
            string recuperarSql = "SELECT email, login FROM usuario WHERE (email = '"+emailReq+"') OR (login = '"+loginReg+"')";
            Conectar conectar = new Conectar();
            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand recuperar = new SqlCommand(recuperarSql, conexao);

            string[] retorno = new String[2];
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(recuperarSql, conexao);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        retorno[0] = reader[0].ToString();
                        retorno[1] = reader[1].ToString();
                        return retorno;
                    }
                }

                reader.Close();
                reader.Dispose();
                comando.Dispose();
                conexao.Close();
                conexao.Dispose();

                return retorno;
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
    }
}
