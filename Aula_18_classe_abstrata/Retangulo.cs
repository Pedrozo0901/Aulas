namespace Aula_18_classe_abstrata
{
    public class Retangulo : Forma
    {
        public double Largura;
        public double Altura;

        public Retangulo(string nome, double largura, double altura) : base(nome)
        {
            this.Largura = largura; // this é opcional porque está apontando a um atributo da classe global
            this.Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void ImprimirDados(){
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Largura: " + Largura);
            System.Console.WriteLine("Altura: " + Altura);
            System.Console.WriteLine("Area: " + CalcularArea());
            System.Console.WriteLine("Perimetro: " + CalcularPerimetro());
        }
    }
}