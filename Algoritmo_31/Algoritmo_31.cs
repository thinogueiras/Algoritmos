using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_31
{
    class Algoritmo_31
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
            double soma = 0;

            Console.WriteLine();

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += vet[i];
            }            

            double media = soma / N;

            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");                
            }
            Console.WriteLine();
            Console.WriteLine("\nSoma: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nMedia: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
