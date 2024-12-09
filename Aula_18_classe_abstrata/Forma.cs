namespace Aula_18_classe_abstrata
{
    public abstract class Forma
    {
        public string Nome;

        // Construtor
        public Forma(string nome)
        {
            this.Nome = nome;
        }

        // Métodos abstratos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        // Método para imprimir dados (pode ser sobrescrito)
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Área: " + CalcularArea());
            System.Console.WriteLine("Perímetro: " + CalcularPerimetro());
        }
    }
}
