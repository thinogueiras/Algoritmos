using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Algoritmo_36
{
    class Algoritmo_36
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro que representará as linhas e colunas de uma matriz: ");
            int N = int.Parse(Console.ReadLine());

            double[,] A = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            Console.WriteLine();
            Console.Write("Digite a quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            double somaPositivos = 0.0;
            double somaNegativos = 0.0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)                    
                        somaNegativos += A[i, j];                    
                    if (A[i, j] > 0)
                        somaPositivos += A[i, j];                    
                }
            }

            Console.WriteLine();

            Console.WriteLine("SOMA DOS NEGATIVOS: " + somaNegativos.ToString("F1", CultureInfo.InvariantCulture));

            Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivos.ToString("F1", CultureInfo.InvariantCulture));            

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[linha, i].ToString("F1", CultureInfo.InvariantCulture) + " "); 
            }

            Console.WriteLine();

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {                
                Console.Write(A[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\nMATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        A[i, j] = (double)Math.Pow(A[i, j], 2.0);                        
                    }
                    Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }           
    }
}
