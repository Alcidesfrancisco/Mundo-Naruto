<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcessoMundo.aspx.cs" Inherits="MundoNaruro.AcessoMundo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('http://localhost:21517/img/folha.jpg')">
    <form runat="server" method="post" 
    style="background-image: url(''); background-repeat: repeat; margin-top: 0px;">
    <div align="center">
        <asp:Image ID="fundoLogin" runat="server" ImageUrl="~/img/narutoLogin.png" Height="690px"/></div>
    <div style="margin: 0px 71px 8px 100px; position: absolute; top: 314px; left: 434px;"
        align="center">
        <br />
        <asp:LinkButton ID="cadastroLinkButton" runat="server" PostBackUrl="~/Cadastro.aspx">Ainda não tem Cadastro? Clique aqui!</asp:LinkButton>
        <br />
        <asp:Label ID="loginLabel" runat="server" Text="Login" Style="font-weight: 700; color: #FF6600"></asp:Label>
        <asp:TextBox ID="loginTextBox" runat="server" Width="200px" Font-Bold="True" ForeColor="#FF6600"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="senhaLabel" runat="server" Text="Senha:" Style="font-weight: 700;
            color: #FF6600"></asp:Label>
        <asp:TextBox ID="senhaTextBox" runat="server" Width="200px" Font-Bold="True" 
            ForeColor="#FF6600" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="mensagemLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="acessarButton" runat="server" Text="Acessar" OnClick="acessarButton_Click" />&nbsp;&nbsp;
        <asp:LinkButton ID="esqueciLinkButton" runat="server" PostBackUrl="~/RecuperarSenha.aspx">Esqueceu a Senha?</asp:LinkButton>
    </div>
    </form>
</body>
</html>
