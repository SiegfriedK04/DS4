<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_19_3._Default" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="myLabel" runat="server" Text="Esperando respuesta del API..." /><br /><br />
    
    <asp:Button ID="btnGetValueById" runat="server" Text="Obtener valor con ID #2" OnClick="btnGetValueById_Click" /><br /><br />
</asp:Content>