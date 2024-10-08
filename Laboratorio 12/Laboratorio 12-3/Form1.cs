using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón "Calcular_SP" - Calcular Semiperímetro
        private void Calcular_SP_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los TextBox a variables numéricas
                double a = Convert.ToDouble(LA.Text); // Longitud A
                double b = Convert.ToDouble(LB.Text); // Longitud B
                double c = Convert.ToDouble(LC.Text); // Longitud C

                // Calcular el semiperímetro
                double semiperimetro = (a + b + c) / 2;

                // Mostrar el semiperímetro en el TextBox SP
                SP.Text = semiperimetro.ToString("F2"); // F2 para formatear a 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento para el botón "Calcular_Area" - Calcular Área usando la fórmula de Herón
        private void Calcular_Area_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los TextBox a variables numéricas
                double a = Convert.ToDouble(LA.Text); // Longitud A
                double b = Convert.ToDouble(LB.Text); // Longitud B
                double c = Convert.ToDouble(LC.Text); // Longitud C
                double semiperimetro = Convert.ToDouble(SP.Text); // Semiperímetro calculado previamente

                // Calcular el área usando la fórmula de Herón
                double area = Math.Sqrt(semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c));

                // Mostrar el área en el TextBox A
                A.Text = area.ToString("F2"); // F2 para formatear a 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento para el botón "Reset" - Limpiar todos los TextBox
        private void Reset_Click(object sender, EventArgs e)
        {
            LA.Clear();
            LB.Clear();
            LC.Clear();
            SP.Clear();
            A.Clear();
        }

        // Evento para el botón "Salir" - Cerrar la aplicación
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar la aplicación
        }

        private void LA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}