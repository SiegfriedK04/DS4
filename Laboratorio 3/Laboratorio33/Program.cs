using System;

namespace Laboratorio33
{
    class CalculosMatematicos
    {
        public static double calculoPerimetroRectangulo(double lado1, double lado2)
        {
            return 2 * (lado1 + lado2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado 1 del rectángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el lado 2 del rectángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            double perimetro = CalculosMatematicos.calculoPerimetroRectangulo(lado1, lado2);
            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        }
    }
}