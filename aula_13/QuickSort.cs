// using System;

// namespace Aula_13
// {
//     public class QuickSort
//     {
//         // Algoritmo de ordenação QuickSort
//         static void Ordernar(int[] vetor, int inicio, int fim)
//         {
//             if(inicio < fim)
//             {
//                 int p = Particionar(vetor, inicio, fim);
//                 Ordernar(vetor, inicio, p -1);
//                 Ordernar(vetor, p+1, fim);
//             }
//         }
        
//         static int Particionar(int[] vetor, int inicio, int fim)
//         {
//             int pivo = vetor[fim];
//             int i = inicio - 1;
//             for (int j = inicio; j < fim; j++)
//             {
//                 if(vetor[j] < pivo)
//                 {
//                     i++;
//                     int aux = vetor[i];
//                     vetor[i] = vetor[j];
//                     vetor[j] = aux;
//                 }   
//             }
//             int aux2 = vetor[i + 1];
//             vetor[i+1] = vetor[fim];
//             vetor[fim] = aux2;
//             return i + 1;
//         }

//          static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 Console.Write(vetor[i] + " ");
//             }
//             Console.WriteLine();
//         }

//         static void Teste(string[] args)
//         {
//             int[] vetor = { 3, 1, 5, 7, 3, 8};
//             Console.WriteLine("Vetor desordenado:");
//             Imprimir(vetor);

//             Ordernar(vetor, 0, vetor.Length -1);
//             Console.WriteLine("Vetor ordenado:");
//             Imprimir(vetor);
//         }
//     }
    
// }