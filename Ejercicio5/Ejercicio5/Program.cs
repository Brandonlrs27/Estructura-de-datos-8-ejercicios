using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros desea ingresar? ");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int may = 0;
            int pos = 0;
            for (int i = 0; i < num; i++)
            {
                Console.Write("numero {0}: ", (i + 1));
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > may)
                {
                    may = array[i];
                    pos = i + 1;
                }
            }
            Console.WriteLine("El numero mayor, que es el {0}, se encuentra en la posicion: {1}", may, pos);
            Console.ReadKey();
        }
    }
}
