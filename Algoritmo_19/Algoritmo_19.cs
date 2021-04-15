using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_19
{
    class Algoritmo_19
    {
        static void Main(string[] args)
        {
            //Um valor inteiro ir para variável do tipo double pode, pois não há risco de perda de informação
            //Um valor double, ir para uma variável do tipo int NÃO pode, pois há risco de perda de informação

            int a, b, resultadoInteiro;
            double c, resultadoDouble;

            a = 5;
            b = 2;
            c = 5.0;

            //Exemplo Casting (int)			
            resultadoInteiro = (int)c;

            //Exemplo Casting (double)			
            resultadoDouble = (double)a / b;

            Console.WriteLine(resultadoInteiro);
            Console.WriteLine(resultadoDouble);
            Console.ReadLine();
        }
    }
}
