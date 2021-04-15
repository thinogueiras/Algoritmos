using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_22
{
    class Algoritmo_22
    {
        //URI 1038
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int item = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double soma, preco;

            Console.Clear();

            switch (item)
            {
                case 1:
                    preco = 4.00;
                    soma = preco * quantidade;
                    Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    preco = 4.50;
                    soma = preco * quantidade;
                    Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    preco = 5.00;
                    soma = preco * quantidade;
                    Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    preco = 2.00;
                    soma = preco * quantidade;
                    Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    preco = 1.50;
                    soma = preco * quantidade;
                    Console.WriteLine("Total: " + "R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            Console.ReadLine();
        }
    }
}
