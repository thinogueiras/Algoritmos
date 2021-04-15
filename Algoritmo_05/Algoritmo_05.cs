using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_05
{
    class Algoritmo_05
    {
        //Trabalhando com While e IF

        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Digite o número entre 1 a 5: ");
            numero = int.Parse(Console.ReadLine());

           while (numero <= 5) 
            {
                if (numero == 2)
                {
                    numero++;
                    continue;
                }
                Console.Write("\nNúmero: " + numero + "\n");
                numero++;
            }
                    
            Console.ReadLine();
        }
    }
}
