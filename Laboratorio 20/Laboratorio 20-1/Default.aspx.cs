using System;
namespace Laboratorio201
{
    public partial class TablaMultiplicar : System.Web.UI.Page
    {
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            ltResultado.Text = GenerarTabla(txtNumero.Text);
        }

        private string GenerarTabla(string input)
        {
            if (int.TryParse(input, out int numero))
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<table border='1'>");
                for (int i = 1; i <= 25; i++)
                {
                    sb.AppendFormat("<tr><td>{0} x {1} = {2}</td></tr>", numero, i, numero * i);
                }
                sb.Append("</table>");
                return sb.ToString();
            }
            else
            {
                return "Por favor, ingrese un número válido.";
            }
        }
    }
}