// using System;

// namespace Aula_12
// {
//     class Bubble_srot
//     {
//         static void Ordernar(int[] vetor)
//         {
//             int aux = 0;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 for (int j = 0; j < vetor.Length - 1; j++)
//                 {
//                     if(vetor[j] < vetor[j+1])
//                     {
//                         aux = vetor[j];
//                         vetor[j] = vetor[j+1];
//                         vetor[j+1] = aux;
//                     }
//                 }   
//             }
//         }

//         static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 System.Console.WriteLine(vetor[i] + " ");
//             }
//             System.Console.WriteLine();
//         }
//         static void Teste(string[] args)
//         {
//            int[] vetor = {3,1,5,7,3,4};
//            System.Console.WriteLine("Vetor desordenado");
//            Imprimir(vetor);

//            Ordernar(vetor);
//            System.Console.WriteLine("Vetor ordenado");
//            Imprimir(vetor);
//         }
//     }
// }