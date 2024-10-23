<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_4.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suma de Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <h2>Suma de dos Números</h2>
            <asp:TextBox ID="TextBox1" runat="server" Width="100px" placeholder="Número 1"></asp:TextBox>
            <br /><br />
            <asp:TextBox ID="TextBox2" runat="server" Width="100px" placeholder="Número 2"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="LabelResultado" runat="server" Text="Resultado: " Font-Bold="True" />
        </div>
    </form>
</body>
</html>