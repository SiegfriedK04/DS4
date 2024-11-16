using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio_20_3
{
    public partial class frmProductos : Page
    {
        private readonly string cadenaConexion = @"Server=.\sqlexpress;Database=productos;Trusted_Connection=True;";
        private bool esNuevoRegistro;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConfigurarInterfaz();
            }
        }

        private void ConfigurarInterfaz()
        {
            HabilitarBotones(true, false, false, false);
            LimpiarCampos();
            BloquearCampos(false);
        }

        private void HabilitarBotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
        }

        private void BloquearCampos(bool habilitar)
        {
            txtProductoId.Enabled = false;
            txtProductoNombre.Enabled = habilitar;
            txtProductoPrecio.Enabled = habilitar;
            txtProductoStock.Enabled = habilitar;
        }

        private void LimpiarCampos()
        {
            txtProductoId.Text = "";
            txtProductoNombre.Text = "";
            txtProductoPrecio.Text = "";
            txtProductoStock.Text = "";
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevoRegistro = true;
            HabilitarBotones(false, true, true, false);
            BloquearCampos(true);
            LimpiarCampos();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = esNuevoRegistro
                    ? "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) VALUES (@nombre, @precio, @stock)"
                    : "UPDATE LAPTOPS SET NOMBRE=@nombre, PRECIO=@precio, STOCK=@stock WHERE ID=@id";

                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    if (!esNuevoRegistro)
                    {
                        comando.Parameters.AddWithValue("@id", txtProductoId.Text);
                    }
                    comando.Parameters.AddWithValue("@nombre", txtProductoNombre.Text);
                    comando.Parameters.AddWithValue("@precio", txtProductoPrecio.Text);
                    comando.Parameters.AddWithValue("@stock", txtProductoStock.Text);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                    Response.Write("<script>alert('Operación exitosa');</script>");
                }
            }
            ConfigurarInterfaz();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigurarInterfaz();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = "DELETE FROM LAPTOPS WHERE ID=@id";
                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", txtProductoId.Text);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    Response.Write("<script>alert('Registro eliminado');</script>");
                }
            }
            ConfigurarInterfaz();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consultaSql = "SELECT * FROM LAPTOPS WHERE ID=@id";
                using (SqlCommand comando = new SqlCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", txtBuscarProductoId.Text);
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        txtProductoId.Text = lector["ID"].ToString();
                        txtProductoNombre.Text = lector["NOMBRE"].ToString();
                        txtProductoPrecio.Text = lector["PRECIO"].ToString();
                        txtProductoStock.Text = lector["STOCK"].ToString();

                        HabilitarBotones(false, true, true, true);
                        BloquearCampos(true);
                        esNuevoRegistro = false;
                    }
                    else
                    {
                        Response.Write("<script>alert('Producto no encontrado');</script>");
                    }
                }
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}