using System;

namespace aula_23_exercicio2
{
    public abstract class Edificacao
    {
        public float MetragemTotal { get; set; }
        public string Endereco { get; set; }
        public Engenheiro Responsavel { get; set; }
        public UnidadeResidencial[] Unidades { get; set; }
        public Edificacao(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades)
        {
            MetragemTotal = metragem;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = unidades;
        }

        public float getMetragemTotal()
        {
            return MetragemTotal;
        }

        public void setMetragemTotal(float met)
        {
            MetragemTotal = met;
        }

        public string getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(string end)
        {
            Endereco = end;
        }

        public Engenheiro getResponsavel()
        {
           return Responsavel; 
        }

        public void setResponsavel(Engenheiro eng)
        {
            Responsavel = eng;
        }

        public UnidadeResidencial[] getUnidades()
        {
            return Unidades;
        }

        public void setUnidades(UnidadeResidencial[] unidades)
        {
            Unidades = unidades;
        }
    }
}
