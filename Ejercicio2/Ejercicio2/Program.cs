using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] Minombre = { "Lares", "Dominguez", "Brandon" };
                foreach (string i in Minombre)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
                for (int i = 2; i >= 0; i--)
                {
                    Console.Write("{0} ", Minombre[i]);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
