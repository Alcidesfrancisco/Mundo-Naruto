<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FaArts.aspx.cs" Inherits="MundoNaruro.FaArts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
    <br />
    <br />
    <br />
    <br />
    <h1>
        <asp:Label ID="Label1" runat="server" Text="Fã Arts  Mundo Naruto" Style="color: #FFFF00;
            text-decoration: underline"></asp:Label>
    </h1>
    <div style="overflow: scroll">
        <asp:Table ID="Table1" runat="server" Width="824px">
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle"><a href = "img/FaArts/697016-20120531021610.jpg"><asp:image ID="Image1" imageurl="~/img/FaArts/697016-20120531021610.jpg" runat="server" ImageAlign="Left" Width="250" /></a></asp:TableCell>
                <asp:TableCell>
                    <a href="img/FaArts/802015-20120601224050.jpg">
                        <asp:Image ID="Image20" ImageUrl="~/img/FaArts/802015-20120601224050.jpg" runat="server" ImageAlign="Left"
                            Width="250" /></a></asp:TableCell>
                <asp:TableCell>
                    <a href="img/FaArts/802015-20120601224937.jpg">
                        <asp:Image ID="Image40" ImageUrl="~/img/FaArts/802015-20120601224937.jpg" runat="server" ImageAlign="Left"
                            Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/FaArts/806206-20120603151328.jpg">
                        <asp:Image ID="Image30" ImageUrl="~/img/FaArts/806206-20120603151328.jpg"
                            runat="server" ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/FaArts/812682-20120603203302.jpg">
                        <asp:Image ID="Image401" ImageUrl="~/img/FaArts/812682-20120603203302.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/FaArts/837230-20120603142425.jpg">
                        <asp:Image ID="Image50" ImageUrl="~/img/FaArts/837230-20120603142425.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell VerticalAlign="Middle">
                    <a href="img/FaArts/832934-20120603144701.jpg">
                        <asp:Image ID="Image60" ImageUrl="~/img/FaArts/832934-20120603144701.jpg" runat="server"
                            ImageAlign="Middle" Width="250" /></a></asp:TableCell>
                
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>
