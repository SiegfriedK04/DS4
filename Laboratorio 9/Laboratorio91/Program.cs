using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
        string formaPago = Console.ReadLine().ToLower();

        if (formaPago == "tarjeta")
        {
            Console.Write("Ingrese su número de cuenta (16 dígitos): ");
            string numeroCuenta = Console.ReadLine();

            if (numeroCuenta.Length == 16)
            {
                Console.WriteLine("Pago realizado con tarjeta.");
            }
            else
            {
                Console.WriteLine("Número de cuenta inválido.");
            }
        }
        else if (formaPago == "efectivo")
        {
            Console.WriteLine("Pago realizado en efectivo.");
        }
        else
        {
            Console.WriteLine("Forma de pago inválida.");
        }
    }
}