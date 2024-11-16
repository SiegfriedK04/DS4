using System;
using System.Text;

namespace Laboratorio202
{
    public partial class MatrizNxN : System.Web.UI.Page
    {
        protected void btnCrearMatriz_Click(object sender, EventArgs e)
        {
            litResultadoMatriz.Text = CrearMatrizHtml(txtTamañoMatriz.Text);
        }

        private string CrearMatrizHtml(string inputTexto)
        {
            if (int.TryParse(inputTexto, out int dimension) && dimension > 0)
            {
                StringBuilder matrizBuilder = new StringBuilder();
                matrizBuilder.Append("<table border='1'>");

                for (int fila = 0; fila < dimension; fila++)
                {
                    matrizBuilder.Append("<tr>");
                    for (int columna = 0; columna < dimension; columna++)
                    {
                        matrizBuilder.AppendFormat("<td>{0}</td>", columna == dimension - fila - 1 ? 1 : 0);
                    }
                    matrizBuilder.Append("</tr>");
                }

                matrizBuilder.Append("</table>");
                return matrizBuilder.ToString();
            }
            else
            {
                return "Ingrese una dimensión válida.";
            }
        }
    }
}