using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_21_exercicio
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }

        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Endereco = endereco;
        }

    }
}