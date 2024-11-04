// Escreva um algoritmo que dado uma quantidade indeterminada de números inteiros e
// positivos, informe o menor e o maior. Utilize o número -1 como finalizador, ou seja,
// servirá como recurso de saída do laço de repetição.

using System;

namespace Aula_6
{
    class exercicio4
    {
        static void Teste()
        {
            System.Console.WriteLine("Escreva números para saber se é maior ou menor");
            int num1 = 0;
            int num2 = 0;
            while(1 < 2){
                num1 = int.Parse(System.Console.ReadLine());
                num2 = int.Parse(System.Console.ReadLine());

                if(num1 == -1 || num2 == -1 ){
                    break;
                }
                else if(num1 > num2)
                {
                    System.Console.WriteLine($"O número {num1} é maior");
                }else
                {
                    System.Console.WriteLine($"O número {num2} é maior");
                }

            }
           System.Console.WriteLine("Programa encerrado!");
        } 
    }
}