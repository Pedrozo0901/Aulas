using System;
using System.Runtime.InteropServices;
namespace Exemplo
{
    internal class Tipagem
    {
        static void Main (String[] args)
        {

        // Tipagem  

        // intero
        int a = 10;
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());

        // Tipagem implicita
        var c = 10;
        Console.WriteLine(c);
        Console.WriteLine(c.GetType());

        // Estite tambem a tipagem dinamica
       }
    }
}