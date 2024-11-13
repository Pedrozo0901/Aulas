// // Faça um programa que calcule a potência de um número inteiro x elevado a um número
// // inteiro não-negativo n, fornecidos pelo usuário.

// using System;

// namespace Exercicio_funcao_recursiva
// {
//     class Exercicio3
//     {
//         static int Potencia(int num, int potencia)
//         {
//             if(potencia == 1)
//             {
//                 return num;
//             } else
//             {
//                 return num * Potencia(num, potencia -1);
//             }
//         }
//         static void Teste(string[] args)
//         {
//             System.Console.WriteLine("Escreva um número:");
//             int num = int.Parse(System.Console.ReadLine());
//             int potencia = int.Parse(System.Console.ReadLine());

//             System.Console.WriteLine($"A potencia de {num} elevado a {potencia} é: {Potencia(num, potencia)}");
//         }
//     }
// }