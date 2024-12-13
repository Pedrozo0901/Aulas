namespace aula_19_encapsulamento
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Bomba Aomica", 1000000);
            // Vou alter o nome do produto
            // p.SetNome("Bomba Nucear");
            p.Nome = "Bomba Hidrogenio";
            

            // Vou alter o preço do produto
            p.Preco = 7777;
            // Vou alter a quantidade do produto
            p.SetQuantidade(10);
            System.Console.WriteLine("Nome: " + p.Nome + " Preço: " + p.Preco + " Quantidade: " + p.GetQuantidade());

            System.Console.WriteLine(p.ToString());
        }
    }
}