// using System;

// namespace aula_3
// {
//     class ex_switch
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
//             double possivelPerda = 0;
//             string perda = "";

//             switch (invest)
//             {
//                 case "poupanca":
//                 rentabilidade = valor + (valor * 0.03 * anos);
//                 break;
//                 case "renda fixa":
//                 rentabilidade = valor + (valor * 0.05 * anos);
//                 break;
//                 case "acoes":
//                 rentabilidade = valor + (valor * 0.10 * anos);
//                 possivelPerda =  (valor * 0.05 * anos);
//                 perda = "Em ações você pode elevar seu partimonio até: " + rentabilidade + " mas tambem pode perder: " + possivelPerda + " dele"; 
//                 break;
//             }

            
//             if (invest == "acoes"){
//                 System.Console.WriteLine(perda);
//             } 
//             else {
//                 System.Console.WriteLine(rentabilidade);
//             }
            
//         }
//     }
// }