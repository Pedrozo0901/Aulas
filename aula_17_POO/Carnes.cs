namespace aula_17_POO
{
    public class Carnes
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Carnes()
        {
            Nome = "Carne";
            Preco = 0.0;
            Quantidade = 0;
        }

        public Carnes(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double CalcularEstoque()
        {
            return Preco * Quantidade;
        }

        public void ExibirProduto(){
            System.Console.WriteLine($"Nome: {this.Nome}");
            System.Console.WriteLine($"Preço: {this.Preco}");
            System.Console.WriteLine($"Quantidade: {this.Quantidade}");
            System.Console.WriteLine($"Total em estoque R$: {this.CalcularEstoque()}");
        }
    }
}