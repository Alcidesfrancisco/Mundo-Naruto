using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoNaruro.bean
{
    public class ProdutoBean
    {

        private int idProduto;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }
        private string nomeProduto;

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        private string descricaoProduto;

        public string DescricaoProduto
        {
            get { return descricaoProduto; }
            set { descricaoProduto = value; }
        }
        private double valorProduto;

        public double ValorProduto
        {
            get { return valorProduto; }
            set { valorProduto = value; }
        }
        private double valorFrete;

        public double ValorFrete
        {
            get { return valorFrete; }
            set { valorFrete = value; }
        }
        String botaoComprar;

        public String BotaoComprar
        {
            get { return botaoComprar; }
            set { botaoComprar = value; }
        }
        String categoriaProduto;

        public String CategoriaProduto
        {
            get { return categoriaProduto; }
            set { categoriaProduto = value; }
        }
        private string fotoProduto;

        public string FotoProduto
        {
            get { return fotoProduto; }
            set { fotoProduto = value; }
        }
    }
}