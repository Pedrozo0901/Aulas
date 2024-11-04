using System;

namespace aula_3
{
    class ternario
    {
        static void Teste()
        {
            int idade = 3;
            string resultado = idade >= 18 ? "Adulto" : "Criança";

            System.Console.WriteLine(resultado);  

            string resultado2 = idade > 18 && idade < 50 ? "Adulto" : idade > 50 ? "Idoso" : "Criança";
            System.Console.WriteLine(resultado2);          
        }
    }
}