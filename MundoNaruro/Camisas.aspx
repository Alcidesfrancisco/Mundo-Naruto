<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Camisas.aspx.cs" Inherits="MundoNaruro.compraCamisa" %>

<%@ Import Namespace="MundoNaruro.bean" %>
<%@ Import Namespace="MundoNaruro.control" %>
<%@ Import Namespace="System.Collections" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/Estilos.css" />
    <script src="/js-global/FancyZoom.js" type="text/javascript"></script>
    <script src="/js-global/FancyZoomHTML.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"
    Visible="False">
    <br />
    <br />
    <asp:Label ID="CamisasLabel" runat="server" Text="Camisas Mundo Naruto"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Panel runat="server" Style="margin-bottom: 244px" ScrollBars="Both">
        <div style="position: static; width: 805px; height: 750px; top: 81px; left: -1px;
            font-size: large; font-family: Tahoma; font-style: normal;">
            <%
                
                ProdutoDAO produtoDAO = new ProdutoDAO();
                ArrayList camisas = produtoDAO.listarCamisas();
                foreach (ProdutoBean item in camisas)
                {
                    descricaoLabel.Text = item.DescricaoProduto;
                    NomeLabel.Text = item.NomeProduto;
                    valorLabel.Text = Convert.ToString(item.ValorProduto);
                    freteLabel.Text = Convert.ToString(item.ValorFrete);
                    comprarImageButton.PostBackUrl = item.BotaoComprar;
                    fotoProduto.ImageUrl = item.FotoProduto;
                     zoomHyperLink.NavigateUrl = item.FotoProduto;
                                       
            %>
            <table onload="setupZoom()">
                <tr>
                    <td id="foto">
                        <asp:HyperLink ID="zoomHyperLink" runat="server"><asp:Image AlternateText="Foto Não Disponível" ID="fotoProduto" runat="server" Width="100"
                            Height="100" /></asp:HyperLink>
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
                <asp:ImageButton ID="comprarImageButton" runat="server" Height="61px" ImageUrl="~/img/pagSeguroButton.gif"
                    OnClick="comprarImageButton_Click" Width="99px" AlternateText="PagSeguro e simples, fácil e seguro!"
                    ToolTip="Clique para Comprar!" />
            </div>
            <%} %>
        </div>
    </asp:Panel>
</asp:Content>
