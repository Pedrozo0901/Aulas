// Construa um programa que receba uma palavra do usuário. O programa deverá
// verificar se esta palavra corresponde à senha de acesso (senha: “Digix”). Se a palavra
// fornecida pelo usuário for igual a senha, o programa deverá informar “Acesso
// autorizado”, caso contrário, deverá informar “Acesso negado”.

using System;

namespace Aula_6
{
    class exercicio2
    {
        static void Teste()
        {

            string digix = "Digix";

            System.Console.WriteLine("Escreva a palavra chave");

            string palavraChave = System.Console.ReadLine();

            if(palavraChave == digix) {
                System.Console.WriteLine("Acesso autorizado!");
            } else {
                System.Console.WriteLine("Acesso negado!");
            }

        } 
    }
}