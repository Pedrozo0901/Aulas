namespace Aula_18_classe_abstrata
{
    public class Circulo : Forma
    {
        public double Raio;

        // Construtor
        public Circulo(string nome, double raio) : base(nome)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);  // PI * raio^2
        }      

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Raio: " + Raio);
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perimetro: " + CalcularPerimetro());
        }
    }
}