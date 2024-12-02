// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_13
// {
//     public class Pilha
//     {
//         static int[] pilha = new int[10];

//         static int topo = 0; // topo da pilha

//         // Adiciona um elemento na pilha, Push
//         public static void Adicionar(int valor)
//         {
//             if (topo < pilha.Length)
//             {
//                 pilha[topo] = valor;
//                 topo++; // Incrementa o topo
//             }
//             else
//             {
//                 Console.WriteLine("Pilha cheia!");
//             }
//         }

//         // Remove um elemento da pilha, Pop
//         static void Remover()
//         {
//             if (topo > 0)
//             {
//                 topo--; // Decrementa o topo
//                 pilha[topo] = 0;
//             }
//             else
//             {
//                 Console.WriteLine("Pilha vazia!");
//             }
//         }

//         // Listar os elementos da pilha do topo para a base
//         public static void Listar()
//         {
//             for (int i = topo - 1; i >= 0; i--)
//             {
//                 Console.WriteLine(pilha[i]);
//             }
//         }


//         static void teste(string[] args)
//         {
//             Adicionar(10);
//             Adicionar(20);
//             Adicionar(30);
//             Adicionar(40);
//             Adicionar(50);
//             Adicionar(60);
//             Adicionar(70);
//             Adicionar(80);
//             Adicionar(90);
//             Adicionar(100);
//             Adicionar(110);
//             Adicionar(110);
//             Adicionar(110);

//             Listar();

//             Remover();

//             Listar();
//         }
//     }
// }