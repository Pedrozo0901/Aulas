using System;

namespace aula_23_exercicio2
{
    public class CasaSobrado : Casa
    {
        public int NumAndares { get; set; }

        public CasaSobrado(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, bool condominio, int numAndares)
            : base(metragem, endereco, responsavel, unidades, condominio)
        {
            NumAndares = numAndares;
        }

        public override string ToString()
        {
            string detalhes = $"Casa Sobrado localizada em {Endereco}, com {NumAndares} andares e área total de {MetragemTotal}m².\n";
            detalhes += "Unidades residenciais:\n";
            foreach (var unidade in Unidades)
            {
                detalhes += $"- Unidade {unidade.NumUnidade}: {unidade.MetragemUnidade}m², {unidade.NumQuartos} quartos, {unidade.NumBanheiros} banheiros, proprietário {unidade.Proprietario.Nome}\n";
            }
            return detalhes;
        }
    }
}
