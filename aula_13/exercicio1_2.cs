// using System;

// namespace Aula_13
// {
//     class BubbleSort
//     {
//         static void Ordernar(int[] vetor)
//         {
//             int aux = 0;
//             int interacoes = 0;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 for (int j = 0; j < vetor.Length - 1; j++)
//                 {
                    
//                     if(vetor[j] == vetor[j+1])
//                     {
//                         break;
//                     }
//                     else if(vetor[j] > vetor[j+1])
//                     {
//                         aux = vetor[j];
//                         vetor[j] = vetor[j+1];
//                         vetor[j+1] = aux;
//                         interacoes++;
//                     }
//                 }   
//             }
//             string resposta = "";
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 System.Console.WriteLine(vetor[i] + " ");
//             }
//             System.Console.WriteLine($"interações: {interacoes}");
            
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
//            int[] vetor = {64,34,25,12,22,11,90};

//            Ordernar(vetor);
//         }
//     }
// }