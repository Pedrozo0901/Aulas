using System;

namespace aula_23_exercicio2
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Adair Fonsseca", "111.111.111-11");
            Engenheiro engenheiro1 = new Engenheiro("Cleiton", "000.000.000-00", 1234567);

            UnidadeResidencial[] unidadesPredio = new UnidadeResidencial[]
            {
                new UnidadeResidencial(1, 50, 2, 2, pessoa),
                new UnidadeResidencial(2, 60, 3, 2, pessoa)
            };

            Predio predio1 = new Predio(400, "Rua Constantinopla, 459", engenheiro1, unidadesPredio, "Prédio do Senna", 20, 4);

            UnidadeResidencial[] unidadesSobrado = new UnidadeResidencial[]
            {
                new UnidadeResidencial(1, 70, 2, 2, pessoa)
            };

            CasaSobrado sobrado1 = new CasaSobrado(200, "Rua Primavera, 12", engenheiro1, unidadesSobrado, true, 2);

            System.Console.WriteLine(predio1.ToString());

            System.Console.WriteLine(sobrado1.ToString());
        }
    }
}
