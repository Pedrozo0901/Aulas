using System;
using System.Runtime.InteropServices;
namespace Exemplo
{
    internal class Program
    {
        static void Teste()
        {
            int idade = 25;
            double saldo = 10.500001;
            string nome = "Maria Antonieta";
            
            Console.WriteLine("Olá, " +  nome +  " sua idade é " + idade + " anos, e seu saldo é de: R$ " + saldo);
            // Ou
            Console.WriteLine("{0} tem {1} ans e tem um saldo igual a {2:F2} reais", nome, idade, saldo);
            // Ou interpolado
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo {saldo:F3}");


        }
    }
}