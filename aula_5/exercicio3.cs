// Reescreva o programa que identifica o DDD dos estados, utilizando a estrutura Caso,
// de acordo com os seguintes critérios de DDDs e seus respectivos Estados brasileiros.
// • Paraná: 41, 42, 43, 44, 45 e 46
// • Rio Grande do Sul: 51, 53, 54 e 55
// • Brasília: 61
// • Goiás: 62 e 64
// • Mato Grosso: 65 e 66
// • Mato Grosso do Sul: 67

using System;

namespace Aula_6
{
    class exercicio3
    {
        static void Main (string[] args)
        {
            
            System.Console.WriteLine("Escreva o DDD");
            string ddd = System.Console.ReadLine();

            switch (ddd)
            {
                case "41":
                case "42":
                case "43":
                case "44":
                case "45":
                case "46":
                    System.Console.WriteLine("Esse DDD pertence ao Paraná");
                    break;
                case "51":
                case "53":
                case "54":
                case "55":
                    System.Console.WriteLine("Esse DDD pertence ao Rio Grande do Sul");
                    break;
                case "61":
                    System.Console.WriteLine("Esse DDD pertence a Brasília");
                    break;
                case "62":
                case "64":
                    System.Console.WriteLine("Esse DDD pertence ao Goías");
                    break;
                case "65":
                case "66":
                    System.Console.WriteLine("Esse DDD pertence ao Mato Grosso");
                    break;
                case "67":
                    System.Console.WriteLine("Esse DDD pertence ao Mato Grosso do Sul");
                    break;
                default:
                    System.Console.WriteLine("Este DDD não existe");
                    break;
            }

        } 
    }
}