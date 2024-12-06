namespace aula_17_POO
{
    public class Petiscos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Petiscos() {
            Nome = null;
            Preco = 0.0;
            Quantidade = 0;

            // Se instanciar
            // Petiscos p = new Petiscos();
            // p.Nome = "Coxinha"

        }

        public Petiscos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

            // Se instanciar
            // Petiscos p = new Petiscos("Coxinha, 5.00, 10);
        }

        public double CalcularEstoque() {
            return (double)Preco * Quantidade;
        }

        public void ExibirProduto(){
            System.Console.WriteLine($"Nome: {this.Nome}");
            System.Console.WriteLine($"Preço: {this.Preco}");
            System.Console.WriteLine($"Quantidade: {this.Quantidade}");
            System.Console.WriteLine($"Total em estoque R$: {this.CalcularEstoque()}");
        }

    }

}