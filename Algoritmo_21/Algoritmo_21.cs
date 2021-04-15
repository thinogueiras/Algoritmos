using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Algoritmo_21
{
    class Algoritmo_21
    {
        //URI 1037
        static void Main(string[] args)
        {  
            double valor;

            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Clear();

            if (valor >= 0 && valor <= 25)            
                Console.WriteLine("Intervalo [0,25]");
            else if (valor > 25 && valor <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (valor > 50 && valor <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (valor > 75 && valor <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");

            Console.ReadLine();
        }
    }
}
