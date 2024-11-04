using System;

namespace aula_2
{
    class exercicio_fixacao
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Entre com o preço do produto:");
            double preco = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Entre com o seu ultimo nome:");
            string ultimoNome = Console.ReadLine();

            System.Console.WriteLine("Entre com sua idade");
            int idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com sua altura");
            double altura = double.Parse(Console.ReadLine());
            
            
            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine($"{preco:F2}");
            System.Console.WriteLine($"{ultimoNome} {idade} {altura}");
        }
    }
}