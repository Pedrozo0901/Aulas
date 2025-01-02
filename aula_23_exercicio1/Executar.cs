using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            HomoSapiens humano = new HomoSapiens("Henrrique");
            System.Console.WriteLine(humano.obterTaxonomia());

            System.Console.WriteLine();

            CanisFamiliaris cachorro = new CanisFamiliaris("Trovão");
            System.Console.WriteLine(cachorro.obterTaxonomia());

            System.Console.WriteLine();

            MuscaDomestica mosca = new MuscaDomestica("Mosca Branca");
            System.Console.WriteLine(mosca.obterTaxonomia());
        }
    }
}