using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
                int numero1 = Convert.ToInt32(TextBox1.Text);
                int numero2 = Convert.ToInt32(TextBox2.Text);

                int suma = numero1 + numero2;

                LabelResultado.Text = "Resultado: " + suma.ToString();
            }
            catch (FormatException)
            {
                LabelResultado.Text = "Ingrese otro numero";
            }
        }
    }
}