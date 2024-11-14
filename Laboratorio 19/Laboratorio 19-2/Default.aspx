<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_19_2._Default" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="myLabel" runat="server" Text="Esperando respuesta del API..." /><br /><br />
    
    <asp:Button ID="btnGetAllValues" runat="server" Text="Obtener todos los valores" OnClick="btnGetAllValues_Click" /><br /><br />
</asp:Content>