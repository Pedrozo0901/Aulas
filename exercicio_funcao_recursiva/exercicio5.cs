// // Faça um programa que calcule a soma dos elementos de um vetor de inteiros.

// using System;

// namespace Exercicio_funcao_recursiva
// {
//     class Exercicio5
//     {
//         static int SomaVetor(int[] vetor, int tamanho)
//         {
//             int soma = 0;
//             if(tamanho == 0)
//             {
//                 return 0;
//             } else {
//                 return vetor[tamanho -1] += SomaVetor(vetor, tamanho -1);
//             }
//         }
//         static void Teste(string[] args)
//         {
//             int[] vetor = {10,10,10,10,10};
//             int tamanho = vetor.Length;
            
//             System.Console.WriteLine($"A soma do vetor é: {SomaVetor(vetor, tamanho)}");
//         }
//     }
// }