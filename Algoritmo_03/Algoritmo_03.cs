using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_03
{
    class Algoritmo_03
    {
        //Trabalhando com cálculos simples

        static void Main(string[] args)
        {
            Decimal preco_gasolina = 0;
            Decimal valor_total_pagto = 0;
            Decimal qtde_litros = 0;

            Console.Write("Informe o preço do litro da gasolina: ");
            preco_gasolina = Decimal.Parse(Console.ReadLine());

            Console.Write("Informe o valor total pago: ");
            valor_total_pagto = Decimal.Parse(Console.ReadLine());

            qtde_litros = valor_total_pagto / preco_gasolina;

            Console.Write("\nVocê abasteceu: " + qtde_litros + " litros" + "\n");

            Console.ReadKey();
        }
    }
}
