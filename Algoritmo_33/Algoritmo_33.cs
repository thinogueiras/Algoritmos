using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_33
{
    class Algoritmo_33
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomeProduto = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            int lucroAbaixoDez = 0, lucroEnteDezEVinte = 0, lucroAcimaVinte = 0;
            double valorTotalCompra = 0.0, valorTotalVenda = 0.0, lucroTotal = 0.0;

            for (int i = 0; i < N; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                nomeProduto[i] = S[0];
                precoCompra[i] = double.Parse(S[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(S[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                valorTotalCompra += precoCompra[i];
                valorTotalVenda += precoVenda[i];

                if (precoVenda[i] * 100.0 / precoCompra[i] < 110)                
                    lucroAbaixoDez++;
                
                if (precoVenda[i] * 100.0 / precoCompra[i] >= 110 && precoVenda[i] * 100.0 / precoCompra[i] <= 120)                
                    lucroEnteDezEVinte++;
                
                if (precoVenda[i] * 100.0 / precoCompra[i] > 120)                
                    lucroAcimaVinte++;                
            }

            lucroTotal = valorTotalVenda - valorTotalCompra;

            Console.Clear();

            Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixoDez);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEnteDezEVinte);
            Console.WriteLine("Lucro acima de 20%: " + lucroAcimaVinte);
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
