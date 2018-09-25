using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0;
            int pos = 0;
            Console.Write("Cuantos numeros desea ingresar? ");
            int x = int.Parse(Console.ReadLine());
            int[] Array = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("Numero {0}: ", (i + 1));
                Array[i] = int.Parse(Console.ReadLine());
                if (Array[i] > mayor || Array[i] == mayor)
                {
                    mayor = Array[i];
                    pos = i + 1;
                }
            }
            Console.WriteLine("El numero mayor, que es el {0}, se encuentra en la posicion: {1}",mayor, pos);
            Console.ReadKey();
        }
    }
}
