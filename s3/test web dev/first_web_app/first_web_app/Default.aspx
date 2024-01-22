<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="first_web_app._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1><%: Title %>.</h1>
        <h2>Wingtip Toys can help you find the perfect gifts.</h2>
        <p class="lead">We're all about transportation toys. You can order 
                any of our toys today. Each toy listing has detailed 
                information to help you choose the right toy.<asp:RadioButton ID="RadioButton1" runat="server" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
