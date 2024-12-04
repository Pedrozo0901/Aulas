// using System;

// namespace Padaria
// {
//     class Padaria{
//         public string NomeAlimento;
//         public double Preco;
//         public string Bebida;
//         public string Doces;
//         public DateTime DataVenda;

//         public string Encomenda()
//         {
//             return "Encomenda: " + NomeAlimento + ", " + Bebida + ", " + Doces + "Foi vendido no dia: " + DataVenda;
//         }

//         public double CestaCompras(List<(string NomeAlimento, double Preco)> itens){
//             double total = 0;

//             // Altera os itens d lista e soma
//             foreach(var  item in itens)
//             {
//                 System.Console.WriteLine($"Item: {item}, Preço: {item.Preco}");
//                 total += item.Preco;
//             }

//             return total;
//         }
//     }
// }