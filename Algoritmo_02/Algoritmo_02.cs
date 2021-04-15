using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_02
{
    class Algoritmo_02
    {
        //Trabalhando com variáveis e cálculos simples

        static void Main(string[] args)
        {
            string nome = "";
            int qtde = 0;
            double preco = 0;
            double percdesc = 0;
            double totaldesc = 0;
            double totalbruto = 0;

            Console.Write("Informe o nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("\nInforme a quantidade: ");
            qtde = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o preço do produto: ");
            preco = Double.Parse(Console.ReadLine());

            Console.Write("\nInforme o percentual de desconto: ");
            percdesc = Double.Parse(Console.ReadLine());

            totalbruto = qtde * preco;
            totaldesc = totalbruto - ((percdesc / 100)) * totalbruto;

            Console.Write("\nTotal com desconto é: " + totaldesc);

            Console.ReadKey();
        }
    }
}
