using System;

namespace aula_8
{
    class exercicio1
    {
        static void Teste()
        {
            int[] vetor = new int [10];

            System.Console.WriteLine("Escreva 10 números para saber a média:");
            for(int i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(System.Console.ReadLine());
            }

            int soma = 0;
            for(int i = 0; i < 10; i++)
            {
                soma = soma + vetor[i];
            }
            int media = soma / 10;
            System.Console.WriteLine($"Média {media}");
        }
    }
}