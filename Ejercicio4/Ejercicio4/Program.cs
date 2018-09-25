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
            int menor = 0;
            Console.WriteLine("Ingrese A, B y C:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if (A < B && A < C)
            {
                menor = A;
            }
            else if (B < A && B < C)
            {
                menor = B;
            }
            else if (C < B && C < A)
            {
                menor = C;
            }
            Console.WriteLine("El numero menor entre {0}, {1} y {2} es: {3}",A,B,C,menor);
            Console.ReadKey();
        }
    }
}
