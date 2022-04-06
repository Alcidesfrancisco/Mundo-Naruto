<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="Cadastro.aspx.cs" Inherits="MundoNaruro.Cadastro" %>

<%@ Import Namespace="MundoNaruro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #corpo
        {
            height: 644px;
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
    <div id="corpo">
        
            <asp:Panel ID="panel1" runat="server" Height="531px">
                
                    <br /><br /><br /><br />
                
                    <img src="img/cadastro2.jpg" alt="Cadastro de usuários" style="width: 607px" /><br />
                <asp:Panel ID="Panel2" runat="server" Style="margin-right: 422px; position: relative;
                    top: 4px; left: 237px; height: 390px; width: 358px;" BackImageUrl="~/img/Naruto_Shippuden_65_1024x768.jpg"
                    BorderStyle="Outset ">
                    <asp:Label ID="Label2" runat="server" Text="Nome:" CssClass="style1" Style="color: #FFFFFF"></asp:Label>
                    <br />
                    <asp:TextBox ID="nomeTextBox" runat="server" Width="300px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Email:" Style="color: #FFFFFF"></asp:Label><br />
                    <asp:TextBox ID="emailTextBox" runat="server" Width="300px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Data de Nascimento" Style="color: #FFFFFF"></asp:Label>
                    <br />
                    <asp:TextBox ID="dataTextBox" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Login:" Style="color: #FFFFFF"></asp:Label>
                    <br />
                    <asp:TextBox ID="loginTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Senha:" Style="color: #FFFFFF"></asp:Label>
                    <br />
                    <asp:TextBox ID="senhaTextBox" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Confirme a senha:" Style="color: #FFFFFF"></asp:Label>
                    <br />
                    <asp:TextBox ID="confirmaSenhaTextBox" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="mensagem" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Image ID="captchImagem" runat="server" ImageUrl="~/util/CaptchaControl.aspx" />
                    <asp:TextBox ID="captchTextBox" runat="server" Width="100px"></asp:TextBox>
                    <br />
                    <asp:CheckBox ID="newsCheckBox" runat="server" style="color: #FFFF00" Text="Receber NewsLetter" />
                    <br />
                    <asp:Button ID="enviar" runat="server" OnClick="enviar_Click" Text="Enviar" />
                    &nbsp;<asp:Button ID="limparButton" runat="server" onclick="limparButton_Click" 
                        Text="Limpar" />
                    <br />
                </asp:Panel>
               
                <br />
            </asp:Panel>
       
    </div>
</asp:Content>
