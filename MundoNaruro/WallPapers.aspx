<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="WallPapers.aspx.cs" Inherits="MundoNaruro.WallPapers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <h1>
        <asp:Label ID="Label1" runat="server" Text="Papeis de Parede Mundo Naruto" Style="color: #FFFF00;
            text-decoration: underline"></asp:Label>
    </h1>
    <div style="overflow: scroll">
        <asp:Table ID="Table1" runat="server" Width="824px">
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle"><a href = "img/sasuke-naruto-shippuden.jpg"><asp:image imageurl="~/img/sasuke-naruto-shippuden.jpg" runat="server" ImageAlign="Left" Width="250" /></a></asp:TableCell>
                <asp:TableCell>
                    <a href="img/narutoshippuden007.jpg">
                        <asp:Image ID="Image1" ImageUrl="~/img/narutoshippuden007.jpg" runat="server" ImageAlign="Left"
                            Width="250" /></a></asp:TableCell>
                <asp:TableCell>
                    <a href="img/naruto914912108.jpg">
                        <asp:Image ID="Image4" ImageUrl="~/img/naruto914912108.jpg" runat="server" ImageAlign="Left"
                            Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/naruto_shippuden_wallpaper_by_uglycat_145.jpg">
                        <asp:Image ID="Image2" ImageUrl="~/img/naruto_shippuden_wallpaper_by_uglycat_145.jpg"
                            runat="server" ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/Naruto_Shippuden_66_1024x768.jpg">
                        <asp:Image ID="Image3" ImageUrl="~/img/Naruto_Shippuden_66_1024x768.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/Naruto_Shippuden_65_1024x768.jpg">
                        <asp:Image ID="Image5" ImageUrl="~/img/Naruto_Shippuden_65_1024x768.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/Naruto_Shippuden_64_1024x7682.jpg">
                        <asp:Image ID="Image6" ImageUrl="~/img/Naruto_Shippuden_64_1024x7682.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/naruto-shippuuden-t5-cartoon.jpg">
                        <asp:Image ID="Image7" ImageUrl="~/img/naruto-shippuuden-t5-cartoon.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/naruto-wallpapers-akatsuki-fight-big.jpg">
                        <asp:Image ID="Image8" ImageUrl="~/img/naruto-wallpapers-akatsuki-fight-big.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/Naruto_Shippuden_61_1024x768.jpg">
                        <asp:Image ID="Image9" ImageUrl="~/img/Naruto_Shippuden_61_1024x768.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/naruto plano de fundo.jpg">
                        <asp:Image ID="Image10" ImageUrl="~/img/naruto plano de fundo.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/Naruto_Shippuden_63_1024x768.jpg">
                        <asp:Image ID="Image11" ImageUrl="~/img/Naruto_Shippuden_63_1024x768.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>
