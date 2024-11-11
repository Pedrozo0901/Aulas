using System;

namespace Aula_11
{
    class Pares_vetor
    {
        
        static int Pares (int[] vetor, int n)
        {
            if(n == 0)
                return 0;
            else if(vetor[n - 1] % 2 == 0)
                return vetor[n -1] + Pares(vetor, n - 1);
            else        
                return Pares(vetor, n -1);
        }
        static void Teste()
        {
            int[] vetor = [1,2,3,4,5,6,7,8,9,10];
            System.Console.WriteLine("A soma dos pares é: " + Pares(vetor, vetor.Length));

            
        }
    }
}