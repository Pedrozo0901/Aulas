// namespace Aula12;

// public class MergeSort
// {
//     static void Ordenar(int[] vetor, int inicio, int fim)
//     {
//         if (inicio < fim)
//         {
//             int meio = (inicio + fim) / 2;
//             Ordenar(vetor, inicio, meio);
//             Ordenar(vetor, meio + 1, fim);
//             Intercalar(vetor, inicio, meio, fim);
//         }
//     }

//     static void Intercalar(int[] vetor, int inicio, int meio, int fim)
//     {
//         int[] aux = new int[vetor.Length];
//         for (int j = inicio; j <= fim; j++)
//         {
//             aux[j] = vetor[j];
//         }

//         int i1 = inicio;
//         int i2 = meio + 1;
//         int i3 = inicio;

//         while (i1 <= meio && i2 <= fim)
//         {
//             if (aux[i1] < aux[i2])
//             {
//                 vetor[i3] = aux[i1];
//                 i1++;
//             }
//             else
//             {
//                 vetor[i3] = aux[i2];
//                 i2++;
//             }
//             i3++;
//         }

//         while (i1 <= meio)
//         {
//             vetor[i3] = aux[i1];
//             i1++;
//             i3++;
//         }

//         while (i2 <= fim)
//         {
//             vetor[i3] = aux[i2];
//             i2++;
//             i3++;
//         }
//     }
    
//     static void Imprimir(int[] vetor)
//     {
//         for (int i = 0; i < vetor.Length; i++)
//         {
//             Console.Write(vetor[i] + " ");
//         }
//         Console.WriteLine();
//     }

//     static void Teste(string[] args)
//     {
//         int[] vetor = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 15, 13};
//         Ordenar(vetor, 0, vetor.Length - 1);
//         Imprimir(vetor);
//     }
// }