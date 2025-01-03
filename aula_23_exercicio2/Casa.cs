using System;

namespace aula_23_exercicio2
{
    public class Casa : Edificacao
    {
        public bool Condominio { get; set; }

        public Casa(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial[] unidades, bool condominio)
            : base(metragem, endereco, responsavel, unidades)
        {
            MetragemTotal = metragem;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = unidades;
            Condominio = condominio;
        }

        public bool getCondominio()
        {
            return Condominio;
        }

        public void setCondominio(bool condominio)
        {
            Condominio = condominio;
        }
    }
}
