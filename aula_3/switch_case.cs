using System;

namespace aula_3
{
    class switch_case
    {
        static void Teste()
        {
            int idade = 4;

            switch (idade)
            {
                case int n when n >= 18 && n <= 50:
                    System.Console.WriteLine("Adulto");
                    break;
                case int n when n > 50 && n <= 100:
                    System.Console.WriteLine("Idoso");
                    break;
                case int n when n > 100:
                    System.Console.WriteLine("Já morreu");
                break;
                default:
                    System.Console.WriteLine("Criança");
                    break;
            }
        }
    }
}