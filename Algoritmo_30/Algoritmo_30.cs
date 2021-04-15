using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_30
{
    class Algoritmo_30
    {
        //URI 1160
        static void Main(string[] args)
        {
            int t, populacaoA, populacaoB, anos;

            double gA, gB, crescimentoA, crescimentoB;

            t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                populacaoA = int.Parse(vet[0]);
                populacaoB = int.Parse(vet[1]);
                gA = double.Parse(vet[2], CultureInfo.InvariantCulture);
                gB = double.Parse(vet[3], CultureInfo.InvariantCulture);

                crescimentoA = (int)(populacaoA * (gA / 100)) + populacaoA;
                crescimentoB = (int)(populacaoB * (gB / 100)) + populacaoB;

                Console.Clear();

                for (anos = 1; crescimentoA <= crescimentoB && anos <= 100; anos++)
                {
                    crescimentoA = (int)(crescimentoA * (gA / 100)) + crescimentoA;
                    crescimentoB = (int)(crescimentoB * (gB / 100)) + crescimentoB;
                }
                               
                if (anos <= 100)
                {
                    Console.WriteLine(anos + " anos.");
                }
                else
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }

                crescimentoA = 0.0;
                crescimentoB = 0.0;
                anos = 0;
            }            
            Console.ReadLine();
                                          
        }

    }
}

