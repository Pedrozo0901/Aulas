using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_23_exercicio2
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public string CPF {get;set;}

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getCpf()
        {
            return CPF;
        }

        public void setCpf(string cpf)
        {
            CPF = cpf;
        }

    }
}