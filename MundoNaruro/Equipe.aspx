<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Equipe.aspx.cs" Inherits="MundoNaruro.Equipe" %>

<%@ Import Namespace="MundoNaruro.bean" %>
<%@ Import Namespace="MundoNaruro.control" %>
<%@ Import Namespace="System.Collections" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Equipe Técnica</title>
    <style type="text/css">
        .style5
        {
            height: 22px;
        }
        .style6
        {
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Equipe Mundo Naruto</p>
    <p>
        &nbsp</p>
    <asp:Panel ID="Panel1" runat="server" Style="margin-top: 50px">
        <asp:Panel ID="Panel2" runat="server" 
            Style="margin-bottom: 244px; margin-top: -30px;" ScrollBars="Both">
            <div style="position: static; width: 805px; height: 750px; top: 81px; left: -1px;
                font-size: large; font-family: Tahoma; font-style: normal;">
                <%
                
                    MundoNaruro.UsuarioDAO usuarioDAO = new MundoNaruro.UsuarioDAO();
                    ArrayList usuario = usuarioDAO.equipe();
                    foreach (EquipeBean item in usuario)
                    {
                        apelido.Text = item.Login;
                        NomeLabel.Text = item.Nome;
                        faceLink.PostBackUrl= item.Facebbok;
                        emailLabel.Text = item.Email;
                        frase.Text = item.Frase;
                        fotoEquipe.ImageUrl = item.Foto;
                %>
                <table>
                    <tr>
                        <td id="foto" class="style6">
                            <asp:Image AlternateText="Foto Não Disponível" ID="fotoEquipe" runat="server" Width="120"
                                Height="140" />
                        </td>
                        <td id="descricao" class="style6">
                            <asp:Label ID="NomeLabel" runat="server" Text="Nome integrante"></asp:Label><br />
                            <asp:Label ID="apelido" runat="server" Text="Apelido"></asp:Label>
                            <br />
                            <asp:Label ID="emailLabel" runat="server" Text="email"></asp:Label>
                            <br />
                            <asp:LinkButton ID="faceLink" runat="server">Facebook</asp:LinkButton>
                        </td>
                        <td id="valor" class="style6">
                            &quot;<asp:Label ID="frase" runat="server" Text="frase"></asp:Label>
                            &quot;
                        </td>
                    </tr>
                </table>
                
                <%} %>
            </div>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
