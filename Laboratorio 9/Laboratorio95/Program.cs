using System;

class Aleatorios
{
    private Random random = new Random();

    public int[] ArregloNoRepetido(int min, int max, int cantidad)
    {
        HashSet<int> numeros = new HashSet<int>();
        while (numeros.Count < cantidad)
        {
            numeros.Add(random.Next(min, max));
        }
        return new List<int>(numeros).ToArray();
    }
}

class Program
{
    static void Main()
    {
        Aleatorios aleatorio = new Aleatorios();

        int[] NoRepetir = aleatorio.ArregloNoRepetido(1, 100, 10);

        Console.WriteLine("Numeros generados:");
        foreach (int numero in NoRepetir)
        {
            Console.WriteLine(numero);
        }
        Console.ReadKey();
    }
}