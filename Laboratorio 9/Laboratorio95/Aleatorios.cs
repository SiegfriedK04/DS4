using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio95
{
    internal class Aleatorios
    {
    }
}

class Aleatorios
{
    private Random random = new Random();

    public int[] Arreglo_NoRepetir(int min, int max, int cantidad)
    {
        HashSet<int> numeros = new HashSet<int>();
        while (numeros.Count < cantidad)
        {
            numeros.Add(random.Next(min, max));
        }
        return new List<int>(numeros).ToArray();
    }
}