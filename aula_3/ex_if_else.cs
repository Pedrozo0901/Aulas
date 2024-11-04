// using System;

// namespace aula_3
// {
//     class ex_if_else
//     {
//         static void Teste()
//         {

//             System.Console.WriteLine("Digite o valor a investir");
//             double valor = double.Parse(System.Console.ReadLine());

//             System.Console.WriteLine("Digite o tipo investimento (poupanca, renda fixa ou acoes)");
//             string invest = System.Console.ReadLine();

//             System.Console.WriteLine("Por quantos anos deseja investir?");
//             int anos = int.Parse(System.Console.ReadLine());

//             double rentabilidade = 0;

//             if(invest == "poupanca"){
                
//                 rentabilidade = valor + (valor * 0.03 * anos);

//             }
//             else if (invest == "renda fixa"){

//                 rentabilidade = valor + (valor * 0.05 * anos);

//             } else {

//                 rentabilidade = valor + (valor * 0.10 * anos);

//             }

//             System.Console.WriteLine(rentabilidade);
//         }
//     }
// }