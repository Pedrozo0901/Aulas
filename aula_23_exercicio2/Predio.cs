using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class Predio : Edificacao
    {
        public string Nome {get; set;}
        public int NumAndares {get; set;}
        public int ApPorAndar {get; set;}

        public Predio(float metragem, string endereco, Engenheiro responsavel, UnidadeResidencial unidades, string nome, int numAndares, int apPorAndar) : base(metragem, endereco, responsavel, unidades)
        {
            MetragemTotal = metragem;
            Endereco = endereco;
            Responsavel = responsavel;
            Unidades = unidades;
            Nome = nome;
            NumAndares = numAndares;
            ApPorAndar = apPorAndar;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public int getNumAndares()
        {
            return NumAndares;
        }

        public void setNumAndares(int numAndares)
        {
            NumAndares = numAndares;
        }

        public int getApPorAndar()
        {
            return ApPorAndar;
        }

        public void setApPorAndar(int apPorAndar)
        {
            ApPorAndar = apPorAndar;
        }
    }
}