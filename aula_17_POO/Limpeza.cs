namespace aula_17_POO
{
    public class Limpeza
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Limpeza()
        {
            Nome = "Quiboa";
            Preco = 0.0;
            Quantidade = 16;
        }

        public Limpeza(string nome, double preco, int quantidade){
            this.Nome = nome;
            this.Preco =  preco;
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