namespace aula_17_desafio
{
    public class Javali : Animal
    {
        public bool Selvagem;

        public Javali(bool vivo, bool selvagem) : base (vivo)
        {
            this.Selvagem = selvagem;
        }

        public void getVelocidadeMaxima(int velocidade)
        {
            System.Console.WriteLine("Velocidade maxima: " + velocidade);
        }

        public void getSelvagem()
        {
            System.Console.WriteLine("Vivo: " + this.Selvagem);
        }

        public void ExibirDados()
        {
            System.Console.WriteLine("Animal: Javali");
            System.Console.WriteLine("Vivo: " + this.Vivo);
        }
    }
}