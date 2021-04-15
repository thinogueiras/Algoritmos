using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_24
{
    class Algoritmo_24
    {
        //URI 1078
        static void Main(string[] args)
        {
            //Tabuada simples com estrutura repetitiva For

            int N = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= 10; i++)
            {
                int calculo = i * N;
                Console.WriteLine(i + " x " + N + " = " + calculo);
            }
            Console.ReadLine();               
            
        }
    }
}
