using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_18
{
    class Algoritmo_18
    {
        //URI 1061

        //Exemplo entrada de dados

        //Dia 5
        //08 : 12 : 23
        //Dia 9
        //06 : 13 : 23

        //W dia(s)
        //X hora(s)
        //Y minuto(s)
        //Z segundo(s)

        static void Main(string[] args)
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;
            string s;

            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;
            duracao = fim - inicio;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.Clear();

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");

            Console.ReadLine();
        }
    }
}
