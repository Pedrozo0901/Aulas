namespace aula_17_desafio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Cobra cobra = new Cobra(true, true);
            cobra.setVenenosa(false);
            cobra.Alimento("Rato");
            cobra.ExibirDados();

            System.Console.WriteLine("");

            Javali javali = new Javali(true, true);
            javali.ExibirDados();
            javali.getSelvagem();
            javali.getVelocidadeMaxima(60);
            javali.ExibirDados();
            
        }
    }
}