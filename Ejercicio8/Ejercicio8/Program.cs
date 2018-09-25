using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string pali;
            string caracter;
            string inv;
            inv = "";
            do
            {
                Console.Write("Introduce un Palindrome (5 digitos): ");
                pali = Console.ReadLine();
                i = pali.Length;
                if (i != 5)
                {
                    Console.WriteLine("No cumple con los requisitos");
                }
            } while (i != 5);
            for (int k = 4; k >= 0; k--)
            {
                caracter = pali.Substring(k, 1);
                inv = inv + caracter; ;
            }
            if (pali == inv)
            {
                Console.WriteLine("Si es un Palindrome");
            }
            else
            {
                Console.WriteLine("No es un Palindrome");
            }
            Console.ReadKey();
        }
    }
}
