using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Adair Fonsseca", "111.111.111-11");
            Engenheiro engenheiro1 = new Engenheiro ("Cleiton", "000.000.000-00", 1234567);
            UnidadeResidencial unidadeResid1 = new UnidadeResidencial(1, 50, 2, 2, pessoa);

            Predio predio1 = new Predio(400, "Rua Constantinopla, 459", engenheiro1, unidadeResid1, "Prédio do Senna", 20, 4);

            System.Console.WriteLine($"Prédio {predio1.Nome} \nSituado em: {predio1.Endereco} \nResponsavel: {predio1.Responsavel.Nome} \nNúmero de andares: {predio1.NumAndares} \nNúmero de apartamentos por andar: {predio1.ApPorAndar}");

            System.Console.WriteLine();

            System.Console.WriteLine($"Unidade residencial {unidadeResid1.NumUnidade} \nPropriedade de: {unidadeResid1.Proprietario.Nome} \nPossui {unidadeResid1.MetragemUnidade} metros, {unidadeResid1.NumQuartos} quartos e {unidadeResid1.NumBanheiros} banheiros");

        }
    }
}