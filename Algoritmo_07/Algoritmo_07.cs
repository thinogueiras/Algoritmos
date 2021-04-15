using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_07
{
    class Algoritmo_07
    {
        //Trabalhando com FOR e cálculos simples

        static void Main(string[] args)
        {
            int num = 0;
            int soma = 0;
            int vezes = 0;
            double media = 0.0;

            Console.Write("Repeticoes: ");
            vezes = int.Parse(Console.ReadLine());

            Console.Write("\n");

            for (int n = 1; n <= vezes; n++)
            {
                Console.Write("Digite um numero inteiro: ");
                num = int.Parse(Console.ReadLine());
                soma += num;
            } 

            media = Convert.ToDouble(soma) / Convert.ToDouble(vezes);

            Console.WriteLine("\nSoma: " + soma);
            Console.WriteLine("Media: " + media);
            Console.ReadKey();
        }
    }
}
