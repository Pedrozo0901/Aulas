// using System;

// namespace Exercicio_funcao_recursiva
// {
//     class Exercicio4
//     {
//         static int CalcularMDC(int a, int b)
//         {
//             if (b == 0)
//             {
//                 return a;
//             }
//             else
//             {
//                 return CalcularMDC(b, a % b);
//             }
//         }

//         static void Main(string[] args)
//         {
//             int num1 = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite o segundo número:");
//             int num2 = int.Parse(Console.ReadLine());

//             int mdc = CalcularMDC(num1, num2);

//             Console.WriteLine($"O MDC de {num1} e {num2} é: {mdc}");
//         }
//     }
// }
