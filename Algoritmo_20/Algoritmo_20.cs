using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_20
{
    class Algoritmo_20
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int D = int.Parse(vet[3]);

            Console.Clear();

            int soma1 = C + D;
            int soma2 = A + B;

            int verificaNumPar = A % 2;            

            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && verificaNumPar == 0)
                Console.WriteLine("Valores aceitos");
		    else
			    Console.WriteLine("Valores nao aceitos");

            Console.ReadLine();
        }
    }
}
