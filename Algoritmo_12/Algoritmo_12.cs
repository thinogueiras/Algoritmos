using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_12
{
    class Algoritmo_12
    {
        static void Main(string[] args)
        {
            int CodPeca1, CodPeca2, qtdePecas1, qtdePecas2;
            double ValorPeca1, ValorPeca2, totalPagar;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            CodPeca1 = int.Parse(vet[0]);
            qtdePecas1 = int.Parse(vet[1]);
            ValorPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            CodPeca2 = int.Parse(vet[0]);
            qtdePecas2 = int.Parse(vet[1]);
            ValorPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            totalPagar = (qtdePecas1 * ValorPeca1) + (qtdePecas2 * ValorPeca2);

            Console.Clear();

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
