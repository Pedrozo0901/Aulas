// // Faça um programa que calcule a soma dos números de 1 a n, onde n é um número
// // inteiro fornecido pelo usuário

// using System;

// namespace exercicio_funcao_recursiva
// {
//     class exercicio1
//     {
//         static int Soma(int num)
//         {
//             if(num == 1)
//             {
//                 return 1;
//             } else {
//                 return num += Soma(num -1);
//             }
//         }
//         static void Teste(string[] args)
//         {
//             System.Console.WriteLine("Escreva um número:");
//             int num = int.Parse(System.Console.ReadLine());

//             System.Console.WriteLine($"A soma de 1 até {num} é: {Soma(num)}");
//         }
//     }
// }