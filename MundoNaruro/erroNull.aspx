<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="erroNull.aspx.cs" Inherits="MundoNaruro.erroNull" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="erroBanco" align="center" style="height: 341px; font-family: Tahoma; font-size: x-large; font-weight: bold; font-style: normal; font-variant: normal; text-transform: capitalize; color: #FFFF00; text-decoration: blink;"
        
        style="background-image: url('http://localhost:21517/img/NarutoTriste.JPG'); height: 320px; background-repeat: no-repeat;" >
    <br /><br /><br /><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Não existem itens nesta categoria de produtos!!"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Selecione outra categoria!"></asp:Label>
</div>
</asp:Content>
