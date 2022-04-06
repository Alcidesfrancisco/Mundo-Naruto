<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Intro.aspx.cs" Inherits="MundoNaruro.Intro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" method="post" runat="server" 
    style="background-position: center center; background-image: url('/img/naruto-wallpapers-akatsuki-fight-big.jpg')">
    <div align="center" style="border-style: ridge">
        <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0"
            width="800" height="586">
            <param name="movie" value="swf/mundoNaruto.swf" />
            <param name="quality" value="high" />
            <embed src="swf/mundoNaruto.swf" quality="high" pluginspage="http://www.macromedia.com/go/getflashplayer"
                type="application/x-shockwave-flash" width="800" height="586"></embed>
        </object>
        <h1 style="width: 797px; color: #FF6600; margin-top: 0px">
            <asp:LinkButton ID="repetirLinkButton" runat="server" PostBackUrl="~/Intro.aspx"
                Style="color: #FF6600">Repetir</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="avançarLinkButton" runat="server" PostBackUrl="~/index.aspx"
                Width="49px" Style="color: #FF6600">Avançar</asp:LinkButton>
        </h1>
    </div>
    </form>
</body>
</html>
