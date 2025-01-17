// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace aula_33_
// {
//     public class ClasseTask
//     {
//         // async é quando uma função é assincrona, ou seja ela não é executada de forma queo programa não para enquanto espera o retorno
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10, 20);  // O await é para esperar o retorno da função
//             System.Console.WriteLine("Resultado: " + resultado);
//         }    

//         static Task<int> Soma(int a, int b)
//         {
//             return Task.Run(() => {
//                 Task.Delay(10000).Wait(); // Espera 2 segundos
//                 return a + b;
//             });
//         } 
//     }
// }