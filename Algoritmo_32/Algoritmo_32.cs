using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_32
{
    class Algoritmo_32
    {
        //Trabalhando com 3 vetores, somando os valores do A com B e imprimindo no vetor C
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {                
                A[i] = int.Parse(S[i]);
            }

            S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {                
                B[i] = int.Parse(S[i]);
            }

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i].ToString() + ' ');
            }

            Console.ReadLine();

            

        }
    }
}
