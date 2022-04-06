using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MundoNaruro.Conexao;
using System.Collections;
using MundoNaruro.bean;
using System.Data.SqlTypes;


namespace MundoNaruro
{
    public class UsuarioDAO
    {
        Conectar conectar = new Conectar();
        string excluirSql = "";
        string alterarSql = "";
        string listarSql = "";
        string inserirSql = "";
        string recuperarSql = "";
        DateTime agora = DateTime.Now;
        Email email = new Email();

        public string inserirUsuario(UsuarioBean usuario)
        {
            inserirSql = "insert into usuario (login,senha,email,nome,dataNascimento,dataCadastro,perfil,newsletter) values ('" + usuario.Login + "','" + usuario.Senha + "','" + usuario.Email + "','" + usuario.Nome + "','" + usuario.DataNascimento + "','" + agora.ToString() + "',2,"+usuario.NewsLetter+")";

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand inserir = new SqlCommand(inserirSql, conexao);

            try
            {
                conexao.Open();
                inserir.ExecuteNonQuery();
                string retorno = email.enviarEmail(usuario.Email, "Mundo Naruto", "Seu Cadastro foi efetuado com Sucesso!");
                
                return "Usuário Cadastrado com Sucesso!";
            }
            catch(SqlException)
            {
                return "Esse Login já existe, Informe outro login!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        public UsuarioBean ConsultaUsuario(string login)
        {
            alterarSql = "SELECT *FROM Usuario WHERE login ='" + login + "'";
            UsuarioBean usuario = new UsuarioBean();

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(alterarSql, conexao);
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(alterarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    usuario.Login = reader.GetString(0);
                    usuario.Email = reader.GetString(2);
                    usuario.Nome = reader.GetString(3);
                    usuario.DataCadastro = reader.GetString(4);
                    usuario.DataNascimento = reader.GetDateTime(5);

                }

                //Fecha a conexão.
                conexao.Close();

                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

        }
        public UsuarioBean LoginUsuario(string login, string senha)
        {
            alterarSql = "SELECT *FROM Usuario WHERE login ='" + login + "' AND senha = '"+senha+"'";
            UsuarioBean usuario = new UsuarioBean();

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(alterarSql, conexao);
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(alterarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    usuario.Login = reader.GetString(0);
                    usuario.Email = reader.GetString(2);
                    usuario.Nome = reader.GetString(3);
                    usuario.DataCadastro = reader.GetString(4);
                    usuario.DataNascimento = reader.GetDateTime(5);

                }

                //Fecha a conexão.
                conexao.Close();

                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

        }
        public ArrayList equipe()
        {
            listarSql = "SELECT usuario.login, usuario.email, usuario.nome, usuario.foto, usuario.perfil, usuario.facebook, usuario.frase, perfil.nomePerfil FROM perfil INNER JOIN usuario ON perfil.idPerfil = usuario.perfil WHERE (usuario.perfil = 1) ORDER BY usuario.nome";

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            ArrayList equipeList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EquipeBean e = new EquipeBean();
                    e.Login= reader.GetString(0);
                    e.Email = reader.GetString(1);
                    e.Nome = reader.GetString(2);
                    e.Foto = reader.GetString(3);
                    // não urei usar o id perfil
                    e.Facebbok = reader.GetString(5);
                    e.Frase = reader.GetString(6);
                    e.Perfil = reader.GetString(7);

                    equipeList.Add(e);
                }

                //Fecha a conexão.
                conexao.Close();

                return equipeList;
            }
            catch (SqlNullValueException ex)
            {
                throw;
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