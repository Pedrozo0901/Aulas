// 2. Ler um vetor com 10 inteiros e calcular o maior e o menor elemento do
// vetor.

using System;

namespace aula_7;
class exercicio2
{
    static void Teste()
    {
        int[] vetor = new int[10];
        Console.WriteLine("Escreva 10 números");
        
        
        for(int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(System.Console.ReadLine());
            
        }
        int menorNum = vetor[0];
        int maiorNum = vetor[0];
        for(int i = 0; i < 10; i++)
        {
            if(menorNum > vetor[i]){
                menorNum = vetor[i];
            }
            if(maiorNum < vetor[i]){
                maiorNum = vetor[i];
            }
            
        }
        System.Console.WriteLine("maior:");
        System.Console.WriteLine(maiorNum);
        System.Console.WriteLine("menor:");
        System.Console.WriteLine(menorNum);
        
    }
    
}