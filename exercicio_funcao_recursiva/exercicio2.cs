// // Faça um programa que calcule o produto dos números de 1 a n, onde n é um número
// // inteiro fornecido pelo usuário.

// using System;

// namespace Exercicio_funcao_recursiva
// {
//     class Exercicio2
//     {
//         static int Multiplicacao(int num)
//         {
//             if(num == 1)
//             {
//                 return 1;
//             } else {
//                 return num * Multiplicacao(num - 1);
//             }
//         }
//         static void Teste(string[] args)
//         {
//             System.Console.WriteLine("Escreva um número:");
//             int num = int.Parse(System.Console.ReadLine());

//             System.Console.WriteLine($"O produto de 1 até {num} é: {Multiplicacao(num)}");
//         }
//     }
// }