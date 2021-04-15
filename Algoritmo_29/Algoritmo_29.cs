using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_29
{
    class Algoritmo_29
    {
        //URI 1080
        static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;

            for (int i = 1; i <= 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.Clear();
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}
