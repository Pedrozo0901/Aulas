namespace Aula_18_classe_abstrata
{
    public class Executar
    {
        static void Main(string[] args)
            // Só poderá instanciar as classes filhas
        {
            Circulo circulo = new Circulo("Circulo", 5);
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            circulo.ImprimirDados();

            System.Console.WriteLine("");

            Retangulo retangulo = new Retangulo("Retangulo", 10, 5);
            retangulo.CalcularArea();
            retangulo.CalcularPerimetro();
            retangulo.ImprimirDados();
        }
    }
}