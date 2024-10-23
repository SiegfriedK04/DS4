<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_3.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Laboratorio 15</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="300px" placeholder="Introduzca un texto"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Enviar Saludo!" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
