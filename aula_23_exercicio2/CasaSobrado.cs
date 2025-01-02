using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class CasaSobrado : Casa
    {
        public int NumAndares {get; set;}

        public CasaSobrado(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial unidades, bool condominio, int numAndares) : base(metragem, endereco, responsavel, unidades, condominio)
        {
            MetragemTotal = metragem;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = unidades;
            Condominio = condominio;
            NumAndares = numAndares;
        }

        public int getNumAndares()
        {
            return NumAndares;
        }

        public void setNumAndares(int numAndares)
        {
            NumAndares = numAndares;
        }
    }
}