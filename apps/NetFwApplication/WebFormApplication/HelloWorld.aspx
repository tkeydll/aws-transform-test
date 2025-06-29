<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebFormApplication.HelloWorld" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Hello World</h2>
    <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label><br />
    <asp:TextBox ID="TextBoxName" runat="server" placeholder="–¼‘O‚ð“ü—Í‚µ‚Ä‚­‚¾‚³‚¢"></asp:TextBox>
    <asp:Button ID="ButtonGreet" runat="server" Text="‚ ‚¢‚³‚Â" OnClick="ButtonGreet_Click" />
</asp:Content>
