<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_16_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" onclick="btnMensaje_Click">

        <div class="row">
           
            <div style="height:200px; width:500px;">
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" Font-Size="35px"/>

            </div>
        <div style="height:200px; width:500px;">
            <asp:Button ID="btnMensaje" Text="Mostrar Mensaje" ToolTip="Dar click para mostrar mensaje" runat="server" OnClick="btnMensaje_Click" />
            </div>
        </div>

</asp:Content>
