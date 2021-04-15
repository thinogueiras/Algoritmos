using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_34
{
    class Algoritmo_34
    {
        //Exemplo Matriz simples

        static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] Z = Console.ReadLine().Split(' ');
            M = int.Parse(Z[0]);
            N = int.Parse(Z[1]);

            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
