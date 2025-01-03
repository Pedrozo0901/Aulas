using System;

namespace aula_23_exercicio2
{
    public class Predio : Edificacao
    {
        public string Nome { get; set; }
        public int NumAndares { get; set; }
        public int ApPorAndar { get; set; }

        public Predio(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, string nome, int numAndares, int apPorAndar)
            : base(metragem, endereco, responsavel, unidades)
        {
            Nome = nome;
            NumAndares = numAndares;
            ApPorAndar = apPorAndar;
        }

        public override string ToString()
        {
            string detalhes = $"Prédio: {Nome}, localizado em {Endereco}, com {NumAndares} andares e {ApPorAndar} apartamentos por andar.\n";
            detalhes += "Unidades residenciais:\n";
            foreach (var unidade in Unidades)
            {
                detalhes += $"- Unidade {unidade.NumUnidade}: {unidade.MetragemUnidade}m², {unidade.NumQuartos} quartos, {unidade.NumBanheiros} banheiros, proprietário {unidade.Proprietario.Nome}\n";
            }
            return detalhes;
        }
    }
}
