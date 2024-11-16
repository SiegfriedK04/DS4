<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="Laboratorio_20_3.frmProductos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Gestión de Productos</h2>
            <div class="buttons">
                <asp:Button ID="btnNuevo" runat="server" Text="+" OnClick="btnNuevo_Click" />
                <asp:Button ID="btnGuardar" runat="server" Text="💾" OnClick="btnGuardar_Click" Enabled="false" />
                <asp:Button ID="btnCancelar" runat="server" Text="✖" OnClick="btnCancelar_Click" Enabled="false" />
                <asp:Button ID="btnEliminar" runat="server" Text="🗑" OnClick="btnEliminar_Click" Enabled="false" />
            </div>

            <div class="search-row">
                <label for="txtBuscarProductoId">Buscar por ID:</label>
                <asp:TextBox ID="txtBuscarProductoId" runat="server" placeholder="Ingrese ID"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="🔍" OnClick="btnBuscar_Click" />
            </div>

            <div class="form-row">
                <label for="txtProductoId">ID:</label>
                <asp:TextBox ID="txtProductoId" runat="server" Enabled="false" />
                <label for="txtProductoNombre">Nombre:</label>
                <asp:TextBox ID="txtProductoNombre" runat="server" />
            </div>

            <div class="form-row">
                <label for="txtProductoPrecio">Precio:</label>
                <asp:TextBox ID="txtProductoPrecio" runat="server" />
                <label for="txtProductoStock">Stock:</label>
                <asp:TextBox ID="txtProductoStock" runat="server" />
            </div>

            <div class="footer">
                <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
            </div>
        </div>
    </form>
</body>
</html>