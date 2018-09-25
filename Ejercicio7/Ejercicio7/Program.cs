using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Cantidad de numeros a ordenar: ");
            int nums = int.Parse(Console.ReadLine());
            int[] array = new int[nums];
            Random Ran1 = new Random();
            Console.WriteLine("Numeros no ordenados:");
            for (int i = 0; i < nums; i++)
            {
                array[i] = Ran1.Next(1, 101);
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine("\n\nNumeros ordenados:");
            Array.Sort(array);
            for (int i = 0; i < nums; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
