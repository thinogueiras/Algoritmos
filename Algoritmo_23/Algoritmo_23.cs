using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_23
{
    class Algoritmo_23
    {
        //URI 1113
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y)
                    Console.WriteLine("Crescente");
                else
                    Console.WriteLine("Decrescente");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            Console.ReadLine();
        }
    }
}
