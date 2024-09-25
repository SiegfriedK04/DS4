using System;



class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        int[] NoRepetir = aleatorio.Arreglo_NoRepetir(1, 100, 10);

        Console.WriteLine("Numeros generados:");
        foreach (int numero in NoRepetir)
        {
            Console.WriteLine(numero);
        }
        Console.ReadKey();
    }
}