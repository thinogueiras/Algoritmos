using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_28
{
    class Algoritmo_28
    {
        //URI 1074
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                    Console.WriteLine("NULL");
                else if (numero % 2 == 0 && numero < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (numero % 2 != 0 && numero < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (numero % 2 != 0 && numero > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else 
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
            }
            Console.ReadLine();
        }
    }
}
