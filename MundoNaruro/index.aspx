<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MundoNaruro.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
    {
        font-size: xx-large;
        color: #FFFF00;
        width: 684px;
        margin-left: 148px;
        margin-top: 127px;
            font-family: "Courier New", Courier, monospace;
            height: 366px;
        }
        .style5
        {
            color: #FFFFFF;
        }
    </style>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="500px" 
    style="margin-bottom: 130px">
        <div class="style4">
            <strong>BEM VINDOS AO MUNDO NARUTO!!
            <br />
            VOCÊ ESTÁ AGORA NUM UNIVERSO TOTALMENTE DIRECIONADO PARA O QUE VOCÊ QUE VER E
            SABER SOBRE NARUTO E SUA LINDA HISTÓRIA!
            <br />
            MOSTRE O SEU JEITO NINJA DE SER VOCÊ TAMBÉM, CADASTRE-SE <span class="style5">
            <a href="Cadastro.aspx">AQUI</a></span></strong><br /> 
            </div>
     </asp:Panel>
</asp:Content>
