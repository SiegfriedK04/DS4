using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón "Compilar"
        private void Compilar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los TextBox a variables numéricas
                double Nota1 = Convert.ToDouble(Valor1.Text); // Nota 1
                double Nota2 = Convert.ToDouble(Valor2.Text); // Nota 2
                double Nota3 = Convert.ToDouble(Valor3.Text); // Nota 3

                // Calcular el promedio
                double Promedio = (Nota1 + Nota2 + Nota3) / 3;

                // Mostrar el resultado en el TextBox de promedio (ValorFinal)
                ValorFinal.Text = Promedio.ToString("F2"); // F2 formatea el número con 2 decimales
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

        // Evento para el botón "Reset"
        private void Reset_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            Valor1.Clear();
            Valor2.Clear();
            Valor3.Clear();
            ValorFinal.Clear();
        }

        // Evento para el botón "Salir"
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar la aplicación
        }
    }
}