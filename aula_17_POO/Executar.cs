namespace aula_17_POO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Ferramentas ferramenta1 = new Ferramentas("Martelo", 50.50, 10);
            Carnes carne1 = new Carnes("Coxão mole", 29.99, 30);
            Limpeza limpeza1 = new Limpeza("Detergente", 15.93, 200);
            Petiscos petisco1 = new Petiscos("Calabresa", 12.55, 29);
            Laticinios laticinio1 = new Laticinios("Iogurt", 12.20, 40);

            ferramenta1.ExibirProduto();
            System.Console.WriteLine("");
            carne1.ExibirProduto();
            System.Console.WriteLine("");
            limpeza1.ExibirProduto();
            System.Console.WriteLine("");
            petisco1.ExibirProduto();
            System.Console.WriteLine("");
            laticinio1.ExibirProduto();

            double maiorValor = Math.Max(carne1.CalcularEstoque(),    
                Math.Max(limpeza1.CalcularEstoque(),
                    Math.Max(ferramenta1.CalcularEstoque(),
                        laticinio1.CalcularEstoque())));

            System.Console.WriteLine($"Maior valor do estoque: {maiorValor}");
        }
    }
}