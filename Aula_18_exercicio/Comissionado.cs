using System;

namespace Aula_18_exercicio
{
    public class Comissionado : Empregado
    {
        public double TotalVenda;
        public double Comissao;

        public Comissionado(string nome, string sobrenome, string cpf, double totalvenda, double comissao) : base(nome, sobrenome, cpf)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
            this.TotalVenda = totalvenda;
            this.Comissao = comissao;
        }

        public override double Vencimento()
        {
            return Comissao;
        }

        public void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Sobrenome: " + Sobrenome);
            System.Console.WriteLine("CPf: " + CPF);
            System.Console.WriteLine("Comissão: " + Comissao);
        }
    }
}