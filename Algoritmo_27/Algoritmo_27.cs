using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_27
{
    class Algoritmo_27
    {
        //URI 1040
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            double media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            Console.Clear();

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                if (media == 4.85)
                {
                    media = 4.8;
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }
                else
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Clear();
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                double mediaExame = (media + exame) / 2;
                if (mediaExame >= 5.0)
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaExame.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadLine();
        }
    }
}
