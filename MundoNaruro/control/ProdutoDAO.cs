using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MundoNaruro.Conexao;
using MundoNaruro.bean;
using System.Collections;
using System.Data.SqlTypes;
using MundoNaruro.util;

namespace MundoNaruro.control
{
    public class ProdutoDAO
    {
        Conectar conectar = new Conectar();
        string excluirSql = "";
        string alterarSql = "";
        string listarSql = "";
        string inserirSql = "";
        DateTime agora = DateTime.Now;


        public ArrayList listarCamisas()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria WHERE (produto.categoriaProduto = 1)";
            // listarSql = "SELECT *FROM produto";


            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(listarSql, conexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                ProdutoBean[] produto = new ProdutoBean[10];
                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
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

        public ArrayList listarBones()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria WHERE (produto.categoriaProduto = 2)";

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
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
        public ArrayList listarBonecos()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria WHERE (produto.categoriaProduto = 3)";

            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
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
        public ArrayList listarDVDs()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria WHERE (produto.categoriaProduto = 4)";
            // listarSql = "SELECT *FROM produto";


            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(listarSql, conexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                ProdutoBean[] produto = new ProdutoBean[10];
                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
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
        public ArrayList listarAcessorios()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria WHERE (produto.categoriaProduto = 5)";
            // listarSql = "SELECT *FROM produto";


            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(listarSql, conexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                ProdutoBean[] produto = new ProdutoBean[10];
                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
            }
            catch (SqlNullValueException ex)
            {

                Erros.erroNull();
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
        public ArrayList listarTodosProdutos()
        {
            listarSql = "SELECT produto.idProduto, produto.nomeProduto, produto.descriçãoProduto, produto.valorProduto, produto.valorFreteproduto, produto.fotoProduto,produto.botaoComparProduto, categoria.nomeCategoria FROM produto INNER JOIN categoria ON produto.categoriaProduto = categoria.idCategoria";
            
            SqlConnection conexao = new SqlConnection(conectar.Strconexao);
            SqlCommand alterar = new SqlCommand(listarSql, conexao);
            ArrayList produtosList = new ArrayList();
            try
            {
                conexao.Open();
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(listarSql, conexao);

                //Executa a query sql.
                SqlDataReader reader = comando.ExecuteReader();

                ProdutoBean[] produto = new ProdutoBean[10];
                while (reader.Read())
                {
                    ProdutoBean p = new ProdutoBean();
                    p.IdProduto = reader.GetInt32(0);
                    p.NomeProduto = reader.GetString(1);
                    p.DescricaoProduto = reader.GetString(2);
                    p.ValorProduto = reader.GetDouble(3);
                    p.ValorFrete = reader.GetDouble(4);
                    p.FotoProduto = reader.GetString(5);
                    p.BotaoComprar = reader.GetString(6);
                    p.CategoriaProduto = reader.GetString(7);

                    produtosList.Add(p);
                }

                //Fecha a conexão.
                conexao.Close();

                return produtosList;
            }
            catch (SqlNullValueException ex)
            {

                Erros.erroNull();
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