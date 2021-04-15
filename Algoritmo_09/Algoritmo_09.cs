﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Algoritmo_09
{
    class Algoritmo_09
    {
        //Trabalhando com vetores de string, int e double

        static void Main(string[] args)
        {
            int N;
            Console.Write("Digite a quantidade de linhas dos vetores: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            //Leitura dos dados para armazenar nos vetores declarados acima
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //Cálculo da altura média das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("\nAltura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Porcentagem de pessoas abaixo de 16 anos
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("\nPessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + " %");
            Console.ReadLine();
        }
    }
}
