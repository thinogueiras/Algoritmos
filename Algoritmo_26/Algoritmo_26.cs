using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_26
{
    class Algoritmo_26
    {
        static void Main(string[] args)
        {
            //A estrutura Do/While ou "Faça enquanto" executa o bloco de comandos pelo menos um vez, para no final verificar a condição

            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;

                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 's');            

            Console.ReadLine();

        }
    }
}
