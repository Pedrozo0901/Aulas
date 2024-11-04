using System;

namespace aula_3
{
    class if_else
    {
        static void Teste()
        {
            int idade = 10;

            if (idade >= 18 && idade <= 50){
                System.Console.WriteLine("Adulto");
            }
            else if (idade > 50 && idade <= 100) {
                System.Console.WriteLine("Idoso");
            }
            else {
                System.Console.WriteLine("Criança");
            }
        }
    }
}