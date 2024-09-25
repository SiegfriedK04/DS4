using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el lado 1: ");
        int lado1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el lado 2: ");
        int lado2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el lado 3: ");
        int lado3 = Convert.ToInt32(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados no forman un triángulo válido.");
        }
    }
}