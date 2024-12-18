using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_21_exercicio
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco)
        : base(nome, nascimento, cpf, endereco)
        {
        }

        public void GetSalario()
        {
            // Implementação fictícia
            Console.WriteLine("Salário do Gerente: R$ 5000,00");
        }
    }
}