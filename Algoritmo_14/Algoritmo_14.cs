using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_14
{
    class Algoritmo_14
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int vlr1 = int.Parse(vet[0]);
            int vlr2 = int.Parse(vet[1]);
            int vlr3 = int.Parse(vet[2]);

            //Verifica qual é o maior entre dois valores
            int MaiorAB = (vlr1 + vlr2 + (Math.Abs(vlr1 - vlr2))) / 2;

            if (MaiorAB > vlr3)
            {
                Console.Clear();
                Console.WriteLine(MaiorAB + " é o maior");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(vlr3 + " é o maior");
            }
            Console.ReadLine();
        }
    }
}
