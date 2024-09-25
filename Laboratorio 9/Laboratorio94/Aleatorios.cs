using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio94
{
    internal class Aleatorios
    {
    }
}

class Aleatorios
{
    private Random random = new Random();

    public int Gen_Numero(int min, int max)
    {
        return random.Next(min, max);
    }

    public int[] Gen_Arreglo(int min, int max, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(min, max);
        }
        return arreglo;
    }
}
