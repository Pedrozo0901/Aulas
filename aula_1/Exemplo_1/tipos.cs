using System;
using System.Runtime.InteropServices;
namespace Exemplo
{
    internal class Tipos1
    {
        static void Teste()
        {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 21315347;
            long n4 = 23543432;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Greem";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;

            Console.WriteLine($"Olá Sr {obj1}, você definiu seu gênero como {genero}");
            Console.WriteLine($"Bom dia sra {nome}, seu saldo foi alterado para {n1}, após uma compra de R$ {n2} nas lojas americanas, com {obj2}% de juros");
            Console.WriteLine($"{n3} é maior que {n4}?");
            Console.WriteLine($"{letra} ou {completo}");
            Console.WriteLine($"{n5} é diferente de {n6}?");
       }
    }
}