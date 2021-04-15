using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_01
{
    class Algoritmo_01
    {
        //Trabalhando com variáveis e cálculos simples

        static void Main(string[] args)
        {
            string marca = "";
            string modelo = "";
            double vlrcusto = 0;
            double vlrfinal = 0;
            double vlrcomissao = 0;
            double vlrimposto = 0;

            Console.Write("Informe a marca: ");
            marca = Console.ReadLine();

            Console.Write("Informe o modelo do veículo: ");
            modelo = Console.ReadLine();

            Console.Write("Informe o preço de custo: ");
            vlrcusto = double.Parse(Console.ReadLine());

            vlrimposto = vlrcusto * 0.45;
            vlrcomissao = vlrcusto * 0.28;
            vlrfinal = vlrcusto + vlrcomissao + vlrimposto;

            Console.Write("\n");
            Console.Write("Resultado\n");
            Console.Write("Marca: " + marca + "\n");
            Console.Write("Modelo: " + modelo + "\n");
            Console.Write("Valor final: " + "R$ " + vlrfinal + "\n");

            Console.ReadKey();
        }
    }
}
