// using System;

// namespace Aula_12
// {
//     class Insertion_sort
//     {
//         // Função de ordenação usando Insertion Sort (decrescente)
//         static void Ordernar(int[] vetor)
//         {
//             int aux, j;
//             for (int i = 1; i < vetor.Length; i++)
//             {
//                 aux = vetor[i];
//                 j = i - 1;
//                 while (j >= 0 && vetor[j] < aux) // Alteração para ordem decrescente
//                 {
//                     vetor[j + 1] = vetor[j];
//                     j--;
//                 }
//                 vetor[j + 1] = aux;
//             }
//         }

//         // Função para imprimir o vetor em uma linha
//         static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 Console.Write(vetor[i] + " ");
//             }
//             Console.WriteLine();
//         }

//         static void teste(string[] args)
//         {
//             int[] vetor = { 3, 1, 5, 7, 3, 4 };
//             Console.WriteLine("Vetor desordenado:");
//             Imprimir(vetor);

//             Ordernar(vetor);
//             Console.WriteLine("Vetor ordenado (decrescente):");
//             Imprimir(vetor);
//         }
//     }
// }
