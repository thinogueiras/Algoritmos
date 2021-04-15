using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_06
{
    class Algoritmo_06
    {
        //Trabalhando com FOR, While e IF

        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de meses: ");
            int mes = int.Parse(Console.ReadLine());

            string nome_mes = "";

            while (mes < 1 || mes > 12)
            {
                Console.Write("\nNúmero do mês inválido" + "\n");
                Console.Write("\nDigite a quantidade de meses: ");
                mes = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            for (int I = 1; I <= mes; I++)
            {
                if (I == 1)
                {
                    nome_mes = "Janeiro";
                    Console.Write("\nMês: " + I + " " + nome_mes + " - Boas férias" + "\n");
                }
                else if (I == 2)
                {
                    nome_mes = "Fevereiro";
                    Console.Write("\nMês: " + I + " " + nome_mes + " - Bom carnaval" + "\n");
                }
                else if (I == 3)
                {
                    nome_mes = "Março";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 4)
                {
                    nome_mes = "Abril";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 5)
                {
                    nome_mes = "Maio";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 6)
                {
                    nome_mes = "Junho";
                    Console.Write("\nMês: " + I + " " + nome_mes + " -" + " Boas férias" + "\n");
                }
                else if (I == 7)
                {
                    nome_mes = "Julho";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 8)
                {
                    nome_mes = "Agosto";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 9)
                {
                    nome_mes = "Setembro";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 10)
                {
                    nome_mes = "Outubro";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 11)
                {
                    nome_mes = "Novembro";
                    Console.Write("\nMês: " + I + " " + nome_mes + "\n");
                }
                else if (I == 12)
                {
                    nome_mes = "Dezembro";
                    Console.Write("\nMês: " + I + " " + nome_mes + " -" + " Feliz Natal e Boas festas" + "\n");
                }
                else
                    Console.Write("\nMês: " + I + "\n");
            }
            Console.ReadKey();
        }
    }
}
