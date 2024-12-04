// using System;

// namespace Padaria
// {
//     public class PadariaExecutar
//     {
//         static void Main(string[] args)
//         {
//             Padaria padaria1 = new Padaria();
//             padaria1.NomeAlimento = "Sonho";
//             padaria1.Preco = 100.50;
//             padaria1.Bebida = "Café expresso";
//             padaria1.Doces = "Sonho";
//             padaria1.DataVenda = DateTime.Now.AddDays(-90);

//             System.Console.WriteLine(padaria1.Encomenda()); 

//             // Exibindo os detalhes da encomendas
//             System.Console.WriteLine(padaria1.Encomenda());

//             // Crando uma lista de comras o nome e preço
//             List<(string NomeAlimento, double Preco)> listaCompras = new List<(string NomeAlimento, double Preco)>
//             {
//                 ("Pão Franes", 5.90),
//                 ("Bolo Cenouro", 20.50),
//                 ("Coxinha", 4.50),
//                 ("Suco natural", 10.20)
//             };

//             // Calculando valor da Cesta
//             double total = padaria1.CestaCompras(listaCompras);
//             System.Console.WriteLine($"Total de cestas de compra R$:{total}");
            
//         }
//     }
// }