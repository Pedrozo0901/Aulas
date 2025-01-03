using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24
{
    public abstract class Cliente
    {
        // Propriedades
        public string Nome {get; set;}
        public Endereco Endereco {get; set;}
        public string Telefone {get; set;}
        public string CPF {get; set;}

        // Para ocorrer a composição o endereço deve ser instanciado
        public Cliente()
        {
            Endereco = new Endereco();
        }

        public Cliente(string nome, string rua, string cidade, string estado, int cep, string telefone, string cpf)
        {
            Nome = nome;
            Endereco = new Endereco(rua, cidade, estado, cep);
            Telefone = telefone;
            CPF = cpf;
        }

        public abstract string ConsultarFidelidade();
    }

    public class ClienteGold : Cliente
    {
        public double Desconto {get; set;}
        public override string ConsultarFidelidade()
        {
            return "Cliente Gold, tem um descondo de 10%";
        }
    }

    public class ClientePremium : Cliente
    {
        public double Desconto {get; set;}
        public override string ConsultarFidelidade()
        {
            return "Cliente Premium, tem um descondo de 15%";
        }
    }
}