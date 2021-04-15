using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_08
{
    class Algoritmo_08
    {
        //Trabalhando com array de string e foreach

        static void Main(string[] args)
        {
            var texto = "";
            string[] Departamentos = { "TI", "RH", "CO", "OP", "FI" };

            foreach (var item in Departamentos)
            {
                texto += item + " ";
                //Console.Write(texto += item + ",");
                //Console.ReadLine();
            }
            Console.Write("Departamentos: " + texto);
            Console.ReadLine();
        }
    }
}
