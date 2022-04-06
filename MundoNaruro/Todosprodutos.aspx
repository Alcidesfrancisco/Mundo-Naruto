<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Todosprodutos.aspx.cs" Inherits="MundoNaruro.Todosprodutos" %>

<%@ Import Namespace="MundoNaruro.bean" %>
<%@ Import Namespace="MundoNaruro.control" %>
<%@ Import Namespace="System.Collections" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="produtosLabel" runat="server" Text="Todos Produtos Mundo Naruto"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" Style="margin-bottom: 244px" ScrollBars="Both">
        <div style="position: static; width: 805px; height: 750px; top: 81px; left: -1px;
            font-size: large; font-family: Tahoma; font-style: normal;">
            <%
                
                ProdutoDAO produtoDAO = new ProdutoDAO();
                ArrayList produtos = produtoDAO.listarTodosProdutos();
                foreach (ProdutoBean item in produtos)
                {
                    descricaoLabel.Text = item.DescricaoProduto;
                    NomeLabel.Text = item.NomeProduto;
                    valorLabel.Text = Convert.ToString(item.ValorProduto);
                    freteLabel.Text = Convert.ToString(item.ValorFrete);
                    comprarImageButton.PostBackUrl = item.BotaoComprar;
                    fotoProduto.ImageUrl = item.FotoProduto;
            %>
            <table>
                <tr>
                    <td id="foto">
                        <asp:Image AlternateText="Foto Não Disponível" ID="fotoProduto" runat="server" Width="100"
                            Height="100" />
                    </td>
                    <td id="descricao">
                        <asp:Label ID="NomeLabel" runat="server" Text="Nome do Produto"></asp:Label>
                        <br />
                        <asp:Label ID="descricaoLabel" runat="server" Text="Descrição do produto"></asp:Label>
                    </td>
                    <td id="valor">
                        <asp:Label ID="valorLabel" runat="server" Text="Valor do produto"></asp:Label>
                        <br />
                        Frete:<asp:Label ID="freteLabel" runat="server" Text="Valor do Frete"></asp:Label>
                    </td>
                </tr>
            </table>
            <div id="comprar" style="position: relative">
                <asp:ImageButton ID="comprarImageButton" runat="server" Height="58px" ImageUrl="~/img/pagSeguroButton.gif"
                    OnClick="comprarImageButton_Click" Width="74px" AlternateText="PagSeguro e simples, fácil e seguro!"
                    ToolTip="Clique para Comprar!" />
            </div>
            <%} %>
        </div>
    </asp:Panel>
</asp:Content>
