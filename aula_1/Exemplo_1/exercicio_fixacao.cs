using System;
using System.Runtime.InteropServices;
namespace Exemplo
{
    internal class exercicio_fixacao
    {
        static void Teste()
        {

        string produto1 = "Computador";
        string produto2 = "Mesa de escritóro";
        byte idade= 30;
        int codigo = 5290;
        char genero ='M';

        double preco1 = 2100.0;
        double preco2 = 650.0;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F1}");
        Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F1}");
        Console.WriteLine("\n");
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine("\n");
        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (Três casas decimais): {medida:F3}");
        Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");

       }
    }
}