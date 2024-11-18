// using System;

// namespace Aula_13
// {
//     class InsertionSort
//     {
//         // Função de ordenação usando Insertion Sort 
//         static void Ordernar(int[] vetor)
//         {
//             int aux, j;
//             for (int i = 1; i < vetor.Length; i++)
//             {
//                 aux = vetor[i];
//                 j = i - 1;
//                 while (j >= 0 && vetor[j] < aux) 
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

//         static void Teste(string[] args)
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
