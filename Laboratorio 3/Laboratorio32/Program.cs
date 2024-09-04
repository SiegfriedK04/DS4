﻿using System;

namespace Laboratorio32
{
    class CalculosMatematicos
    {
        public static double calculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = CalculosMatematicos.calculoArea(radio);
            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}