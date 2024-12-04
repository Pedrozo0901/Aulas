using System;

namespace Produto
{
    public class Produto{
        public string Nome;
        public double Preco;
        public string SistemOP;

        public Produto(string nome, double preco, string sistema)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.SistemOP = sistema;
        }

        public Produto()
        {
            this.Nome = "Sem nome";
            this.Preco = 0;
            this.SistemOP = "";
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Nome: " + this.Nome);
            System.Console.WriteLine("Preço: " + this.Preco);
            System.Console.WriteLine("Sistema operacional: " + this.SistemOP);
        }

        static void Main(string[] args)
        {
            Produto p1 = new Produto("Notbook", 2889.90, "Linux");
            p1.ExibirInformacoes();

            Produto p2 = new Produto();
            p2.Nome = "Iphone 11";
            p2.Preco = 2650;
            p2.SistemOP = "IOS";
            p2.ExibirInformacoes();
        }
    }
}