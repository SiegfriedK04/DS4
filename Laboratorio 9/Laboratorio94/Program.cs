using System;

class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        int Numero_Random = aleatorio.Gen_Numero(1, 100);
        Console.WriteLine($"Numero aleatorio entre 1 y 100: {Numero_Random}");

        int[] Arreglo_Random = aleatorio.Gen_Arreglo(1, 50, 5);
        Console.WriteLine("Arreglo de numeros aleatorios entre 1 y 50:");
        foreach (int numero in Arreglo_Random)
        {
            Console.WriteLine(numero);
        }
        Console.ReadKey();
    }
}