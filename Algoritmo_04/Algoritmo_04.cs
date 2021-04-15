using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_04
{
    class Algoritmo_04
    {
        //Trabalhando com estrutura condicional IF-ElSE

        static void Main(string[] args)
        {
            int idade = 0;
            string sexo = "";

            Console.Write("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o seu sexo (M ou F ?): ");
            sexo = Console.ReadLine();

            if ((sexo != "F" && sexo != "M") && idade >= 0)
                if (idade == 1)
                    Console.Write("\nO indivíduo tem " + idade + " ano" + ", " + "o sexo não foi informado ou é indefinido" + "\n");
                else
                    Console.Write("\nO indivíduo tem " + idade + " anos" + ", " + "o sexo não foi informado ou é indefinido" + "\n");

            else if ((sexo != "F" && sexo != "M") && idade < 0)
                Console.Write("\nIdade inválida" + ", " + "Sexo indefinido" + "\n");

            else if (idade <= 2 && sexo == "M")
                if (idade < 0)
                    Console.Write("\nIdade inválida " + ", " + "sexo: " + sexo);
                else if (idade == 1)
                    Console.Write("\nÉ um bebê de " + idade + " ano" + " do sexo masculino" + "\n");
                else
                    Console.Write("\nÉ um bebê de " + idade + " anos" + " do sexo masculino" + "\n");

            else if (idade <= 2 && sexo == "F")
                if (idade < 0)
                    Console.Write("\nIdade inválida " + ", " + "sexo: " + sexo);
                else if (idade == 1)
                    Console.Write("\nÉ um bebê de " + idade + " ano" + " do sexo feminino" + "\n");
                else
                    Console.Write("\nÉ um bebê de " + idade + " anos" + " do sexo feminino" + "\n");            

            else if (idade > 2 && sexo == "M")
                Console.Write("\nNão é mais um bebê e é do sexo masculino" + "\n");
            else
                Console.Write("\nNão é mais um bebê e é do sexo feminino" + "\n");

            Console.ReadLine();
        }
    }
}
