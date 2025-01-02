using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class Engenheiro : Pessoa
    {
        public int Crea {get; set;}

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            Nome = nome;
            CPF = cpf;
            Crea = crea;
        }

        public int getCrea()
        {
            return Crea;
        }

        public void setCrea(int crea)
        {
            Crea = crea;
        }
    }
}