// using System;

// namespace aula_9
// {
//     class exercicio1
//     {
//         public delegate double Operacao(double[] valores);

//         static double Media(double[] vetor)
//             {
//                 double media = 0;
//                 for(int i = 0; i < 10; i++)
//                 {
//                     media += vetor[i];
//                 }
//                 return media / vetor.Length;
//             }

        
//         // static void Main(string[] args)
//         {
//             Operacao media = new Operacao(Media);
//             double[] vetor = new double[10];
//             System.Console.WriteLine("Escreva 10 números para saber a média");
//             for(int i = 0; i < 10; i++)
//             {
//                 vetor[i] = double.Parse(Console.ReadLine());
//             }

//             System.Console.WriteLine("A média é:");
//             System.Console.WriteLine(media(vetor));
//         }
//     }
// }