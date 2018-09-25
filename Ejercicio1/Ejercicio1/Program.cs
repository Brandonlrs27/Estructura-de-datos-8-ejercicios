using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cuantos numeros desea ingresar? ");
                int cant = int.Parse(Console.ReadLine());
                int[] Array = new int[cant];
                for (int i = 0; i < cant; i++)
                {
                    Console.Write("Numero {0}: ", (i + 1));
                    Array[i] = int.Parse(Console.ReadLine());
                }              
                Console.WriteLine("El numero menor es {0} y el numero mayor es {1}", Array.Min(), Array.Max());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
