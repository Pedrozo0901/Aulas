using System;

namespace Aula_11
{
    class Variavel_implicita
    {
        static void Teste()
        {
            // Variável implicita é uma variável que pode receber qualquer tipo de valor
            var nome = "C#";
            System.Console.WriteLine(nome);
            System.Console.WriteLine(nome.GetType());

            var idade = 20;
            System.Console.WriteLine(idade);
            System.Console.WriteLine(idade.GetType());

            var altura = 1.75;
            System.Console.WriteLine(altura);
            System.Console.WriteLine(altura.GetType());

            // const = constante, onde o seu valor não pode ser alterado
            const double pi = 3.1415;
            System.Console.WriteLine(pi);
            System.Console.WriteLine(pi.GetType());

            // Lista
            var lista = new List<int> {1,2,3,4,5};

            System.Console.WriteLine(lista.GetType());
            
            foreach(var item in lista)
            {
                System.Console.WriteLine(item);
            }

            // Dicionário
            var dicionario = new Dictionary<string, int>()
            {
                {"C#", 1},
                {"Java", 2},
                {"Python", 3}
            };
            System.Console.WriteLine(dicionario.GetType());
            // função para listar os elementos do dicionário

            foreach(var item  in dicionario)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}