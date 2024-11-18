// using System;

// namespace Aula_13
// {
//     class SelectionSort
//     {
//         // Função de ordenação usando Selection Sort
//         static void Ordernar(string[] vetor)
//         {
//             int menor;
//             string aux;

//             for (int i = 0; i < vetor.Length - 1; i++)
//             {
//                 menor = i;
//                 for (int j = i + 1; j < vetor.Length; j++)
//                 {
//                     if ((vetor[j][0] < vetor[menor][0]))
//                     {
//                         menor = j;
//                     }
//                 }
//                 aux = vetor[i];
//                 vetor[i] = vetor[menor];
//                 vetor[menor] = aux;
//             }
//         }

//         // Função para imprimir o vetor
//         static void Imprimir(string[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 Console.WriteLine(vetor[i]);
//             }
//             Console.WriteLine();
//         }

//         static void Main(string[] args)
//         {
//             string[] nomes = { "Carlos", "Ana", "Beatriz", "Daniel" };
//             Console.WriteLine("Nomes desordenados:");
//             Imprimir(nomes);

//             Ordernar(nomes);
//             Console.WriteLine("Nomes ordenados:");
//             Imprimir(nomes);
//         }
//     }
// }
