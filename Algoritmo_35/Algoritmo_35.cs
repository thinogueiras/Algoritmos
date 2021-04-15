using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_35
{
    class Algoritmo_35
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int J = 0; J < N; J++)
                {
                    A[i, J] = int.Parse(s[J]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }

            Console.WriteLine();

            int cont = 0;

            for (int i = 0; i < N; i++)
            {
                for (int J = 0; J < N; J++)
                {
                    if (A[i, J] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS: " + cont);

            Console.ReadLine();
        }
    }
}
