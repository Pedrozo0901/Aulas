using System;

namespace Aula_9
{
    class Exemplo
    {
        // Função com dois parâmetros
        static int soma(int a, int b)
        {
            return a + b;
        }

        // Função com 3 parâmetros
        static int multiplicacacao(int x, int y, int z)
        {
            return x*y*z;
        }

        static double multiplicacacao2(double x = 10, double y = 2, double z = 5)
        {
            return x*y*z;
        }

        

        // Procedieto
        static void imprimir(string texto)
        {
            Console.WriteLine(texto);
        }
        // static void Main(string[] args)
        static void Teste()
        {
            // executando a função
            int a = 10;
            int b = 5;
            int resultado = soma(a,b);
            System.Console.WriteLine($"A soma de {a} + {b} é {resultado}");

            // executando o procedimento
            // deve ser chamada dretamente
            imprimir("Olá mundo!");


            int x = 10;
            int y = 20;
            int z = 30;
            int resultado2 = multiplicacacao(x,y,z);

            System.Console.WriteLine(resultado2);

            double resultado3 = multiplicacacao2(x,y);
            System.Console.WriteLine(resultado3);

            // testando função com vetor
            static int somaVetor(int[] vetor)
            {
                int soma = 0;
                for(int i = 0; i < vetor.Length; i++)
                {
                    soma += vetor[i];
                }
                return soma;
            }

            int[] vetor =  {1,2,3,4,5};

            int resultadoVetor = somaVetor(vetor);
            System.Console.WriteLine($"o resultado da soma do vetor é {resultadoVetor}");

            // Função com matriz

            static int somaMatriz(int[,] matriz)
            {
                int soma = 0;
                for(int i = 0; i < matriz.GetLength(0); i++)
                {
                    for(int j = 0; j < matriz.GetLength(1); j++)
                    {
                        soma += matriz[i,j];
                    }
                }
                return soma;
            }

            int[,] matriz = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int resultadoMatriz = somaMatriz(matriz);
            System.Console.WriteLine($"O resultado da soma da matriz é {resultadoMatriz}");
        }
    }
}
