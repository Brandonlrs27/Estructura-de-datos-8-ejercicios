using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[2];
            Console.WriteLine("Ingrese A, B y C:");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El numero menor entre {0}, {1} y {2} es: {3}");
       
        }
    }
}
