<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="RecuperarSenha.aspx.cs" Inherits="MundoNaruro.RecuperarSenha" %>

<%@ Import Namespace="MundoNaruro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #corpo
        {
            height: 501px;
            width: 757px;
        }
        #Content2 body #corpo
        {
            background-attachment: fixed;
            background-color: #FFF;
            background-image: url(img/Naruto_Shippuden_64_1024x768.jpg);
            background-repeat: no-repeat;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <div id="corpo">
    <asp:Image ID="Image1" runat="server" Height="68px" src="/img/recuperarSenha.jpg" 
            Width="609px" ViewStateMode="Enabled" />
        <asp:Panel ID="panel1" runat="server" Height="470px" Width="717px">
            
            <br />
            </p>
            <p>
                &nbsp;</p>
            <asp:Panel ID="Panel2" runat="server" Style="background-position: right center; margin-right: 422px;
                position: relative; top: -13px; left: 3px; height: 296px; width: 707px; background-repeat: no-repeat;"
                BackImageUrl="~/img/SakuraEsqueceu.jpg">
                <form id="formEsqueceuSenha" method="post" action="#">
                <asp:Panel ID="Panel3" runat="server" Height="296px" HorizontalAlign="Left" Width="794px"
                    BorderStyle="None" Style="margin-right: 0px">
                    <br />
                    <br />
                    <asp:Panel ID="Panel5" runat="server" Height="100px" Width="341px" BorderStyle="None">
                        <asp:Label ID="Label2" runat="server" Font-Bold="False" Text="Informe seu nome de usuário"
                            ForeColor="Yellow"></asp:Label>
                        <br />
                        <asp:TextBox ID="usuarioTextBox" runat="server" Width="252px"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="False" Text="OU Informe seu e-mail"
                            ForeColor="Yellow"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:TextBox ID="emailTextBox" runat="server" Width="253px"></asp:TextBox>
                    </asp:Panel>
                    <br />
                    <asp:Image ID="captchImagem" runat="server" ImageUrl="~/util/CaptchaControl.aspx"
                        Width="145px" />
                    <asp:TextBox ID="captchTextBox" runat="server" Width="103px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="mensagem" runat="server" Text="mensagem teste!" 
                        ForeColor="#FFFFCC"></asp:Label>
                    <br />
                    <asp:Label ID="teste" runat="server" ForeColor="White" Text="teste 2"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ContinuarButton" runat="server" Text="Continuar" Width="80px" OnClick="ContinuarButton_Click" />
                    &nbsp;<asp:Button ID="CancelarButton" runat="server" Text="Cancelar" Width="80px" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;
                </asp:Panel>
                </form>
            </asp:Panel>
            <br />
        </asp:Panel>
    </div>
</asp:Content>
