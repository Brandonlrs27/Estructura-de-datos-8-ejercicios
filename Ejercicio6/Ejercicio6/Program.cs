using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Escriba su nombre completo: ");
            string fr = Console.ReadLine();
            string[] palabras = fr.Split(' ');
            for (int i =1; i<palabras.Length; i++)
            {
                if ( palabras[i].Length > palabras[i - 1].Length)
                    {
                    Console.WriteLine(i+1);
                    goto x;
                    }
                else { Console.WriteLine(" Error");}              
            }
            x:
            Console.ReadKey();
        }
    }
}
