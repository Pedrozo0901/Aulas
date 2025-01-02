using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class UnidadeResidencial
    {
        public int NumUnidade {get; set;}
        public float MetragemUnidade {get; set;}
        public int NumQuartos {get; set;}
        public int NumBanheiros { get; set;}
        public Pessoa Proprietario {get; set;}

        public UnidadeResidencial(int numUnidade, float metragemUnidade, int numQuartos, int numBanheiros, Pessoa proprietario)
        {
            NumUnidade = numUnidade;
            MetragemUnidade = metragemUnidade;
            NumQuartos = numQuartos;
            NumBanheiros = numBanheiros;
            Proprietario = proprietario;
        }

        public int getNumUnidade()
        {
            return NumUnidade;
        }

        public void setNumUnidade(int numUnidade)
        {
            NumUnidade = numUnidade;
        }

        public float getMetragemUnidade()
        {
            return MetragemUnidade;
        }

        public void setMetragemUnidade(float metragemUnidade)
        {
            MetragemUnidade = metragemUnidade;
        }

        public int getNumQuartos()
        {
            return NumQuartos;
        }

        public void setNumQuartos(int numQuartos)
        {
            NumQuartos = numQuartos;
        }

        public int getNumBanheiros()
        {
            return NumBanheiros;
        }

        public void setNumBanheiros(int numBanheiros)
        {
            NumBanheiros = numBanheiros;
        }

        public Pessoa getProprietario()
        {
            return Proprietario;
        }

        public void setProprietario(Pessoa proprietario)
        {
            Proprietario = proprietario;
        }
    }
}